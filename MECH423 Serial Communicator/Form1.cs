using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Collections.Concurrent;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

namespace MECH423_Lab2_Exam_Serial_Comm
{

    
    public partial class Form1 : Form
    {
        int currentStep = 0;
        int NUM_STEPS_PER_COMMAND = 1;
        int numFullStepsPerHalfStepComand = 200;
        int NUM_STEPS_PER_REV = 1600;
        int MAX_REVS = 12;

        int maxNumCommands;
        
        string C3 = "48";
        string C3sharp = "50";
        string D3 = "52";
        string D3sharp = "54";
        string E3 = "56";
        string F3 = "60";
        string F3sharp = "62";
        string G3 = "64";
        string G3sharp = "66";
        string A3 = "68";
        string A3sharp = "72";
        string B3 = "76";
        string C4 = "80";

        int veryShortInterval = 750;
        int shortInterval = 1500;
        int mediumInterval = 3000;
        int longInterval = 6000;

        int traverseTime4Steps = 625;

        bool pauseFlag = false;
        bool playFlag = true;
        bool stopFlag = false;

        private object syncObj = new object();

		
		Task<int> task = new Task<int>(playJingleBells);
        //Bitmap bmp, bmpPiano;
        //Graphics g, gAlarm;

        List<double> velocityList = new List<double>();
        byte[] TxBytes = new Byte[3];        

        public Form1()
        {
            maxNumCommands = NUM_STEPS_PER_REV * MAX_REVS / numFullStepsPerHalfStepComand;
            InitializeComponent();
        }

