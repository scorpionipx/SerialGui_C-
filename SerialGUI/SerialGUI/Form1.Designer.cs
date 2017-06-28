namespace SerialGUI
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
            this.status_label = new System.Windows.Forms.Label();
            this.dataTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.angle_label = new System.Windows.Forms.Label();
            this.configuration_port_combobox = new System.Windows.Forms.ComboBox();
            this.configuration_panel = new System.Windows.Forms.Panel();
            this.configuration_default_button = new System.Windows.Forms.Button();
            this.configuration_refresh_button = new System.Windows.Forms.Button();
            this.configuration_close_button = new System.Windows.Forms.Button();
            this.configuration_open_button = new System.Windows.Forms.Button();
            this.configuration_stopbits_label = new System.Windows.Forms.Label();
            this.configuration_stopbits_combobox = new System.Windows.Forms.ComboBox();
            this.configuration_parity_label = new System.Windows.Forms.Label();
            this.configuration_parity_combobox = new System.Windows.Forms.ComboBox();
            this.configuration_databits_label = new System.Windows.Forms.Label();
            this.configuration_databits_combobox = new System.Windows.Forms.ComboBox();
            this.configuration_baudrate_label = new System.Windows.Forms.Label();
            this.configuration_baudrate_combobox = new System.Windows.Forms.ComboBox();
            this.configuration_port_label = new System.Windows.Forms.Label();
            this.configuration_title_label = new System.Windows.Forms.Label();
            this.configuration_visibility_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.send_data_check_box = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.configuration_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(9, 404);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(35, 13);
            this.status_label.TabIndex = 0;
            this.status_label.Text = "label1";
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(255, 19);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(584, 279);
            this.dataTextBox.TabIndex = 1;
            this.dataTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(943, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(188, 361);
            this.trackBar1.Maximum = 3600;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeftLayout = true;
            this.trackBar1.Size = new System.Drawing.Size(749, 45);
            this.trackBar1.SmallChange = 18;
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickFrequency = 18;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // angle_label
            // 
            this.angle_label.AutoSize = true;
            this.angle_label.Location = new System.Drawing.Point(943, 361);
            this.angle_label.Name = "angle_label";
            this.angle_label.Size = new System.Drawing.Size(35, 13);
            this.angle_label.TabIndex = 4;
            this.angle_label.Text = "label1";
            // 
            // configuration_port_combobox
            // 
            this.configuration_port_combobox.FormattingEnabled = true;
            this.configuration_port_combobox.Location = new System.Drawing.Point(78, 22);
            this.configuration_port_combobox.Name = "configuration_port_combobox";
            this.configuration_port_combobox.Size = new System.Drawing.Size(132, 21);
            this.configuration_port_combobox.TabIndex = 5;
            // 
            // configuration_panel
            // 
            this.configuration_panel.Controls.Add(this.configuration_default_button);
            this.configuration_panel.Controls.Add(this.configuration_refresh_button);
            this.configuration_panel.Controls.Add(this.configuration_close_button);
            this.configuration_panel.Controls.Add(this.configuration_open_button);
            this.configuration_panel.Controls.Add(this.configuration_stopbits_label);
            this.configuration_panel.Controls.Add(this.configuration_stopbits_combobox);
            this.configuration_panel.Controls.Add(this.configuration_parity_label);
            this.configuration_panel.Controls.Add(this.configuration_parity_combobox);
            this.configuration_panel.Controls.Add(this.configuration_databits_label);
            this.configuration_panel.Controls.Add(this.configuration_databits_combobox);
            this.configuration_panel.Controls.Add(this.configuration_baudrate_label);
            this.configuration_panel.Controls.Add(this.configuration_baudrate_combobox);
            this.configuration_panel.Controls.Add(this.configuration_port_label);
            this.configuration_panel.Controls.Add(this.configuration_title_label);
            this.configuration_panel.Controls.Add(this.configuration_port_combobox);
            this.configuration_panel.Location = new System.Drawing.Point(12, 19);
            this.configuration_panel.Name = "configuration_panel";
            this.configuration_panel.Size = new System.Drawing.Size(213, 212);
            this.configuration_panel.TabIndex = 6;
            // 
            // configuration_default_button
            // 
            this.configuration_default_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.configuration_default_button.Location = new System.Drawing.Point(116, 3);
            this.configuration_default_button.Name = "configuration_default_button";
            this.configuration_default_button.Size = new System.Drawing.Size(94, 17);
            this.configuration_default_button.TabIndex = 19;
            this.configuration_default_button.Text = "restore default";
            this.configuration_default_button.UseVisualStyleBackColor = true;
            this.configuration_default_button.Click += new System.EventHandler(this.configuration_default_button_Click);
            // 
            // configuration_refresh_button
            // 
            this.configuration_refresh_button.Location = new System.Drawing.Point(9, 188);
            this.configuration_refresh_button.Name = "configuration_refresh_button";
            this.configuration_refresh_button.Size = new System.Drawing.Size(193, 23);
            this.configuration_refresh_button.TabIndex = 18;
            this.configuration_refresh_button.Text = "Refresh PORTS";
            this.configuration_refresh_button.UseVisualStyleBackColor = true;
            this.configuration_refresh_button.Click += new System.EventHandler(this.configuration_refresh_button_Click);
            // 
            // configuration_close_button
            // 
            this.configuration_close_button.Location = new System.Drawing.Point(110, 159);
            this.configuration_close_button.Name = "configuration_close_button";
            this.configuration_close_button.Size = new System.Drawing.Size(92, 23);
            this.configuration_close_button.TabIndex = 17;
            this.configuration_close_button.Text = "Close";
            this.configuration_close_button.UseVisualStyleBackColor = true;
            this.configuration_close_button.Click += new System.EventHandler(this.configuration_close_button_Click);
            // 
            // configuration_open_button
            // 
            this.configuration_open_button.Location = new System.Drawing.Point(9, 159);
            this.configuration_open_button.Name = "configuration_open_button";
            this.configuration_open_button.Size = new System.Drawing.Size(92, 23);
            this.configuration_open_button.TabIndex = 16;
            this.configuration_open_button.Text = "Open";
            this.configuration_open_button.UseVisualStyleBackColor = true;
            this.configuration_open_button.Click += new System.EventHandler(this.configuration_open_button_Click);
            // 
            // configuration_stopbits_label
            // 
            this.configuration_stopbits_label.AutoSize = true;
            this.configuration_stopbits_label.Location = new System.Drawing.Point(6, 132);
            this.configuration_stopbits_label.Name = "configuration_stopbits_label";
            this.configuration_stopbits_label.Size = new System.Drawing.Size(63, 13);
            this.configuration_stopbits_label.TabIndex = 15;
            this.configuration_stopbits_label.Text = "STOP BITS";
            // 
            // configuration_stopbits_combobox
            // 
            this.configuration_stopbits_combobox.FormattingEnabled = true;
            this.configuration_stopbits_combobox.Location = new System.Drawing.Point(78, 129);
            this.configuration_stopbits_combobox.Name = "configuration_stopbits_combobox";
            this.configuration_stopbits_combobox.Size = new System.Drawing.Size(132, 21);
            this.configuration_stopbits_combobox.TabIndex = 14;
            // 
            // configuration_parity_label
            // 
            this.configuration_parity_label.AutoSize = true;
            this.configuration_parity_label.Location = new System.Drawing.Point(6, 105);
            this.configuration_parity_label.Name = "configuration_parity_label";
            this.configuration_parity_label.Size = new System.Drawing.Size(46, 13);
            this.configuration_parity_label.TabIndex = 13;
            this.configuration_parity_label.Text = "PARITY";
            // 
            // configuration_parity_combobox
            // 
            this.configuration_parity_combobox.FormattingEnabled = true;
            this.configuration_parity_combobox.Location = new System.Drawing.Point(78, 102);
            this.configuration_parity_combobox.Name = "configuration_parity_combobox";
            this.configuration_parity_combobox.Size = new System.Drawing.Size(132, 21);
            this.configuration_parity_combobox.TabIndex = 12;
            // 
            // configuration_databits_label
            // 
            this.configuration_databits_label.AutoSize = true;
            this.configuration_databits_label.Location = new System.Drawing.Point(6, 78);
            this.configuration_databits_label.Name = "configuration_databits_label";
            this.configuration_databits_label.Size = new System.Drawing.Size(63, 13);
            this.configuration_databits_label.TabIndex = 11;
            this.configuration_databits_label.Text = "DATA BITS";
            this.configuration_databits_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // configuration_databits_combobox
            // 
            this.configuration_databits_combobox.FormattingEnabled = true;
            this.configuration_databits_combobox.Location = new System.Drawing.Point(78, 75);
            this.configuration_databits_combobox.Name = "configuration_databits_combobox";
            this.configuration_databits_combobox.Size = new System.Drawing.Size(132, 21);
            this.configuration_databits_combobox.TabIndex = 10;
            // 
            // configuration_baudrate_label
            // 
            this.configuration_baudrate_label.AutoSize = true;
            this.configuration_baudrate_label.Location = new System.Drawing.Point(6, 51);
            this.configuration_baudrate_label.Name = "configuration_baudrate_label";
            this.configuration_baudrate_label.Size = new System.Drawing.Size(66, 13);
            this.configuration_baudrate_label.TabIndex = 9;
            this.configuration_baudrate_label.Text = "BAUDRATE";
            // 
            // configuration_baudrate_combobox
            // 
            this.configuration_baudrate_combobox.FormattingEnabled = true;
            this.configuration_baudrate_combobox.Location = new System.Drawing.Point(78, 48);
            this.configuration_baudrate_combobox.Name = "configuration_baudrate_combobox";
            this.configuration_baudrate_combobox.Size = new System.Drawing.Size(132, 21);
            this.configuration_baudrate_combobox.TabIndex = 8;
            // 
            // configuration_port_label
            // 
            this.configuration_port_label.AutoSize = true;
            this.configuration_port_label.Location = new System.Drawing.Point(18, 25);
            this.configuration_port_label.Name = "configuration_port_label";
            this.configuration_port_label.Size = new System.Drawing.Size(37, 13);
            this.configuration_port_label.TabIndex = 7;
            this.configuration_port_label.Text = "PORT";
            // 
            // configuration_title_label
            // 
            this.configuration_title_label.AutoSize = true;
            this.configuration_title_label.Location = new System.Drawing.Point(3, 3);
            this.configuration_title_label.Name = "configuration_title_label";
            this.configuration_title_label.Size = new System.Drawing.Size(98, 13);
            this.configuration_title_label.TabIndex = 6;
            this.configuration_title_label.Text = "Configuration panel";
            // 
            // configuration_visibility_button
            // 
            this.configuration_visibility_button.BackColor = System.Drawing.Color.Red;
            this.configuration_visibility_button.Location = new System.Drawing.Point(12, 9);
            this.configuration_visibility_button.Name = "configuration_visibility_button";
            this.configuration_visibility_button.Size = new System.Drawing.Size(52, 10);
            this.configuration_visibility_button.TabIndex = 7;
            this.configuration_visibility_button.UseVisualStyleBackColor = false;
            this.configuration_visibility_button.Click += new System.EventHandler(this.configuration_visibility_button_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // send_data_check_box
            // 
            this.send_data_check_box.AutoSize = true;
            this.send_data_check_box.Location = new System.Drawing.Point(188, 338);
            this.send_data_check_box.Name = "send_data_check_box";
            this.send_data_check_box.Size = new System.Drawing.Size(75, 17);
            this.send_data_check_box.TabIndex = 8;
            this.send_data_check_box.Text = "Send data";
            this.send_data_check_box.UseVisualStyleBackColor = true;
            this.send_data_check_box.CheckedChanged += new System.EventHandler(this.send_data_check_box_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 512);
            this.Controls.Add(this.send_data_check_box);
            this.Controls.Add(this.configuration_visibility_button);
            this.Controls.Add(this.configuration_panel);
            this.Controls.Add(this.angle_label);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.status_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.configuration_panel.ResumeLayout(false);
            this.configuration_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.RichTextBox dataTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label angle_label;
        private System.Windows.Forms.ComboBox configuration_port_combobox;
        private System.Windows.Forms.Panel configuration_panel;
        private System.Windows.Forms.Label configuration_baudrate_label;
        private System.Windows.Forms.ComboBox configuration_baudrate_combobox;
        private System.Windows.Forms.Label configuration_port_label;
        private System.Windows.Forms.Label configuration_title_label;
        private System.Windows.Forms.Label configuration_databits_label;
        private System.Windows.Forms.ComboBox configuration_databits_combobox;
        private System.Windows.Forms.Label configuration_stopbits_label;
        private System.Windows.Forms.ComboBox configuration_stopbits_combobox;
        private System.Windows.Forms.Label configuration_parity_label;
        private System.Windows.Forms.ComboBox configuration_parity_combobox;
        private System.Windows.Forms.Button configuration_close_button;
        private System.Windows.Forms.Button configuration_open_button;
        private System.Windows.Forms.Button configuration_refresh_button;
        private System.Windows.Forms.Button configuration_default_button;
        private System.Windows.Forms.Button configuration_visibility_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox send_data_check_box;
    }
}

