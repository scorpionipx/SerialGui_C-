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
        int[] BAUD_RATES = new int[] {300, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, 115200, 230400 };
        int[] DATA_BITS = new int[] {5, 6, 7, 8 };
        string[] PARITIES = new string[] { "Odd", "Even", "None" };
        int[] STOP_BITS = new int[] {1, 2 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //__openPort__("COM3", 9600);
            angle_label.Text = "Angle: ";
            __update_baud_rates__();
            __update_databits__();
            __update_parity__();
            __update_stop_bits__();
            configuration_panel.Visible = false;
        }

        private void __openPort__(String port, int baudrate)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void configuration_refresh_button_Click(object sender, EventArgs e)
        {
            __update_available_ports_names__();
        }

        private void __update_available_ports_names__()
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                configuration_port_combobox.Items.Add(port);
            }
        }

        private void __update_baud_rates__()
        {
            foreach(int BAUD_RATE in BAUD_RATES)
            {
                configuration_baudrate_combobox.Items.Add(BAUD_RATE);
            }
        }

        private void __update_databits__()
        {
            foreach (int DATA_BIT in DATA_BITS)
            {
                configuration_databits_combobox.Items.Add(DATA_BIT);
            }
        }

        private void __update_parity__()
        {
            foreach (string PARITY in PARITIES)
            {
                configuration_parity_combobox.Items.Add(PARITY);
            }
        }

        private void __update_stop_bits__()
        {
            foreach (int STOP_BIT in STOP_BITS)
            {
                configuration_stopbits_combobox.Items.Add(STOP_BIT);
            }
        }
    }
}
