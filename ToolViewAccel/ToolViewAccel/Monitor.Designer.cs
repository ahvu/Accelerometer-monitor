namespace ToolViewAccel
{
    partial class Monitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
            this.lowLevelSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel_Overview = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.button_OpenSP = new System.Windows.Forms.Button();
            this.comboBox_Ports = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSetODR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ODR = new System.Windows.Forms.ComboBox();
            this.checkboxIsHighPassFilterEnabled = new System.Windows.Forms.CheckBox();
            this.buttonConfigureRegister = new System.Windows.Forms.Button();
            this.checkBoxIsLowPassFilterEnabled = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelCenter = new System.Windows.Forms.TableLayoutPanel();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tableLayoutPanelLowerRight = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelUpperRight = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLower = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTimeScaleCommon = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTimeScaleInput = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxMaxTimeScale = new System.Windows.Forms.TextBox();
            this.labelMaxTimeScale = new System.Windows.Forms.Label();
            this.textBoxMinTimeScale = new System.Windows.Forms.TextBox();
            this.labelMinScale = new System.Windows.Forms.Label();
            this.textBoxCurTimeScale = new System.Windows.Forms.TextBox();
            this.labelCurTimeScale = new System.Windows.Forms.Label();
            this.hScrollBar_XScale = new System.Windows.Forms.HScrollBar();
            this.tableLayoutPanelLowerLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelUpperLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelUpper = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Overview.SuspendLayout();
            this.tableLayoutPanelRight.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanelCenter.SuspendLayout();
            this.tableLayoutPanelLower.SuspendLayout();
            this.tableLayoutPanelTimeScaleCommon.SuspendLayout();
            this.tableLayoutPanelTimeScaleInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Overview
            // 
            this.tableLayoutPanel_Overview.ColumnCount = 3;
            this.tableLayoutPanel_Overview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel_Overview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.11076F));
            this.tableLayoutPanel_Overview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.88923F));
            this.tableLayoutPanel_Overview.Controls.Add(this.tableLayoutPanelRight, 2, 1);
            this.tableLayoutPanel_Overview.Controls.Add(this.tableLayoutPanelCenter, 1, 1);
            this.tableLayoutPanel_Overview.Controls.Add(this.tableLayoutPanelLowerRight, 2, 2);
            this.tableLayoutPanel_Overview.Controls.Add(this.tableLayoutPanelUpperRight, 2, 0);
            this.tableLayoutPanel_Overview.Controls.Add(this.tableLayoutPanelLower, 1, 2);
            this.tableLayoutPanel_Overview.Controls.Add(this.tableLayoutPanelLowerLeft, 0, 2);
            this.tableLayoutPanel_Overview.Controls.Add(this.tableLayoutPanelLeft, 0, 1);
            this.tableLayoutPanel_Overview.Controls.Add(this.tableLayoutPanelUpperLeft, 0, 0);
            this.tableLayoutPanel_Overview.Controls.Add(this.tableLayoutPanelUpper, 1, 0);
            this.tableLayoutPanel_Overview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Overview.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Overview.Name = "tableLayoutPanel_Overview";
            this.tableLayoutPanel_Overview.RowCount = 3;
            this.tableLayoutPanel_Overview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel_Overview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.06219F));
            this.tableLayoutPanel_Overview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.937807F));
            this.tableLayoutPanel_Overview.Size = new System.Drawing.Size(1225, 762);
            this.tableLayoutPanel_Overview.TabIndex = 4;
            // 
            // tableLayoutPanelRight
            // 
            this.tableLayoutPanelRight.ColumnCount = 1;
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRight.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanelRight.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRight.Location = new System.Drawing.Point(1057, 3);
            this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            this.tableLayoutPanelRight.RowCount = 2;
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.04317F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.95683F));
            this.tableLayoutPanelRight.Size = new System.Drawing.Size(165, 695);
            this.tableLayoutPanelRight.TabIndex = 5;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 601);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(159, 91);
            this.tableLayoutPanel9.TabIndex = 5;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.button_OpenSP, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.comboBox_Ports, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.comboBoxBaudrate, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.22148F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.22148F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.55704F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(153, 85);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // button_OpenSP
            // 
            this.button_OpenSP.AutoSize = true;
            this.button_OpenSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OpenSP.Location = new System.Drawing.Point(3, 59);
            this.button_OpenSP.Name = "button_OpenSP";
            this.button_OpenSP.Size = new System.Drawing.Size(147, 23);
            this.button_OpenSP.TabIndex = 3;
            this.button_OpenSP.Text = "Connect";
            this.button_OpenSP.UseVisualStyleBackColor = true;
            this.button_OpenSP.Click += new System.EventHandler(this.button_OpenSP_Click_1);
            // 
            // comboBox_Ports
            // 
            this.comboBox_Ports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Ports.FormattingEnabled = true;
            this.comboBox_Ports.Location = new System.Drawing.Point(3, 3);
            this.comboBox_Ports.Name = "comboBox_Ports";
            this.comboBox_Ports.Size = new System.Drawing.Size(147, 21);
            this.comboBox_Ports.TabIndex = 2;
            this.comboBox_Ports.MouseEnter += new System.EventHandler(this.comboBox_Ports_MouseEnter);
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Location = new System.Drawing.Point(3, 31);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(147, 21);
            this.comboBoxBaudrate.TabIndex = 0;
            this.comboBoxBaudrate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaudrate_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkboxIsHighPassFilterEnabled, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonConfigureRegister, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxIsLowPassFilterEnabled, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.72527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.27472F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 470F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(159, 592);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.90196F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.09804F));
            this.tableLayoutPanel3.Controls.Add(this.buttonSetODR, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_ODR, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(153, 62);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // buttonSetODR
            // 
            this.buttonSetODR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetODR.Location = new System.Drawing.Point(3, 33);
            this.buttonSetODR.Name = "buttonSetODR";
            this.buttonSetODR.Size = new System.Drawing.Size(77, 25);
            this.buttonSetODR.TabIndex = 17;
            this.buttonSetODR.Text = "Set ODR";
            this.buttonSetODR.UseVisualStyleBackColor = true;
            this.buttonSetODR.Click += new System.EventHandler(this.buttonSetODR_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sampling rate";
            // 
            // comboBox_ODR
            // 
            this.comboBox_ODR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ODR.FormattingEnabled = true;
            this.comboBox_ODR.Location = new System.Drawing.Point(83, 35);
            this.comboBox_ODR.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_ODR.MaximumSize = new System.Drawing.Size(300, 0);
            this.comboBox_ODR.Name = "comboBox_ODR";
            this.comboBox_ODR.Size = new System.Drawing.Size(70, 21);
            this.comboBox_ODR.TabIndex = 16;
            // 
            // checkboxIsHighPassFilterEnabled
            // 
            this.checkboxIsHighPassFilterEnabled.AutoSize = true;
            this.checkboxIsHighPassFilterEnabled.Location = new System.Drawing.Point(3, 73);
            this.checkboxIsHighPassFilterEnabled.Name = "checkboxIsHighPassFilterEnabled";
            this.checkboxIsHighPassFilterEnabled.Size = new System.Drawing.Size(99, 17);
            this.checkboxIsHighPassFilterEnabled.TabIndex = 20;
            this.checkboxIsHighPassFilterEnabled.Text = "Gravity removal";
            this.checkboxIsHighPassFilterEnabled.UseVisualStyleBackColor = true;
            this.checkboxIsHighPassFilterEnabled.CheckedChanged += new System.EventHandler(this.checkboxIsHighPassFilterEnabled_CheckedChanged);
            // 
            // buttonConfigureRegister
            // 
            this.buttonConfigureRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonConfigureRegister.Location = new System.Drawing.Point(3, 124);
            this.buttonConfigureRegister.Name = "buttonConfigureRegister";
            this.buttonConfigureRegister.Size = new System.Drawing.Size(153, 47);
            this.buttonConfigureRegister.TabIndex = 21;
            this.buttonConfigureRegister.Text = "Configure registers";
            this.buttonConfigureRegister.UseVisualStyleBackColor = true;
            this.buttonConfigureRegister.Click += new System.EventHandler(this.buttonConfigureRegister_Click);
            // 
            // checkBoxIsLowPassFilterEnabled
            // 
            this.checkBoxIsLowPassFilterEnabled.AutoSize = true;
            this.checkBoxIsLowPassFilterEnabled.Location = new System.Drawing.Point(3, 97);
            this.checkBoxIsLowPassFilterEnabled.Name = "checkBoxIsLowPassFilterEnabled";
            this.checkBoxIsLowPassFilterEnabled.Size = new System.Drawing.Size(93, 17);
            this.checkBoxIsLowPassFilterEnabled.TabIndex = 22;
            this.checkBoxIsLowPassFilterEnabled.Text = "Low pass filter";
            this.checkBoxIsLowPassFilterEnabled.UseVisualStyleBackColor = true;
            this.checkBoxIsLowPassFilterEnabled.CheckedChanged += new System.EventHandler(this.checkBoxIsLowPassFilterEnabled_CheckedChanged);
            // 
            // tableLayoutPanelCenter
            // 
            this.tableLayoutPanelCenter.ColumnCount = 1;
            this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCenter.Controls.Add(this.zedGraphControl1, 0, 0);
            this.tableLayoutPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCenter.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelCenter.Name = "tableLayoutPanelCenter";
            this.tableLayoutPanelCenter.RowCount = 1;
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCenter.Size = new System.Drawing.Size(1048, 695);
            this.tableLayoutPanelCenter.TabIndex = 7;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1042, 689);
            this.zedGraphControl1.TabIndex = 4;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // tableLayoutPanelLowerRight
            // 
            this.tableLayoutPanelLowerRight.ColumnCount = 1;
            this.tableLayoutPanelLowerRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLowerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLowerRight.Location = new System.Drawing.Point(1057, 704);
            this.tableLayoutPanelLowerRight.Name = "tableLayoutPanelLowerRight";
            this.tableLayoutPanelLowerRight.RowCount = 1;
            this.tableLayoutPanelLowerRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLowerRight.Size = new System.Drawing.Size(165, 55);
            this.tableLayoutPanelLowerRight.TabIndex = 8;
            // 
            // tableLayoutPanelUpperRight
            // 
            this.tableLayoutPanelUpperRight.ColumnCount = 1;
            this.tableLayoutPanelUpperRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUpperRight.Location = new System.Drawing.Point(1057, 3);
            this.tableLayoutPanelUpperRight.Name = "tableLayoutPanelUpperRight";
            this.tableLayoutPanelUpperRight.RowCount = 1;
            this.tableLayoutPanelUpperRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUpperRight.Size = new System.Drawing.Size(165, 1);
            this.tableLayoutPanelUpperRight.TabIndex = 6;
            // 
            // tableLayoutPanelLower
            // 
            this.tableLayoutPanelLower.ColumnCount = 1;
            this.tableLayoutPanelLower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLower.Controls.Add(this.tableLayoutPanelTimeScaleCommon, 0, 0);
            this.tableLayoutPanelLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLower.Location = new System.Drawing.Point(3, 704);
            this.tableLayoutPanelLower.Name = "tableLayoutPanelLower";
            this.tableLayoutPanelLower.RowCount = 1;
            this.tableLayoutPanelLower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLower.Size = new System.Drawing.Size(1048, 55);
            this.tableLayoutPanelLower.TabIndex = 9;
            // 
            // tableLayoutPanelTimeScaleCommon
            // 
            this.tableLayoutPanelTimeScaleCommon.ColumnCount = 1;
            this.tableLayoutPanelTimeScaleCommon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTimeScaleCommon.Controls.Add(this.tableLayoutPanelTimeScaleInput, 0, 1);
            this.tableLayoutPanelTimeScaleCommon.Controls.Add(this.hScrollBar_XScale, 0, 0);
            this.tableLayoutPanelTimeScaleCommon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTimeScaleCommon.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTimeScaleCommon.Name = "tableLayoutPanelTimeScaleCommon";
            this.tableLayoutPanelTimeScaleCommon.RowCount = 2;
            this.tableLayoutPanelTimeScaleCommon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanelTimeScaleCommon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.tableLayoutPanelTimeScaleCommon.Size = new System.Drawing.Size(1042, 49);
            this.tableLayoutPanelTimeScaleCommon.TabIndex = 6;
            // 
            // tableLayoutPanelTimeScaleInput
            // 
            this.tableLayoutPanelTimeScaleInput.ColumnCount = 8;
            this.tableLayoutPanelTimeScaleInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.5102F));
            this.tableLayoutPanelTimeScaleInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tableLayoutPanelTimeScaleInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tableLayoutPanelTimeScaleInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tableLayoutPanelTimeScaleInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tableLayoutPanelTimeScaleInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tableLayoutPanelTimeScaleInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tableLayoutPanelTimeScaleInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.5102F));
            this.tableLayoutPanelTimeScaleInput.Controls.Add(this.textBoxMaxTimeScale, 6, 0);
            this.tableLayoutPanelTimeScaleInput.Controls.Add(this.labelMaxTimeScale, 5, 0);
            this.tableLayoutPanelTimeScaleInput.Controls.Add(this.textBoxMinTimeScale, 4, 0);
            this.tableLayoutPanelTimeScaleInput.Controls.Add(this.labelMinScale, 3, 0);
            this.tableLayoutPanelTimeScaleInput.Controls.Add(this.textBoxCurTimeScale, 2, 0);
            this.tableLayoutPanelTimeScaleInput.Controls.Add(this.labelCurTimeScale, 1, 0);
            this.tableLayoutPanelTimeScaleInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTimeScaleInput.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanelTimeScaleInput.Name = "tableLayoutPanelTimeScaleInput";
            this.tableLayoutPanelTimeScaleInput.RowCount = 1;
            this.tableLayoutPanelTimeScaleInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTimeScaleInput.Size = new System.Drawing.Size(1036, 26);
            this.tableLayoutPanelTimeScaleInput.TabIndex = 5;
            // 
            // textBoxMaxTimeScale
            // 
            this.textBoxMaxTimeScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMaxTimeScale.Location = new System.Drawing.Point(687, 3);
            this.textBoxMaxTimeScale.Name = "textBoxMaxTimeScale";
            this.textBoxMaxTimeScale.Size = new System.Drawing.Size(78, 20);
            this.textBoxMaxTimeScale.TabIndex = 3;
            this.textBoxMaxTimeScale.TextChanged += new System.EventHandler(this.textBoxMaxTimeScale_TextChanged);
            // 
            // labelMaxTimeScale
            // 
            this.labelMaxTimeScale.AutoSize = true;
            this.labelMaxTimeScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaxTimeScale.Location = new System.Drawing.Point(603, 0);
            this.labelMaxTimeScale.Name = "labelMaxTimeScale";
            this.labelMaxTimeScale.Size = new System.Drawing.Size(78, 26);
            this.labelMaxTimeScale.TabIndex = 4;
            this.labelMaxTimeScale.Text = "Max scale";
            // 
            // textBoxMinTimeScale
            // 
            this.textBoxMinTimeScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMinTimeScale.Location = new System.Drawing.Point(519, 3);
            this.textBoxMinTimeScale.Name = "textBoxMinTimeScale";
            this.textBoxMinTimeScale.Size = new System.Drawing.Size(78, 20);
            this.textBoxMinTimeScale.TabIndex = 1;
            this.textBoxMinTimeScale.TextChanged += new System.EventHandler(this.textBoxMinTimeScale_TextChanged);
            // 
            // labelMinScale
            // 
            this.labelMinScale.AutoSize = true;
            this.labelMinScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMinScale.Location = new System.Drawing.Point(435, 0);
            this.labelMinScale.Name = "labelMinScale";
            this.labelMinScale.Size = new System.Drawing.Size(78, 26);
            this.labelMinScale.TabIndex = 2;
            this.labelMinScale.Text = "Min scale";
            // 
            // textBoxCurTimeScale
            // 
            this.textBoxCurTimeScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCurTimeScale.Location = new System.Drawing.Point(351, 3);
            this.textBoxCurTimeScale.Name = "textBoxCurTimeScale";
            this.textBoxCurTimeScale.Size = new System.Drawing.Size(78, 20);
            this.textBoxCurTimeScale.TabIndex = 5;
            this.textBoxCurTimeScale.TextChanged += new System.EventHandler(this.textBoxCurTimeScale_TextChanged);
            // 
            // labelCurTimeScale
            // 
            this.labelCurTimeScale.AutoSize = true;
            this.labelCurTimeScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurTimeScale.Location = new System.Drawing.Point(267, 0);
            this.labelCurTimeScale.Name = "labelCurTimeScale";
            this.labelCurTimeScale.Size = new System.Drawing.Size(78, 26);
            this.labelCurTimeScale.TabIndex = 0;
            this.labelCurTimeScale.Text = "Time scale";
            // 
            // hScrollBar_XScale
            // 
            this.hScrollBar_XScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hScrollBar_XScale.Location = new System.Drawing.Point(0, 0);
            this.hScrollBar_XScale.Maximum = 30;
            this.hScrollBar_XScale.Minimum = 1;
            this.hScrollBar_XScale.Name = "hScrollBar_XScale";
            this.hScrollBar_XScale.Size = new System.Drawing.Size(1042, 17);
            this.hScrollBar_XScale.TabIndex = 4;
            this.hScrollBar_XScale.Value = 1;
            this.hScrollBar_XScale.ValueChanged += new System.EventHandler(this.hScrollBar_XScale_ValueChanged);
            // 
            // tableLayoutPanelLowerLeft
            // 
            this.tableLayoutPanelLowerLeft.ColumnCount = 1;
            this.tableLayoutPanelLowerLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLowerLeft.Location = new System.Drawing.Point(3, 704);
            this.tableLayoutPanelLowerLeft.Name = "tableLayoutPanelLowerLeft";
            this.tableLayoutPanelLowerLeft.RowCount = 1;
            this.tableLayoutPanelLowerLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLowerLeft.Size = new System.Drawing.Size(1, 55);
            this.tableLayoutPanelLowerLeft.TabIndex = 10;
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.ColumnCount = 1;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 1;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(1, 421);
            this.tableLayoutPanelLeft.TabIndex = 11;
            // 
            // tableLayoutPanelUpperLeft
            // 
            this.tableLayoutPanelUpperLeft.ColumnCount = 1;
            this.tableLayoutPanelUpperLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUpperLeft.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelUpperLeft.Name = "tableLayoutPanelUpperLeft";
            this.tableLayoutPanelUpperLeft.RowCount = 1;
            this.tableLayoutPanelUpperLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUpperLeft.Size = new System.Drawing.Size(1, 1);
            this.tableLayoutPanelUpperLeft.TabIndex = 12;
            // 
            // tableLayoutPanelUpper
            // 
            this.tableLayoutPanelUpper.ColumnCount = 1;
            this.tableLayoutPanelUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUpper.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelUpper.Name = "tableLayoutPanelUpper";
            this.tableLayoutPanelUpper.RowCount = 1;
            this.tableLayoutPanelUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUpper.Size = new System.Drawing.Size(707, 1);
            this.tableLayoutPanelUpper.TabIndex = 13;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 762);
            this.Controls.Add(this.tableLayoutPanel_Overview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Monitor";
            this.Text = "Datalogic Vietnam - Accelerometer monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel_Overview.ResumeLayout(false);
            this.tableLayoutPanelRight.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanelCenter.ResumeLayout(false);
            this.tableLayoutPanelLower.ResumeLayout(false);
            this.tableLayoutPanelTimeScaleCommon.ResumeLayout(false);
            this.tableLayoutPanelTimeScaleInput.ResumeLayout(false);
            this.tableLayoutPanelTimeScaleInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort lowLevelSerialPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Overview;
        private System.Windows.Forms.ComboBox comboBox_Ports;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUpperRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCenter;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLowerRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLower;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLowerLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUpperLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUpper;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTimeScaleCommon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTimeScaleInput;
        private System.Windows.Forms.TextBox textBoxCurTimeScale;
        private System.Windows.Forms.Label labelMinScale;
        private System.Windows.Forms.Label labelCurTimeScale;
        private System.Windows.Forms.TextBox textBoxMaxTimeScale;
        private System.Windows.Forms.TextBox textBoxMinTimeScale;
        private System.Windows.Forms.HScrollBar hScrollBar_XScale;
        private System.Windows.Forms.Label labelMaxTimeScale;
        private System.Windows.Forms.Button button_OpenSP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkboxIsHighPassFilterEnabled;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonSetODR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ODR;
        private System.Windows.Forms.Button buttonConfigureRegister;
        private System.Windows.Forms.CheckBox checkBoxIsLowPassFilterEnabled;
    }
}

