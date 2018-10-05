#undef DEBUG_SERIALPORT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ToolViewAccel
{
    public class CSerialPort : ISerialPort
    {
        // Protocol constants
        const Byte DATA_HDR = (Byte)0xCC;

        // Control variables
        private static SerialPort m_SPCurrent = null;
        private SerialDataReceivedEventHandler m_SPReceiveHandler = null;
        private static bool m_SPFlagNewData = false;
        private static HighLevelDataHandler m_HighLevelDataHandler = null;

        private static Queue<string> m_SPReceiveQueue = null;
        static System.Timers.Timer ReadDataScheduler;

        const int IntervalBetweenReceiveAndProcessDataMs = 25;
        public CSerialPort(SerialPort sp, HighLevelDataHandler handler)
        {
            string[] ports = null;

            m_SPCurrent = sp;
            m_SPReceiveHandler = new SerialDataReceivedEventHandler(DataReceiverHandler);
            m_SPReceiveQueue = new Queue<string>();

            // common setting for serial port
            m_SPCurrent.NewLine = "\n";
            m_SPCurrent.DataReceived += m_SPReceiveHandler;
            m_SPCurrent.Encoding = Encoding.Default;

            ports = SerialPort.GetPortNames();
            if(ports.Length > 0)
            {
                m_SPCurrent.PortName = ports[0];
            }

            RegisterHighLevelDataHandler(handler);
            m_SPCurrent.ReadTimeout = 100;
            m_SPCurrent.WriteTimeout = 100;

            ReadDataScheduler = new System.Timers.Timer(IntervalBetweenReceiveAndProcessDataMs);
            ReadDataScheduler.Elapsed += new System.Timers.ElapsedEventHandler(ReadDataSchedulerHandler);
        }

        private static void DataReceiverHandler(object sender, EventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string DataAsStr = sp.ReadExisting();
            m_SPReceiveQueue.Enqueue(DataAsStr); 

            Byte[] DataAsBytes = Encoding.Default.GetBytes(DataAsStr);

              
#if (DEBUG_SERIALPORT)
            Console.Write("-Rec: ");
            foreach (Byte b in DataAsBytes)
            {
                Console.Write(" {0:x}", b);
            }
            Console.WriteLine(" end");
#endif

            m_SPFlagNewData = true;

            if(ReadDataScheduler != null)
            {
                ReadDataScheduler.Enabled = true;
            }
        }
        private void ReadDataSchedulerHandler(object source, System.Timers.ElapsedEventArgs e)
        {
            ReadDataScheduler.Stop();
            m_HighLevelDataHandler();
        }
        

        /************************************************
         * From ISerialPort
         ************************************************/
        public bool OpenPort()
        {
            bool bRet = false;
            if (m_SPCurrent != null)
            {
                bRet = true;
                if (m_SPCurrent.IsOpen == false)
                {
                    try
                    {
                        m_SPCurrent.Open();
                    }
                    catch { bRet = false; }
                }
            }
            return bRet;
        }
        public bool OpenPort(string port)
        {
            if(m_SPCurrent == null)
            {
                return false;
            }

            try
            {
                m_SPCurrent.PortName = port;
                m_SPCurrent.Open();
            }
            catch
            {
                return false;
            }

            return true;
        }
        public bool ClosePort()
        {
            if (m_SPCurrent.PortName == null)
                return false;

            if (m_SPCurrent != null)
            {
                if (m_SPCurrent.IsOpen == true)
                {
                    try
                    {
                        m_SPCurrent.Close();
                        if (m_SPCurrent.IsOpen == true)
                        {
                            return false;
                        }
                    }
                    catch
                    {
                        return false;
                    }

                }
            }
            return true;
        }

        public bool CheckPort()
        {
            bool bRet = true;
            if (m_SPCurrent != null)
            {
                if (m_SPCurrent.IsOpen == true)
                {
                    string[] port = null;
                    port = SerialPort.GetPortNames();
                    if (port.Length > 0)
                    {
                        foreach (string element in port)
                        {
                            if (element == m_SPCurrent.PortName)
                            {
                                return bRet;
                            }
                        }
                        bRet = false;
                    }
                }
            }
            return bRet;
        }

        public bool IsPortOpen()
        {
            return m_SPCurrent.IsOpen;
        }

        public string GetPortName()
        {
            return m_SPCurrent.PortName;
        }

        public bool SetBaudRate(int _baudrate)
        {
            if(_baudrate < 0)
            {
                return false;
            }
            m_SPCurrent.BaudRate = _baudrate;
            return true;
        }

        public bool HandshakeSetting(HANDSHAKE_TYPE iMode)
        {
            bool bRet = false;
            try
            {
                switch ((int)iMode)
                {
                    case 0:
                        m_SPCurrent.Handshake = Handshake.RequestToSend;
                        break;

                    case 1:
                        m_SPCurrent.Handshake = Handshake.XOnXOff;
                        break;

                    case 2:
                        m_SPCurrent.Handshake = Handshake.RequestToSendXOnXOff;
                        break;

                    case 3:
                    default:
                        m_SPCurrent.Handshake = Handshake.None;
                        break;
                }
                bRet = true;
            }
            catch { }

            return bRet;
        }
        public bool DTRSetting(bool FlagEnable)
        {
            if (m_SPCurrent.IsOpen)
            {
                m_SPCurrent.DtrEnable = FlagEnable;
                return true;
            }
            return false;
        }
        public bool RTSSetting(bool FlagEnable)
        {
            if (m_SPCurrent.IsOpen)
            {
                if (FlagEnable == false) m_SPCurrent.BaseStream.Flush();
                m_SPCurrent.RtsEnable = FlagEnable;
                return true;
            }
            return false;
        }
        public bool RegisterHighLevelDataHandler(HighLevelDataHandler handler)
        {
            if(handler != null)
            {
                m_HighLevelDataHandler = handler;
                return true;
            }
            return false;
        }

        public bool Write(int iData)
        {
            return true;
        }
        public bool Write(string sData)
        {
            if(!m_SPCurrent.IsOpen)
            {
                return false;
            }
            m_SPCurrent.Write(sData);
            return true;
        }
        public bool Write(byte[] Data)
        {
            if(!m_SPCurrent.IsOpen)
            {
                return false;
            }

            string DataOutAsString = System.Text.Encoding.Default.GetString(Data);
            m_SPCurrent.Write(DataOutAsString);
            return true;
        }

        public string Read()
        {
            string sRet = null;

            if (m_SPCurrent.IsOpen == true)
            {
                while (m_SPReceiveQueue.Count > 0)
                {
                    sRet += m_SPReceiveQueue.Dequeue();
                }
                m_SPFlagNewData = false;
            }
            return sRet;
        }
        public Byte[] XtractInData()
        {
            string DataAsStr = this.Read();
            if(DataAsStr == null)
            {
                return null;
            }

            Byte[] ret = new Byte[0];
            Byte[] DataAsBytes = Encoding.Default.GetBytes(DataAsStr); 

            for(int i = 0; i < DataAsBytes.Length - 1; i++)
            {
                Byte data = DataAsBytes[i];
                if(data != DATA_HDR)
                {
                    continue; 
                }

                //Console.WriteLine("Got HDR");
                Byte length = DataAsBytes[i + 1];
                if(i + 2 + length >= DataAsBytes.Length)
                {
                    continue;
                }

                //Console.WriteLine("Got Length");
                Byte rec_crc = DataAsBytes[i + 2 + length];
                Byte[] rec_data = new Byte[length];
                Array.Copy(DataAsBytes, i + 2, rec_data, 0, length);
                Byte cal_crc = CalculateCRC8(rec_data, length);
                //Console.WriteLine("Rec_crc: {0}, Cal_crc {1}",rec_crc, cal_crc);
                if(rec_crc != cal_crc)
                {
                    continue;
                }
                // Somehow data got zero-out after crc
                Array.Copy(DataAsBytes, i + 2, rec_data, 0, length);
                ret = ret.Concat(rec_data).ToArray();
                i += length;
            }
            return ret;
        }

        private Byte CalculateCRC8(Byte[] data, int dataLength)
        {
            Byte crc = (Byte)0x00;
            Byte sum;
            for (int i = 0; i < dataLength; i++)
            {
                for (byte tmp = (Byte)8; tmp > 0; tmp--)
                {
                    sum = (Byte)((Byte)(crc ^ data[i]) & (Byte)0x01);
                    crc >>= 1;
                    if (sum > 0)
                    {
                        crc ^= (Byte)(0x8C);
                    }
                    data[i] >>= 1;
                }
            }
            return crc;
        }
    }

}
