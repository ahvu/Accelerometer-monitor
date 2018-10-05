using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace ToolViewAccel
{
    public partial class Monitor : Form
    {
        public const byte SET_ACCEL_REGISTER = 0x99;
        public const byte DOLLAR_SIGN = 0x24;
        public const byte CHAR_UPPER_S = 0x53;
        public const byte CHAR_CR = 0x0D;

        public ISerialPort highLevelSerialPort = null;
        public List<Accel_Register> accel_Registers;
        public List<ODR_Setting> ODR_Settings;
        public List<int> BaudrateList;
        public List<Object> CommonResources;

        IGraph MainGraph = null;
        IDigitalFilter lowPassFilter = null;

        SystemManager AccelerometerErrorManager;
        MessageHandlerFactory messageHandlerFactory;
        public Monitor()
        {
            InitializeComponent();
            InitializeSubComponent();
            InitializeFactories();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void InitializeSubComponent()
        {
            InitializeSerialPort();
            InitializeGraphCompoment();
            InitializeVariableForRegister();

            AccelerometerErrorManager = new SystemManager();
            AccelerometerErrorManager.syncAccelerometerSamplingRateDelagate = SyncSamplingRate;
            lowPassFilter = new CLowPassFilter(0.1);
        }

        private void InitializeFactories()
        {
            CommonResources = new List<Object>();
            CommonResources.Add(highLevelSerialPort);
            CommonResources.Add(lowPassFilter);
            CommonResources.Add(AccelerometerErrorManager);
            CommonResources.Add(MainGraph);
            messageHandlerFactory = new MessageHandlerFactory(CommonResources);
        }

        private void InitializeSerialPort()
        {
            lowLevelSerialPort = new SerialPort();
            highLevelSerialPort = new CSerialPort(lowLevelSerialPort,highLevelDataHandler);
            BaudrateList = new List<int>();
            BaudrateList.Add(9600);
            BaudrateList.Add(115200);
            for(int i = 0; i < BaudrateList.Count; i++)
            {
                comboBoxBaudrate.Items.Add(BaudrateList[i].ToString());
            }
            comboBoxBaudrate.Text = comboBoxBaudrate.Items[0].ToString();
        }
        private void InitializeVariableForRegister()
        {
            accel_Registers = new List<Accel_Register>();

            accel_Registers.Add(new Accel_Register("CTRL_REG1", (byte)(0x20), (byte)(0x00)));
            accel_Registers.Add(new Accel_Register("CTRL_REG2", (byte)(0x21), (byte)(0x00)));
            accel_Registers.Add(new Accel_Register("CTRL_REG3", (byte)(0x22), (byte)(0x00)));
            accel_Registers.Add(new Accel_Register("CTRL_REG4", (byte)(0x23), (byte)(0x00)));
            accel_Registers.Add(new Accel_Register("CTRL_REG5", (byte)(0x24), (byte)(0x00)));
            accel_Registers.Add(new Accel_Register("CTRL_REG6", (byte)(0x25), (byte)(0x00)));

            ODR_Settings = new List<ODR_Setting>();
            ODR_Settings.Add(new ODR_Setting(0, 0x07));
            ODR_Settings.Add(new ODR_Setting(1, 0x17));
            ODR_Settings.Add(new ODR_Setting(10, 0x27));
            ODR_Settings.Add(new ODR_Setting(25, 0x37));
            ODR_Settings.Add(new ODR_Setting(50, 0x47));
            ODR_Settings.Add(new ODR_Setting(100, 0x57));
            ODR_Settings.Add(new ODR_Setting(200, 0x67));
            ODR_Settings.Add(new ODR_Setting(400, 0x77));

            for(int i = 0; i < ODR_Settings.Count; i++)
            {
                if(ODR_Settings[i].rate == 0)
                {
                    comboBox_ODR.Items.Add("Off");
                }
                else
                {
                    comboBox_ODR.Items.Add(((double)1000/ODR_Settings[i].rate).ToString() + " ms");
                }
            }
            comboBox_ODR.Text = comboBox_ODR.Items[5].ToString();
        }
        private void InitializeGraphCompoment()
        { 
            MainGraph = new CZedGraph_RealTime(zedGraphControl1);
            MainGraph.SetGraphTitle("Accelerometer data");
            MainGraph.SetAxisXTitle("Time (s)");
            MainGraph.SetAxisYTitle("G");
            MainGraph.AddCurve("X", Color.Red);
            MainGraph.AddCurve("Y", Color.Blue);
            MainGraph.AddCurve("Z", Color.Green);

            MainGraph.SetYAxis_MaxValue(2);
            MainGraph.SetYAxis_MinValue(-2);

            hScrollBar_XScale.Value = 5;
            textBoxCurTimeScale.Text = hScrollBar_XScale.Value.ToString();
            textBoxMinTimeScale.Text = hScrollBar_XScale.Minimum.ToString();
            textBoxMaxTimeScale.Text = hScrollBar_XScale.Maximum.ToString();
        }

        private void highLevelDataHandler()
        {
            Byte[] rawData = highLevelSerialPort.XtractInData();
            IMessageHandler messageHandler = messageHandlerFactory.GetMessageHandler(CAccelerometerDataMessageHandler.MessageType);
            messageHandler.handleMessage(rawData);
        }


        public delegate void DoActionCrossThread();
        public void SyncSamplingRate()
        {
            if(highLevelSerialPort.IsPortOpen())
            {
                this.Invoke(new DoActionCrossThread(DoSyncSamplingRateWithDevice));
            }
        }
        public void DoSyncSamplingRateWithDevice()
        {
            buttonSetODR_Click(buttonSetODR, new EventArgs());
        }

        public void sendRegCommand(Accel_Register reg)
        {
            if (!highLevelSerialPort.IsPortOpen())
            {
                MessageBox.Show("Port is not opened yet");
                return;
            }

            byte[] DataOut = { DOLLAR_SIGN, SET_ACCEL_REGISTER, reg.address, reg.value, CHAR_CR };
            highLevelSerialPort.Write(DataOut);
        }

        public static byte ParseBinaryToByte(string binary)
        {

            byte myByte = 0;
            int bits = 8;
            while(bits-- > 0)
            {
                byte tmp = ((binary[7 - bits] == '1') ? (byte)0x01 : (byte)0x00);
                if(tmp > 0)
                {
                    myByte |= (byte)(tmp << (byte)bits);
                }
            }
            Console.WriteLine("myByte {0}", myByte);
            return myByte;
        }
        
        public int GetRegisterIndexByName(string name)
        {
            for(int i = 0; i < accel_Registers.Count; i++)
            {
                if (accel_Registers[i].name == name)
                    return i;
            }
            return -1;
        }

        private void buttonSetODR_Click(object sender, EventArgs e)
        {
            int odr_idx = comboBox_ODR.FindString(comboBox_ODR.Text);
            if(odr_idx < 0)
            {
                MessageBox.Show("Invalid ODR choice");
                return;
            }
            ODR_Setting odr_setting = ODR_Settings[odr_idx];
            int reg_idx = GetRegisterIndexByName("CTRL_REG1");
            Accel_Register reg = accel_Registers[reg_idx];

            reg.value = odr_setting.reg_val;
            AccelerometerData.samplingRate = odr_setting.rate;

            sendRegCommand(reg);
        }

        private void comboBox_Ports_MouseEnter(object sender, EventArgs e)
        {
            comboBox_Ports.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string p in ports)
            {
                comboBox_Ports.Items.Add(p);
            }
        }

        private void button_OpenSP_Click_1(object sender, EventArgs e)
        {
            if (highLevelSerialPort.IsPortOpen())
            {
                if(highLevelSerialPort.ClosePort())
                {
                    button_OpenSP.Text = "Disconnected";
                }
                else if(!highLevelSerialPort.IsPortOpen())
                {
                    button_OpenSP.Text = "Disconnected";
                }
                else
                {
                    MessageBox.Show("Cannot close port");
                }
            }
            else
            {
                string port = comboBox_Ports.Text;
                if (port == "")
                {
                    MessageBox.Show("No port selected");
                }
                else
                {
                    if(highLevelSerialPort.OpenPort(port))
                    {
                        button_OpenSP.Text = "Connected";
                        byte[] DataOut = { DOLLAR_SIGN, CHAR_UPPER_S, CHAR_CR };
                        highLevelSerialPort.Write(DataOut);
                    }
                    else
                    {
                        MessageBox.Show("Cannot open port");
                    }
                }
            }
        }

        private void hScrollBar_XScale_ValueChanged(object sender, EventArgs e)
        {
            textBoxCurTimeScale.Text = hScrollBar_XScale.Value.ToString() ;
            textBoxMinTimeScale.Text = hScrollBar_XScale.Minimum.ToString();
            textBoxMaxTimeScale.Text = hScrollBar_XScale.Maximum.ToString();

            int sliderValue = hScrollBar_XScale.Value;
            MainGraph.SetXRangeFixed(sliderValue);
            MainGraph.Render();
        }

        private void textBoxCurTimeScale_TextChanged(object sender, EventArgs e)
        {
            int timeScale = hScrollBar_XScale.Value;
            try
            {
                timeScale = System.Convert.ToInt32(textBoxCurTimeScale.Text);
                if (timeScale < hScrollBar_XScale.Minimum) throw new IndexOutOfRangeException();
                if (timeScale > hScrollBar_XScale.Maximum) hScrollBar_XScale.Maximum = timeScale;
                hScrollBar_XScale.Value = timeScale;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                textBoxCurTimeScale.Text = timeScale.ToString();
            }
        }
        private void textBoxMinTimeScale_TextChanged(object sender, EventArgs e)
        {
            int minScale = hScrollBar_XScale.Minimum;
            try
            {
                minScale = System.Convert.ToInt32(textBoxMinTimeScale.Text);
                if (minScale < 1 || minScale > hScrollBar_XScale.Maximum) throw new IndexOutOfRangeException();
                hScrollBar_XScale.Minimum = minScale;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                textBoxMinTimeScale.Text = minScale.ToString();
            }
        }
        private void textBoxMaxTimeScale_TextChanged(object sender, EventArgs e)
        {
            int maxScale = hScrollBar_XScale.Maximum;
            try
            {
                maxScale = System.Convert.ToInt32(textBoxMaxTimeScale.Text);
                if (maxScale < hScrollBar_XScale.Minimum) throw new IndexOutOfRangeException();
                hScrollBar_XScale.Maximum = maxScale;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                textBoxMaxTimeScale.Text = maxScale.ToString();
            }
        }

        private void comboBoxBaudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(highLevelSerialPort != null)
            {
                int baudrate = BaudrateList[comboBoxBaudrate.SelectedIndex];
                highLevelSerialPort.SetBaudRate(baudrate);
            }
        }

        subwindows.ConfigRegisterWindow configRegisterWindow;
        private void buttonConfigureRegister_Click(object sender, EventArgs e)
        {
            if(configRegisterWindow == null)
            {
                configRegisterWindow = new subwindows.ConfigRegisterWindow(this);
            }
            configRegisterWindow.ShowDialog();
        }

        private void checkBoxIsLowPassFilterEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxIsLowPassFilterEnabled.Checked)
            {
                lowPassFilter.Enable();
            }
            else
            {
                lowPassFilter.Disable();
            }
        }

        const byte EnableHighPassFilter = (byte)0x08;
        const byte DisableHighPassFilter = (byte)0x00;
        private void checkboxIsHighPassFilterEnabled_CheckedChanged(object sender, EventArgs e)
        {
            int reg_idx = GetRegisterIndexByName("CTRL_REG2");
            Accel_Register reg = accel_Registers[reg_idx];
            if(checkboxIsHighPassFilterEnabled.Checked)
            {
                reg.value = EnableHighPassFilter;
            }
            else
            {
                reg.value = DisableHighPassFilter;
            }

            sendRegCommand(reg);
        }

    }
} 