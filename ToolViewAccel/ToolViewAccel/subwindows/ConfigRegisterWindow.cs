using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolViewAccel.subwindows
{
    public partial class ConfigRegisterWindow : Form
    {
        private ToolViewAccel.Monitor myCreator;
        public ConfigRegisterWindow(ToolViewAccel.Monitor parent)
        {
            myCreator = parent;
            InitializeComponent();
            InitializeVariableForRegister();
        }

        private void InitializeVariableForRegister()
        {
            for(int i = 0; i < myCreator.accel_Registers.Count; i++)
            {
                comboBox_REGs.Items.Add(myCreator.accel_Registers[i].name);
            }
            comboBox_REGs.Text = comboBox_REGs.Items[0].ToString();
        }

        private void buttonWriteReg_Click(object sender, EventArgs e)
        {
            int idx = comboBox_REGs.FindStringExact(comboBox_REGs.Text);
            if (idx == -1)
            {
                MessageBox.Show("Invalid Register");
                return;
            }

            string valueAsBinary = textBoxWriteValue.Text;
            if (valueAsBinary.Length != 8)
            {
                MessageBox.Show("Invalid value for register");
                return;
            }
            Accel_Register reg = myCreator.accel_Registers[idx];
            reg.value = Monitor.ParseBinaryToByte(valueAsBinary);
            myCreator.sendRegCommand(reg);
            //TODO: update app's variables according to config 
        }
    }
}
