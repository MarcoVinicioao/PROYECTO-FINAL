using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encendiendo_led
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort ArduinoPort;
        public Form1()
        {
            InitializeComponent();
            //  serialPort1.Open();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM5";  //sustituir por vuestro 
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
           // serialPort1.WriteLine("A");
            ArduinoPort.Write("B");
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("A");
         
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
           // {
                //cerrar puerto
                if (ArduinoPort.IsOpen) ArduinoPort.Close();
           // }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Open();
        }
    }
}
