using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolViewAccel;

using System.IO.Ports;
using System.Diagnostics;
using System.Text;

namespace ToolViewAccel_Test
{
    [TestClass]
    public class UnitTest_CSerialPort_OpenAndClose
    {
        SerialPort llPort;
        ISerialPort hlPort;
        HighLevelDataHandler highLevelDataHandler = null;
        public void SetupPort()
        {
            llPort = new SerialPort();
            hlPort = new CSerialPort(llPort, highLevelDataHandler);
        }

        public void Clean()
        {
            llPort.Close();
        }

        [TestMethod]
        public void Test_CSerialPort_OpenPort()
        {
            SetupPort();

            Assert.IsTrue(hlPort.OpenPort());
            Assert.IsTrue(llPort.IsOpen);

            Clean();
        }

        [TestMethod]
        public void Test_CSerialPort_ClosePort()
        {
            SetupPort();

            hlPort.OpenPort();
            
            Assert.IsTrue(hlPort.ClosePort());
            Assert.IsFalse(llPort.IsOpen);

            Clean();
        }

        [TestMethod]
        public void Test_CSerialPort_OpenSpecificPort()
        {
            SetupPort();

            Assert.IsTrue(hlPort.OpenPort("COM1"));
            Assert.IsTrue(llPort.IsOpen);
            Assert.AreEqual("COM1", hlPort.GetPortName());

            Clean();
        }
    }

    [TestClass]
    public class UnitTest_CSerialPOrt_ProcessIncomingData
    {
        SerialPort llPort;
        ISerialPort hlPort;
        HighLevelDataHandler highLevelDataHandler = null;
        public void SetupPort()
        {
            llPort = new SerialPort();
            hlPort = new CSerialPort(llPort,highLevelDataHandler);
            while(hlPort.OpenPort("COM5") == false)
            { }
        }

        public void Clean()
        {
            llPort.Close();
        }

        [TestMethod(), Timeout(6000)]
        public void Test_CSerialPort_Read()
        {
            SetupPort();
            try
            {
                Stopwatch timer = new Stopwatch();
                bool bGotData = false;
                bool bRightEncoding = false; // C# serial port encoding incoming data with UTF8,UTF16, etc thus makes data sent different from ones received at application
                timer.Start();
                while (timer.Elapsed.TotalSeconds < 5)
                {
                    string data = hlPort.Read();
                    if (data == null)
                    {
                        continue;
                    }

                    bGotData = true;
                    Byte[] DataAsByte = Encoding.Default.GetBytes(data);
                    foreach (Byte b in DataAsByte)
                    {
                        if(b == (Byte)(0xCC) )
                        {
                            bRightEncoding = true;
                            goto FINISH;
                        }
                    }
                }

                FINISH:
                Assert.IsTrue(bGotData );
                Assert.IsTrue(bRightEncoding);
            }
            finally
            {
                Clean();
            }
        }

        [TestMethod(), Timeout(6000)]
        public void Test_CSerialPort_XTractInData()
        {
            try
            {
                SetupPort();
                Stopwatch timer = new Stopwatch();
                bool bDataRightFormat = false;
                timer.Start();

                while(timer.Elapsed.TotalSeconds < 5)
                {
                    Byte[] rec = hlPort.XtractInData();
                    if(rec != null && rec.Length > 0)
                    {
                        bDataRightFormat = true;
                        break;
                    }
                }

                Assert.IsTrue(bDataRightFormat);
            }
            finally
            {
                Clean();
            }
       
        }
    }
} 