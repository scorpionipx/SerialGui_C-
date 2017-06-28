using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialGUI
{
    public partial class Form1 : Form
    {
        SerialPort serial_port = new SerialPort();
        int[] BAUD_RATES = new int[] {300, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, 115200, 230400 };
        int[] DATA_BITS = new int[] {5, 6, 7, 8 };
        string[] PARITIES = new string[] { "Odd", "Even", "None" };
        int[] STOP_BITS = new int[] {1, 2 };

        int angle = 0;
        int command_id = 1;
        int data_byte_1;
        int data_byte_2;
        byte[] command_id_as_byte;
        byte[] data_byte_1_as_byte;
        byte[] data_byte_2_as_byte;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //__openPort__("COM3", 9600);
            angle_label.Text = "Angle: ";
            __set_configuraion_default_values__();
        }

        private void __openPort__(String port, int baudrate, string parity, int databits, int stopbits)
        {
            serial_port.PortName = port;
            serial_port.BaudRate = baudrate;
            switch(parity)
            {
                case "Odd":
                    {
                        serial_port.Parity = Parity.Odd;
                        break;
                    }
                case "Even":
                    {
                        serial_port.Parity = Parity.Even;
                        break;
                    }
                case "None":
                    {
                        serial_port.Parity = Parity.None;
                        break;
                    }
                default:
                    {
                        serial_port.Parity = Parity.None;
                        break;
                    }
            }

            serial_port.DataBits = databits;

            switch(stopbits)
            {
                case 1:
                    {
                        serial_port.StopBits = StopBits.One;
                        break;
                    }
                case 2:
                    {
                        serial_port.StopBits = StopBits.Two;
                        break;
                    }
                default:
                    {
                        serial_port.StopBits = StopBits.One;
                        break;
                    }
            }
            
            serial_port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            try
            {
                serial_port.Open();
                configuration_open_button.Enabled = false;
                configuration_close_button.Enabled = true;

                status_label.Text = "Port opened!";
            }
            catch(Exception e)
            {
                status_label.Text = e.ToString();
            }
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

            String txt = serial_port.ReadExisting().ToString();
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

            serial_port.Write(command_id_as_byte, 0, 1);
            serial_port.Write(data_byte_1_as_byte, 0, 1);
            serial_port.Write(data_byte_2_as_byte, 0, 1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            angle = trackBar1.Value;

            angle_label.Text = "Angle: " + (angle/10).ToString() + "." + (angle%10).ToString() + "°";


            command_id_as_byte = BitConverter.GetBytes(command_id);

            data_byte_1 = angle >> 8;
            data_byte_2 = angle & 0xFF;

            data_byte_1_as_byte = BitConverter.GetBytes(data_byte_1);
            data_byte_2_as_byte = BitConverter.GetBytes(data_byte_2);

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
            configuration_port_combobox.Items.Clear();

            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            configuration_port_combobox.Items.Add("None");
            
            foreach (string port in ports)
            {
                configuration_port_combobox.Items.Add(port);
                configuration_port_combobox.SelectedIndex = configuration_port_combobox.FindString("None");
            }
        }

        private void __update_baud_rates__()
        {
            configuration_baudrate_combobox.Items.Clear();

            foreach (int BAUD_RATE in BAUD_RATES)
            {
                configuration_baudrate_combobox.Items.Add(BAUD_RATE);
                configuration_baudrate_combobox.SelectedIndex = configuration_baudrate_combobox.FindString("9600");
            }
        }

        private void __update_databits__()
        {
            configuration_databits_combobox.Items.Clear();

            foreach (int DATA_BIT in DATA_BITS)
            {
                configuration_databits_combobox.Items.Add(DATA_BIT);
                configuration_databits_combobox.SelectedIndex = configuration_databits_combobox.FindString("8");
            }
        }

        private void __update_parity__()
        {
            configuration_parity_combobox.Items.Clear();

            foreach (string PARITY in PARITIES)
            {
                configuration_parity_combobox.Items.Add(PARITY);
                configuration_parity_combobox.SelectedIndex = configuration_parity_combobox.FindString("None");
            }
        }

        private void __update_stop_bits__()
        {
            configuration_stopbits_combobox.Items.Clear();

            foreach (int STOP_BIT in STOP_BITS)
            {
                configuration_stopbits_combobox.Items.Add(STOP_BIT);
                configuration_stopbits_combobox.SelectedIndex = configuration_stopbits_combobox.FindString("1");
            }
        }

        private void __set_configuraion_default_values__()
        {
            __update_available_ports_names__();
            __update_baud_rates__();
            __update_databits__();
            __update_parity__();
            __update_stop_bits__();

            configuration_close_button.Enabled = false;
        }

        private void configuration_default_button_Click(object sender, EventArgs e)
        {
            __set_configuraion_default_values__();
        }

        private void configuration_visibility_button_Click(object sender, EventArgs e)
        {
            if(configuration_panel.Visible == false)
            {
                __show_configuration_panel__();
            }
            else
            {
                __hide_configuration_panel__();
            }
        }

        private void __hide_configuration_panel__()
        {
            configuration_panel.Visible = false;
            configuration_visibility_button.BackColor = System.Drawing.Color.Lime;
        }

        private void __show_configuration_panel__()
        {
            configuration_panel.Visible = true;
            configuration_visibility_button.BackColor = System.Drawing.Color.Red;
        }

        private void configuration_open_button_Click(object sender, EventArgs e)
        {
            string port = configuration_port_combobox.Text;
            int baudrate = (int)configuration_baudrate_combobox.SelectedItem;
            string parity = configuration_parity_combobox.Text;
            int databits = (int)configuration_databits_combobox.SelectedItem;
            int stopbits = (int)configuration_stopbits_combobox.SelectedItem;

            __openPort__(port, baudrate, parity, databits, stopbits);
        }

        private void configuration_close_button_Click(object sender, EventArgs e)
        {
            try
            {
                serial_port.Close();

                configuration_open_button.Enabled = true;
                configuration_close_button.Enabled = false;

                status_label.Text = "Port closed!";
            }
            catch(Exception err)
            {
                status_label.Text = err.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(serial_port.IsOpen)
            {
                serial_port.Write(command_id_as_byte, 0, 1);
                serial_port.Write(data_byte_1_as_byte, 0, 1);
                serial_port.Write(data_byte_2_as_byte, 0, 1);
            }
        }

        private void send_data_check_box_CheckedChanged(object sender, EventArgs e)
        {
            if(send_data_check_box.Checked)
            {
                if(timer1.Enabled == false)
                {
                    timer1.Start();
                }
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