        private void ComPortUpdate()
        {
            cmbComPort.Items.Clear();
            string[] comPortArray = System.IO.Ports.SerialPort.GetPortNames().ToArray();
            Array.Reverse(comPortArray);
            cmbComPort.Items.AddRange(comPortArray);
            if (cmbComPort.Items.Count != 0)
                cmbComPort.SelectedIndex = 0;
            else
                cmbComPort.Text = "No Ports Found!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             /*        

            bmpPiano = new Bitmap(947, 310);
            //pbPiano.Controls.Add(pbAlarmHands);
            pbPiano.Location = new Point(0, 0);
            pbPiano.BackColor = Color.Transparent;
            gAlarm = Graphics.FromImage(bmpPiano);
            */
            lblIncomingDataRate.Visible = false;
            chkShowResponse.Checked = true;
            ComPortUpdate();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Play Music!")
            {
                if (cmbComPort.Items.Count > 0)
                {
                    try
                    {
                        serialPort1.BaudRate = Convert.ToInt16(txtBaudRate.Text);
                        serialPort1.PortName = cmbComPort.SelectedItem.ToString();
                        serialPort1.Open();
                        btnConnect.Text = "Disconnect";
                        timer1.Enabled = true;
                        changeKeysToDefaultColor.Enabled = true;
                        lblIncomingDataRate.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    btnConnect.Text = "Play Music!";
                    timer1.Enabled = false;
                    changeKeysToDefaultColor.Enabled = false;
                    lblIncomingDataRate.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void genericTextBoxEventHandler(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;
            short parseResult;
            if (Int16.TryParse((currentTextBox.Text), out parseResult))
            {
                if (parseResult > maxNumCommands)
                    parseResult = (short)maxNumCommands;
                if (parseResult <= 0)
                    parseResult = 0;
                currentTextBox.Text = parseResult.ToString();
            }
            else
                currentTextBox.Text = "";
        }

        void moveStepperMotor(string numHalfSteps)
        {
            currentStep = Convert.ToInt32(numHalfSteps);
            TxBytes[0] = Convert.ToByte(numHalfSteps);            
            
            if(currentStep <= maxNumCommands)
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Write(TxBytes, 0, NUM_STEPS_PER_COMMAND);
                        txtNumHalfSteps.Text = numHalfSteps;
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
                
        }

        /// <summary>
        /// Creates a plot of the accelerometer data
        /// </summary>
        /// <param name="position"></param>
        /// <param name="velocity"></param>
        private void updatePlot(double positionChart, double velocityChart)
        {
            
        }


        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serialPort1.IsOpen && serialPort1.BytesToRead != 0)
            {
                
                int currentByte = serialPort1.ReadByte();

                if (chkShowResponse.Checked)
                    this.BeginInvoke(new EventHandler(delegate
                    {
                        txtRawSerial.AppendText(currentByte.ToString() + ", ");
                    }));
            }
        }
   
       

        private void btD3_Click(object sender, EventArgs e)
        {
            moveStepperMotor("22");
        }

        private void btE3_Click(object sender, EventArgs e)
        {
            moveStepperMotor("33");            
        }

        private void btHalfStepCW_Click(object sender, EventArgs e)
        {
            currentStep += NUM_STEPS_PER_COMMAND;
            moveStepperMotor(Convert.ToString(currentStep));            
        }        

        private void btHalfStepCCW_Click(object sender, EventArgs e)
        {
            if (currentStep > 0)
                currentStep  -= NUM_STEPS_PER_COMMAND;
          
            moveStepperMotor(Convert.ToString(currentStep));            
        }

        private void btTransmitHalfSteps_Click(object sender, EventArgs e)
        {
            moveStepperMotor(Convert.ToString(tbHalfSteps.Text));
        }

        private int playJingleBells()
        {
            //while(processing)
            //Song Start


            moveStepperMotor(E3);
            Thread.Sleep(10000);
            lock(syncObj) { }

            moveStepperMotor(E3);
            Thread.Sleep(750);
            lock (syncObj) { }

            moveStepperMotor(E3);
            Thread.Sleep(830);
            lock (syncObj) { }

            moveStepperMotor(E3);
            Thread.Sleep(1760);
            lock (syncObj) { }

            moveStepperMotor(E3);
            Thread.Sleep(830);
            lock (syncObj) { }

            moveStepperMotor(E3);
            Thread.Sleep(830);
            lock (syncObj) { }

            moveStepperMotor(E3);
            Thread.Sleep(1760);
            lock (syncObj) { }

            moveStepperMotor(E3);
            Thread.Sleep(550);
            lock (syncObj) { }

            moveStepperMotor(G3);
            Thread.Sleep(1750);
            lock (syncObj) { }

            moveStepperMotor(C3);
            Thread.Sleep(3250);
            lock (syncObj) { }

            moveStepperMotor(D3);
            Thread.Sleep(1500);
            lock (syncObj) { }

            moveStepperMotor(E3);
            Thread.Sleep(2550);
            lock (syncObj) { }

            moveStepperMotor(F3);
            Thread.Sleep(1650);
            lock (syncObj) { }

            moveStepperMotor(F3);
            Thread.Sleep(910);
            lock (syncObj) { }

            moveStepperMotor(F3);
            Thread.Sleep(940);
            lock (syncObj) { }

            moveStepperMotor(F3);
            Thread.Sleep(940);
            lock (syncObj) { }

            moveStepperMotor(F3);
            Thread.Sleep(540);
            lock (syncObj) { }

            moveStepperMotor(E3);
            Thread.Sleep(1650);
            lock (syncObj) { }

            moveStepperMotor(E3);
            Thread.Sleep(760);
            lock (syncObj) { }

            moveStepperMotor(E3);
            Thread.Sleep(510);
            lock (syncObj) { }

            moveStepperMotor(E3);
            Thread.Sleep(510);
            lock (syncObj) { }

            moveStepperMotor(E3);
            Thread.Sleep(550);
            lock (syncObj) { }

            moveStepperMotor(D3);
            Thread.Sleep(1500);
            lock (syncObj) { }

            moveStepperMotor(D3);
            Thread.Sleep(570);
            lock (syncObj) { }

            moveStepperMotor(E3);
            Thread.Sleep(1000);
            lock (syncObj) { }

            moveStepperMotor(D3);
            Thread.Sleep(1500);
            lock (syncObj) { }

            moveStepperMotor(G3);
            Thread.Sleep(10000);
            lock (syncObj) { }

            moveStepperMotor("0");
                
            return 0;
        }

        private void btJingleBells_Click(object sender, EventArgs e)
        {
            
            task.Start();     
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }      

        private void changeKeysToDefaultColor_Tick(object sender, EventArgs e)
        {
            btC3.BackColor = Color.White;
            btC3_top.BackColor = Color.White;            
            btD3.BackColor = Color.White;
            btD3_top.BackColor = Color.White;            
            btE3.BackColor = Color.White;
            btE3_top.BackColor = Color.White;
            btF3.BackColor = Color.White;
            btF3_top.BackColor = Color.White;
            btG3.BackColor = Color.White;
            btG3_top.BackColor = Color.White;
            btA3.BackColor = Color.White;
            btA3_top.BackColor = Color.White;
            btB3.BackColor = Color.White;
            btB3_top.BackColor = Color.White;

            btCsharp.BackColor = Color.Black;
            btDsharp.BackColor = Color.Black;
            btFsharp.BackColor = Color.Black;
            btGsharp.BackColor = Color.Black;
            btAsharp.BackColor = Color.Black;
            changeKeysToDefaultColor.Enabled = false;
        }

        private void btC3_Click(object sender, EventArgs e)
        {
            changeKeysToDefaultColor.Enabled = true;
            btC3.BackColor = Color.LightBlue;
            btC3_top.BackColor = Color.LightBlue;
            moveStepperMotor(C3);
        }
        private void btD3_Click_1(object sender, EventArgs e)
        {
            changeKeysToDefaultColor.Enabled = true;
            btD3.BackColor = Color.LightBlue;
            btD3_top.BackColor = Color.LightBlue;
            moveStepperMotor(D3);
        }

        private void btE3_Click_1(object sender, EventArgs e)
        {
            changeKeysToDefaultColor.Enabled = true;
            btE3.BackColor = Color.LightBlue;
            btE3_top.BackColor = Color.LightBlue;
            moveStepperMotor(E3);
        }

        private void btF3_Click(object sender, EventArgs e)
        {
            changeKeysToDefaultColor.Enabled = true;
            btF3.BackColor = Color.LightBlue;
            btF3_top.BackColor = Color.LightBlue;
            moveStepperMotor(F3);
        }

        private void btG3_Click(object sender, EventArgs e)
        {
            changeKeysToDefaultColor.Enabled = true;
            btG3.BackColor = Color.LightBlue;
            btG3_top.BackColor = Color.LightBlue;
            moveStepperMotor(G3);
        }

        private void btA3_Click(object sender, EventArgs e)
        {
            changeKeysToDefaultColor.Enabled = true;
            btA3.BackColor = Color.LightBlue;
            btA3_top.BackColor = Color.LightBlue;
            moveStepperMotor(A3);
        }

        private void btB3_Click(object sender, EventArgs e)
        {
            changeKeysToDefaultColor.Enabled = true;
            btB3.BackColor = Color.LightBlue;
            btB3_top.BackColor = Color.LightBlue;
            moveStepperMotor(B3);
        }

        private void btC4_Click(object sender, EventArgs e)
        {
            moveStepperMotor(C4);
        }

        private void btCsharp_Click(object sender, EventArgs e)
        {
            changeKeysToDefaultColor.Enabled = true;
            btCsharp.BackColor = Color.LightBlue;
            moveStepperMotor(C3sharp);
        }

        private void btDsharp_Click(object sender, EventArgs e)
        {
            changeKeysToDefaultColor.Enabled = true;
            btDsharp.BackColor = Color.LightBlue;
            moveStepperMotor(D3sharp);
        }

        private void btFsharp_Click(object sender, EventArgs e)
        {
            changeKeysToDefaultColor.Enabled = true;
            btFsharp.BackColor = Color.LightBlue;
            moveStepperMotor(F3sharp);
        }

        private void btGsharp_Click(object sender, EventArgs e)
        {
            changeKeysToDefaultColor.Enabled = true;
            btGsharp.BackColor = Color.LightBlue;
            moveStepperMotor(G3sharp);
        }

        private void btAsharp_Click(object sender, EventArgs e)
        {
            changeKeysToDefaultColor.Enabled = true;
            btAsharp.BackColor = Color.LightBlue;
            moveStepperMotor(A3sharp);
        }

        private void pbPause_Click(object sender, EventArgs e)
        {
            if (pauseFlag == false)
            {
                // This will acquire the lock on the syncObj,
                // which, in turn will "freeze" the loop
                // as soon as you hit a lock(syncObj) statement
                Monitor.Enter(syncObj);
                pauseFlag = true;
            }
        }        

        private void pbPlay_Click(object sender, EventArgs e)
        {
            if (pauseFlag)
            {
                pauseFlag = false;
                // This will allow the lock to be taken, which will let the loop continue
                Monitor.Exit(syncObj);
                playFlag = true;
            }            
        }

        private void pbStop_Click(object sender, EventArgs e)
        {
            stopFlag = true;
			task.Suspend();
        }
    }
}

