namespace MECH423_Lab2_Exam_Serial_Comm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmbComPort = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtBaudRate = new System.Windows.Forms.ToolStripTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.changeKeysToDefaultColor = new System.Windows.Forms.Timer(this.components);
            this.positionCorrectionTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkShowResponse = new System.Windows.Forms.CheckBox();
            this.lblIncomingDataRate = new System.Windows.Forms.Label();
            this.txtRawSerial = new System.Windows.Forms.TextBox();
            this.tbHalfSteps = new System.Windows.Forms.TextBox();
            this.btTransmitHalfSteps = new System.Windows.Forms.Button();
            this.btHalfStepCCW = new System.Windows.Forms.Button();
            this.btHalfStepCW = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumHalfSteps = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btAsharp = new System.Windows.Forms.Button();
            this.btGsharp = new System.Windows.Forms.Button();
            this.btFsharp = new System.Windows.Forms.Button();
            this.btDsharp = new System.Windows.Forms.Button();
            this.btCsharp = new System.Windows.Forms.Button();
            this.btC4 = new System.Windows.Forms.Button();
            this.btB3_top = new System.Windows.Forms.Button();
            this.btB3 = new System.Windows.Forms.Button();
            this.btA3_top = new System.Windows.Forms.Button();
            this.btA3 = new System.Windows.Forms.Button();
            this.btG3_top = new System.Windows.Forms.Button();
            this.btG3 = new System.Windows.Forms.Button();
            this.btF3_top = new System.Windows.Forms.Button();
            this.btF3 = new System.Windows.Forms.Button();
            this.btE3_top = new System.Windows.Forms.Button();
            this.btE3 = new System.Windows.Forms.Button();
            this.btD3_top = new System.Windows.Forms.Button();
            this.btD3 = new System.Windows.Forms.Button();
            this.btC3_top = new System.Windows.Forms.Button();
            this.btC3 = new System.Windows.Forms.Button();
            this.pbStop = new System.Windows.Forms.PictureBox();
            this.pbPause = new System.Windows.Forms.PictureBox();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.btJingleBells = new System.Windows.Forms.Button();
            this.pbPiano = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbComPort,
            this.toolStripLabel1,
            this.txtBaudRate,
            this.btnConnect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(648, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmbComPort
            // 
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(159, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 25);
            this.toolStripLabel1.Text = "Baud Rate:";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(92, 28);
            this.txtBaudRate.Text = "9600";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // changeKeysToDefaultColor
            // 
            this.changeKeysToDefaultColor.Interval = 500;
            this.changeKeysToDefaultColor.Tick += new System.EventHandler(this.changeKeysToDefaultColor_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(671, 615);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkShowResponse);
            this.tabPage2.Controls.Add(this.lblIncomingDataRate);
            this.tabPage2.Controls.Add(this.txtRawSerial);
            this.tabPage2.Controls.Add(this.tbHalfSteps);
            this.tabPage2.Controls.Add(this.btTransmitHalfSteps);
            this.tabPage2.Controls.Add(this.btHalfStepCCW);
            this.tabPage2.Controls.Add(this.btHalfStepCW);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtNumHalfSteps);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(663, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calibration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkShowResponse
            // 
            this.chkShowResponse.AutoSize = true;
            this.chkShowResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowResponse.Location = new System.Drawing.Point(365, 25);
            this.chkShowResponse.Margin = new System.Windows.Forms.Padding(4);
            this.chkShowResponse.Name = "chkShowResponse";
            this.chkShowResponse.Size = new System.Drawing.Size(252, 29);
            this.chkShowResponse.TabIndex = 39;
            this.chkShowResponse.Text = "Response from Com Port";
            this.chkShowResponse.UseVisualStyleBackColor = true;
            // 
            // lblIncomingDataRate
            // 
            this.lblIncomingDataRate.AutoSize = true;
            this.lblIncomingDataRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblIncomingDataRate.Location = new System.Drawing.Point(365, 99);
            this.lblIncomingDataRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncomingDataRate.Name = "lblIncomingDataRate";
            this.lblIncomingDataRate.Size = new System.Drawing.Size(255, 18);
            this.lblIncomingDataRate.TabIndex = 38;
            this.lblIncomingDataRate.Text = "Incoming Data Rate = 0 bytes/second";
            this.lblIncomingDataRate.Visible = false;
            // 
            // txtRawSerial
            // 
            this.txtRawSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawSerial.Location = new System.Drawing.Point(368, 60);
            this.txtRawSerial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRawSerial.Multiline = true;
            this.txtRawSerial.Name = "txtRawSerial";
            this.txtRawSerial.ReadOnly = true;
            this.txtRawSerial.Size = new System.Drawing.Size(249, 35);
            this.txtRawSerial.TabIndex = 40;
            // 
            // tbHalfSteps
            // 
            this.tbHalfSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbHalfSteps.Location = new System.Drawing.Point(22, 125);
            this.tbHalfSteps.Name = "tbHalfSteps";
            this.tbHalfSteps.Size = new System.Drawing.Size(103, 30);
            this.tbHalfSteps.TabIndex = 37;
            this.tbHalfSteps.TextChanged += new System.EventHandler(this.genericTextBoxEventHandler);
            // 
            // btTransmitHalfSteps
            // 
            this.btTransmitHalfSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btTransmitHalfSteps.Location = new System.Drawing.Point(135, 123);
            this.btTransmitHalfSteps.Name = "btTransmitHalfSteps";
            this.btTransmitHalfSteps.Size = new System.Drawing.Size(112, 33);
            this.btTransmitHalfSteps.TabIndex = 36;
            this.btTransmitHalfSteps.Text = "Transmit";
            this.btTransmitHalfSteps.UseVisualStyleBackColor = true;
            this.btTransmitHalfSteps.Click += new System.EventHandler(this.btTransmitHalfSteps_Click);
            // 
            // btHalfStepCCW
            // 
            this.btHalfStepCCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btHalfStepCCW.Location = new System.Drawing.Point(22, 75);
            this.btHalfStepCCW.Name = "btHalfStepCCW";
            this.btHalfStepCCW.Size = new System.Drawing.Size(225, 37);
            this.btHalfStepCCW.TabIndex = 35;
            this.btHalfStepCCW.Text = "Half Step CCW";
            this.btHalfStepCCW.UseVisualStyleBackColor = true;
            this.btHalfStepCCW.Click += new System.EventHandler(this.btHalfStepCCW_Click);
            // 
            // btHalfStepCW
            // 
            this.btHalfStepCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btHalfStepCW.Location = new System.Drawing.Point(22, 25);
            this.btHalfStepCW.Name = "btHalfStepCW";
            this.btHalfStepCW.Size = new System.Drawing.Size(225, 37);
            this.btHalfStepCW.TabIndex = 34;
            this.btHalfStepCW.Text = "Half Step CW";
            this.btHalfStepCW.UseVisualStyleBackColor = true;
            this.btHalfStepCW.Click += new System.EventHandler(this.btHalfStepCW_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(21, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Number of 200 half steps";
            // 
            // txtNumHalfSteps
            // 
            this.txtNumHalfSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumHalfSteps.Location = new System.Drawing.Point(25, 201);
            this.txtNumHalfSteps.Name = "txtNumHalfSteps";
            this.txtNumHalfSteps.ReadOnly = true;
            this.txtNumHalfSteps.Size = new System.Drawing.Size(100, 30);
            this.txtNumHalfSteps.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.pbStop);
            this.tabPage1.Controls.Add(this.pbPause);
            this.tabPage1.Controls.Add(this.pbPlay);
            this.tabPage1.Controls.Add(this.btAsharp);
            this.tabPage1.Controls.Add(this.btGsharp);
            this.tabPage1.Controls.Add(this.btFsharp);
            this.tabPage1.Controls.Add(this.btDsharp);
            this.tabPage1.Controls.Add(this.btCsharp);
            this.tabPage1.Controls.Add(this.btC4);
            this.tabPage1.Controls.Add(this.btB3_top);
            this.tabPage1.Controls.Add(this.btB3);
            this.tabPage1.Controls.Add(this.btA3_top);
            this.tabPage1.Controls.Add(this.btA3);
            this.tabPage1.Controls.Add(this.btG3_top);
            this.tabPage1.Controls.Add(this.btG3);
            this.tabPage1.Controls.Add(this.btF3_top);
            this.tabPage1.Controls.Add(this.btF3);
            this.tabPage1.Controls.Add(this.btE3_top);
            this.tabPage1.Controls.Add(this.btE3);
            this.tabPage1.Controls.Add(this.btD3_top);
            this.tabPage1.Controls.Add(this.btD3);
            this.tabPage1.Controls.Add(this.btC3_top);
            this.tabPage1.Controls.Add(this.btC3);
            this.tabPage1.Controls.Add(this.btJingleBells);
            this.tabPage1.Controls.Add(this.pbPiano);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(663, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Play Instrument";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btAsharp
            // 
            this.btAsharp.BackColor = System.Drawing.Color.Black;
            this.btAsharp.FlatAppearance.BorderSize = 0;
            this.btAsharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAsharp.Font = new System.Drawing.Font("Brush Script MT", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAsharp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAsharp.Location = new System.Drawing.Point(548, 3);
            this.btAsharp.Margin = new System.Windows.Forms.Padding(0);
            this.btAsharp.Name = "btAsharp";
            this.btAsharp.Size = new System.Drawing.Size(31, 203);
            this.btAsharp.TabIndex = 55;
            this.btAsharp.Text = "A#";
            this.btAsharp.UseVisualStyleBackColor = false;
            this.btAsharp.Click += new System.EventHandler(this.btAsharp_Click);
            // 
            // btGsharp
            // 
            this.btGsharp.BackColor = System.Drawing.Color.Black;
            this.btGsharp.FlatAppearance.BorderSize = 0;
            this.btGsharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGsharp.Font = new System.Drawing.Font("Brush Script MT", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGsharp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btGsharp.Location = new System.Drawing.Point(443, 4);
            this.btGsharp.Margin = new System.Windows.Forms.Padding(0);
            this.btGsharp.Name = "btGsharp";
            this.btGsharp.Size = new System.Drawing.Size(31, 203);
            this.btGsharp.TabIndex = 54;
            this.btGsharp.Text = "G#";
            this.btGsharp.UseVisualStyleBackColor = false;
            this.btGsharp.Click += new System.EventHandler(this.btGsharp_Click);
            // 
            // btFsharp
            // 
            this.btFsharp.BackColor = System.Drawing.Color.Black;
            this.btFsharp.FlatAppearance.BorderSize = 0;
            this.btFsharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFsharp.Font = new System.Drawing.Font("Brush Script MT", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFsharp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btFsharp.Location = new System.Drawing.Point(336, 3);
            this.btFsharp.Margin = new System.Windows.Forms.Padding(0);
            this.btFsharp.Name = "btFsharp";
            this.btFsharp.Size = new System.Drawing.Size(31, 203);
            this.btFsharp.TabIndex = 53;
            this.btFsharp.Text = "F#";
            this.btFsharp.UseVisualStyleBackColor = false;
            this.btFsharp.Click += new System.EventHandler(this.btFsharp_Click);
            // 
            // btDsharp
            // 
            this.btDsharp.BackColor = System.Drawing.Color.Black;
            this.btDsharp.FlatAppearance.BorderSize = 0;
            this.btDsharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDsharp.Font = new System.Drawing.Font("Brush Script MT", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDsharp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btDsharp.Location = new System.Drawing.Point(174, 3);
            this.btDsharp.Margin = new System.Windows.Forms.Padding(0);
            this.btDsharp.Name = "btDsharp";
            this.btDsharp.Size = new System.Drawing.Size(31, 203);
            this.btDsharp.TabIndex = 52;
            this.btDsharp.Text = "D#";
            this.btDsharp.UseVisualStyleBackColor = false;
            this.btDsharp.Click += new System.EventHandler(this.btDsharp_Click);
            // 
            // btCsharp
            // 
            this.btCsharp.BackColor = System.Drawing.Color.Black;
            this.btCsharp.FlatAppearance.BorderSize = 0;
            this.btCsharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCsharp.Font = new System.Drawing.Font("Brush Script MT", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCsharp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btCsharp.Location = new System.Drawing.Point(60, 3);
            this.btCsharp.Margin = new System.Windows.Forms.Padding(0);
            this.btCsharp.Name = "btCsharp";
            this.btCsharp.Size = new System.Drawing.Size(31, 203);
            this.btCsharp.TabIndex = 51;
            this.btCsharp.Text = "C#";
            this.btCsharp.UseVisualStyleBackColor = false;
            this.btCsharp.Click += new System.EventHandler(this.btCsharp_Click);
            // 
            // btC4
            // 
            this.btC4.Location = new System.Drawing.Point(519, 502);
            this.btC4.Name = "btC4";
            this.btC4.Size = new System.Drawing.Size(120, 48);
            this.btC4.TabIndex = 50;
            this.btC4.Text = "C4";
            this.btC4.UseVisualStyleBackColor = true;
            this.btC4.Visible = false;
            this.btC4.Click += new System.EventHandler(this.btC4_Click);
            // 
            // btB3_top
            // 
            this.btB3_top.BackColor = System.Drawing.Color.White;
            this.btB3_top.FlatAppearance.BorderSize = 0;
            this.btB3_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btB3_top.Location = new System.Drawing.Point(588, 1);
            this.btB3_top.Name = "btB3_top";
            this.btB3_top.Size = new System.Drawing.Size(43, 243);
            this.btB3_top.TabIndex = 49;
            this.btB3_top.UseVisualStyleBackColor = false;
            // 
            // btB3
            // 
            this.btB3.BackColor = System.Drawing.Color.White;
            this.btB3.FlatAppearance.BorderSize = 0;
            this.btB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btB3.Font = new System.Drawing.Font("Brush Script MT", 20F, System.Drawing.FontStyle.Italic);
            this.btB3.Location = new System.Drawing.Point(553, 244);
            this.btB3.Margin = new System.Windows.Forms.Padding(0);
            this.btB3.Name = "btB3";
            this.btB3.Size = new System.Drawing.Size(78, 133);
            this.btB3.TabIndex = 48;
            this.btB3.Text = "B";
            this.btB3.UseVisualStyleBackColor = false;
            this.btB3.Click += new System.EventHandler(this.btB3_Click);
            // 
            // btA3_top
            // 
            this.btA3_top.BackColor = System.Drawing.Color.White;
            this.btA3_top.FlatAppearance.BorderSize = 0;
            this.btA3_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btA3_top.Location = new System.Drawing.Point(487, 1);
            this.btA3_top.Name = "btA3_top";
            this.btA3_top.Size = new System.Drawing.Size(44, 243);
            this.btA3_top.TabIndex = 47;
            this.btA3_top.UseVisualStyleBackColor = false;
            // 
            // btA3
            // 
            this.btA3.BackColor = System.Drawing.Color.White;
            this.btA3.FlatAppearance.BorderSize = 0;
            this.btA3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btA3.Font = new System.Drawing.Font("Brush Script MT", 20F, System.Drawing.FontStyle.Italic);
            this.btA3.Location = new System.Drawing.Point(463, 243);
            this.btA3.Margin = new System.Windows.Forms.Padding(0);
            this.btA3.Name = "btA3";
            this.btA3.Size = new System.Drawing.Size(78, 133);
            this.btA3.TabIndex = 46;
            this.btA3.Text = "A";
            this.btA3.UseVisualStyleBackColor = false;
            this.btA3.Click += new System.EventHandler(this.btA3_Click);
            // 
            // btG3_top
            // 
            this.btG3_top.BackColor = System.Drawing.Color.White;
            this.btG3_top.FlatAppearance.BorderSize = 0;
            this.btG3_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btG3_top.Location = new System.Drawing.Point(381, 1);
            this.btG3_top.Name = "btG3_top";
            this.btG3_top.Size = new System.Drawing.Size(44, 243);
            this.btG3_top.TabIndex = 45;
            this.btG3_top.UseVisualStyleBackColor = false;
            // 
            // btG3
            // 
            this.btG3.BackColor = System.Drawing.Color.White;
            this.btG3.FlatAppearance.BorderSize = 0;
            this.btG3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btG3.Font = new System.Drawing.Font("Brush Script MT", 20F, System.Drawing.FontStyle.Italic);
            this.btG3.Location = new System.Drawing.Point(372, 243);
            this.btG3.Margin = new System.Windows.Forms.Padding(0);
            this.btG3.Name = "btG3";
            this.btG3.Size = new System.Drawing.Size(78, 133);
            this.btG3.TabIndex = 44;
            this.btG3.Text = "G";
            this.btG3.UseVisualStyleBackColor = false;
            this.btG3.Click += new System.EventHandler(this.btG3_Click);
            // 
            // btF3_top
            // 
            this.btF3_top.BackColor = System.Drawing.Color.White;
            this.btF3_top.FlatAppearance.BorderSize = 0;
            this.btF3_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btF3_top.Location = new System.Drawing.Point(280, 2);
            this.btF3_top.Name = "btF3_top";
            this.btF3_top.Size = new System.Drawing.Size(44, 243);
            this.btF3_top.TabIndex = 43;
            this.btF3_top.UseVisualStyleBackColor = false;
            // 
            // btF3
            // 
            this.btF3.BackColor = System.Drawing.Color.White;
            this.btF3.FlatAppearance.BorderSize = 0;
            this.btF3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btF3.Font = new System.Drawing.Font("Brush Script MT", 20F, System.Drawing.FontStyle.Italic);
            this.btF3.Location = new System.Drawing.Point(281, 243);
            this.btF3.Margin = new System.Windows.Forms.Padding(0);
            this.btF3.Name = "btF3";
            this.btF3.Size = new System.Drawing.Size(78, 133);
            this.btF3.TabIndex = 42;
            this.btF3.Text = "F";
            this.btF3.UseVisualStyleBackColor = false;
            this.btF3.Click += new System.EventHandler(this.btF3_Click);
            // 
            // btE3_top
            // 
            this.btE3_top.BackColor = System.Drawing.Color.White;
            this.btE3_top.FlatAppearance.BorderSize = 0;
            this.btE3_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btE3_top.Location = new System.Drawing.Point(224, 2);
            this.btE3_top.Name = "btE3_top";
            this.btE3_top.Size = new System.Drawing.Size(44, 243);
            this.btE3_top.TabIndex = 41;
            this.btE3_top.UseVisualStyleBackColor = false;
            // 
            // btE3
            // 
            this.btE3.BackColor = System.Drawing.Color.White;
            this.btE3.FlatAppearance.BorderSize = 0;
            this.btE3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btE3.Font = new System.Drawing.Font("Brush Script MT", 20F, System.Drawing.FontStyle.Italic);
            this.btE3.Location = new System.Drawing.Point(190, 243);
            this.btE3.Margin = new System.Windows.Forms.Padding(0);
            this.btE3.Name = "btE3";
            this.btE3.Size = new System.Drawing.Size(78, 133);
            this.btE3.TabIndex = 40;
            this.btE3.Text = "E";
            this.btE3.UseVisualStyleBackColor = false;
            this.btE3.Click += new System.EventHandler(this.btE3_Click_1);
            // 
            // btD3_top
            // 
            this.btD3_top.BackColor = System.Drawing.Color.White;
            this.btD3_top.FlatAppearance.BorderSize = 0;
            this.btD3_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btD3_top.Location = new System.Drawing.Point(115, 1);
            this.btD3_top.Name = "btD3_top";
            this.btD3_top.Size = new System.Drawing.Size(44, 243);
            this.btD3_top.TabIndex = 39;
            this.btD3_top.UseVisualStyleBackColor = false;
            // 
            // btD3
            // 
            this.btD3.BackColor = System.Drawing.Color.White;
            this.btD3.FlatAppearance.BorderSize = 0;
            this.btD3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btD3.Font = new System.Drawing.Font("Brush Script MT", 20F, System.Drawing.FontStyle.Italic);
            this.btD3.Location = new System.Drawing.Point(99, 243);
            this.btD3.Margin = new System.Windows.Forms.Padding(0);
            this.btD3.Name = "btD3";
            this.btD3.Size = new System.Drawing.Size(78, 133);
            this.btD3.TabIndex = 38;
            this.btD3.Text = "D";
            this.btD3.UseVisualStyleBackColor = false;
            this.btD3.Click += new System.EventHandler(this.btD3_Click_1);
            // 
            // btC3_top
            // 
            this.btC3_top.BackColor = System.Drawing.Color.White;
            this.btC3_top.FlatAppearance.BorderSize = 0;
            this.btC3_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btC3_top.Location = new System.Drawing.Point(7, 3);
            this.btC3_top.Name = "btC3_top";
            this.btC3_top.Size = new System.Drawing.Size(44, 243);
            this.btC3_top.TabIndex = 37;
            this.btC3_top.UseVisualStyleBackColor = false;
            // 
            // btC3
            // 
            this.btC3.BackColor = System.Drawing.Color.White;
            this.btC3.FlatAppearance.BorderSize = 0;
            this.btC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btC3.Font = new System.Drawing.Font("Brush Script MT", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC3.Location = new System.Drawing.Point(7, 243);
            this.btC3.Margin = new System.Windows.Forms.Padding(0);
            this.btC3.Name = "btC3";
            this.btC3.Size = new System.Drawing.Size(78, 133);
            this.btC3.TabIndex = 34;
            this.btC3.Text = "C";
            this.btC3.UseVisualStyleBackColor = false;
            this.btC3.Click += new System.EventHandler(this.btC3_Click);
            // 
            // pbStop
            // 
            this.pbStop.Image = global::MECH423_Lab2_Exam_Serial_Comm.Properties.Resources.stop_button_v2;
            this.pbStop.Location = new System.Drawing.Point(400, 405);
            this.pbStop.Name = "pbStop";
            this.pbStop.Size = new System.Drawing.Size(85, 85);
            this.pbStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStop.TabIndex = 58;
            this.pbStop.TabStop = false;
            this.pbStop.Click += new System.EventHandler(this.pbStop_Click);
            // 
            // pbPause
            // 
            this.pbPause.Image = global::MECH423_Lab2_Exam_Serial_Comm.Properties.Resources.pause_button_v2;
            this.pbPause.Location = new System.Drawing.Point(157, 405);
            this.pbPause.Name = "pbPause";
            this.pbPause.Size = new System.Drawing.Size(85, 85);
            this.pbPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPause.TabIndex = 57;
            this.pbPause.TabStop = false;
            this.pbPause.Click += new System.EventHandler(this.pbPause_Click);
            // 
            // pbPlay
            // 
            this.pbPlay.Image = global::MECH423_Lab2_Exam_Serial_Comm.Properties.Resources.play_button_v2;
            this.pbPlay.Location = new System.Drawing.Point(278, 405);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(85, 85);
            this.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlay.TabIndex = 56;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.pbPlay_Click);
            // 
            // btJingleBells
            // 
            this.btJingleBells.BackgroundImage = global::MECH423_Lab2_Exam_Serial_Comm.Properties.Resources._2018_12_01_23_12_30_Photos;
            this.btJingleBells.Font = new System.Drawing.Font("Brush Script MT", 18F, System.Drawing.FontStyle.Italic);
            this.btJingleBells.Location = new System.Drawing.Point(214, 502);
            this.btJingleBells.Name = "btJingleBells";
            this.btJingleBells.Size = new System.Drawing.Size(196, 48);
            this.btJingleBells.TabIndex = 33;
            this.btJingleBells.Text = "Jingle Bells";
            this.btJingleBells.UseVisualStyleBackColor = true;
            this.btJingleBells.Click += new System.EventHandler(this.btJingleBells_Click);
            // 
            // pbPiano
            // 
            this.pbPiano.Image = global::MECH423_Lab2_Exam_Serial_Comm.Properties.Resources._6080853_one_octave_on_piano_keyboard;
            this.pbPiano.Location = new System.Drawing.Point(0, 0);
            this.pbPiano.Name = "pbPiano";
            this.pbPiano.Size = new System.Drawing.Size(639, 389);
            this.pbPiano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPiano.TabIndex = 21;
            this.pbPiano.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.BackgroundImage = global::MECH423_Lab2_Exam_Serial_Comm.Properties.Resources.whiteXmasBackground;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 390);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 182);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(86, 25);
            this.btnConnect.Text = "Play Music!";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 638);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(666, 685);
            this.MinimumSize = new System.Drawing.Size(666, 685);
            this.Name = "Form1";
            this.Text = "MECH 423 Single String Musical Instrument";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cmbComPort;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtBaudRate;
        private System.Windows.Forms.ToolStripButton btnConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer changeKeysToDefaultColor;
        private System.Windows.Forms.Timer positionCorrectionTimer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btC3;
        private System.Windows.Forms.Button btJingleBells;
        private System.Windows.Forms.PictureBox pbPiano;
        private System.Windows.Forms.CheckBox chkShowResponse;
        private System.Windows.Forms.Label lblIncomingDataRate;
        private System.Windows.Forms.TextBox txtRawSerial;
        private System.Windows.Forms.TextBox tbHalfSteps;
        private System.Windows.Forms.Button btTransmitHalfSteps;
        private System.Windows.Forms.Button btHalfStepCCW;
        private System.Windows.Forms.Button btHalfStepCW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumHalfSteps;
        private System.Windows.Forms.Button btC3_top;
        private System.Windows.Forms.Button btD3;
        private System.Windows.Forms.Button btD3_top;
        private System.Windows.Forms.Button btE3_top;
        private System.Windows.Forms.Button btE3;
        private System.Windows.Forms.Button btF3;
        private System.Windows.Forms.Button btF3_top;
        private System.Windows.Forms.Button btG3;
        private System.Windows.Forms.Button btG3_top;
        private System.Windows.Forms.Button btA3;
        private System.Windows.Forms.Button btA3_top;
        private System.Windows.Forms.Button btB3;
        private System.Windows.Forms.Button btB3_top;
        private System.Windows.Forms.Button btC4;
        private System.Windows.Forms.Button btDsharp;
        private System.Windows.Forms.Button btCsharp;
        private System.Windows.Forms.Button btFsharp;
        private System.Windows.Forms.Button btGsharp;
        private System.Windows.Forms.Button btAsharp;
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.PictureBox pbPause;
        private System.Windows.Forms.PictureBox pbStop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

