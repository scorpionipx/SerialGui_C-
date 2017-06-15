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

namespace SerialGUI
{
    public partial class Form1 : Form
    {
        SerialPort evb_5 = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            __openPort__("COM4");
            angle_label.Text = "Angle: ";
        }

        private void __openPort__(String port)
        {
            evb_5.PortName = port;
            evb_5.BaudRate = 9600;
            evb_5.Parity = Parity.None;
            evb_5.DataBits = 8;
            evb_5.StopBits = StopBits.One;
            evb_5.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            evb_5.Open();
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.dataTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.dataTextBox.Text += text;
            }
        }

        private void __updateDataTextBox__(String data)
        {
            dataTextBox.Text += data;
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            // Console.WriteLine(evb_5.ReadExisting());

            String txt = evb_5.ReadExisting().ToString();
            SetText(txt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int angle = trackBar1.Value;
            int command_id = 1;
            int data_byte_1;
            int data_byte_2;

            byte[] command_id_as_byte = BitConverter.GetBytes(command_id);

            data_byte_1 = angle >> 8;
            data_byte_2 = angle & 0xFF;

            byte[] data_byte_1_as_byte = BitConverter.GetBytes(data_byte_1);
            byte[] data_byte_2_as_byte = BitConverter.GetBytes(data_byte_2);

            evb_5.Write(command_id_as_byte, 0, 1);
            evb_5.Write(data_byte_1_as_byte, 0, 1);
            evb_5.Write(data_byte_2_as_byte, 0, 1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int angle = trackBar1.Value;

            angle_label.Text = "Angle: " + (angle/10).ToString() + "." + (angle%10).ToString() + "°";

            int command_id = 1;
            int data_byte_1;
            int data_byte_2;

            byte[] command_id_as_byte = BitConverter.GetBytes(command_id);

            data_byte_1 = angle >> 8;
            data_byte_2 = angle & 0xFF;

            byte[] data_byte_1_as_byte = BitConverter.GetBytes(data_byte_1);
            byte[] data_byte_2_as_byte = BitConverter.GetBytes(data_byte_2);

            evb_5.Write(command_id_as_byte, 0, 1);
            evb_5.Write(data_byte_1_as_byte, 0, 1);
            evb_5.Write(data_byte_2_as_byte, 0, 1);
        }
    }
}
