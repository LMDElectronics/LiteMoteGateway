namespace WindowsFormsApp1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox_Build_Serial_Frame = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_Frame_Payload = new System.Windows.Forms.TextBox();
            this.groupBox_Frame_Header = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Msg_Type = new System.Windows.Forms.TextBox();
            this.textBox_Send_Time = new System.Windows.Forms.TextBox();
            this.textBox_Destination_Node = new System.Windows.Forms.TextBox();
            this.textBox_Origin_Node = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton_raw_encoding = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Stop_Frame_Char = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Start_Frame_Char = new System.Windows.Forms.TextBox();
            this.radioButton_base64_encoding = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_Data_Received = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_Data_To_Send = new System.Windows.Forms.TextBox();
            this.button_Send_Data = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_Open_Port = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Combo_Parity_Bits = new System.Windows.Forms.ComboBox();
            this.Combo_Baud_Rate = new System.Windows.Forms.ComboBox();
            this.Combo_Data_Bits = new System.Windows.Forms.ComboBox();
            this.Combo_Stop_Bits = new System.Windows.Forms.ComboBox();
            this.Combo_Port_Number = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.comboBox_TxPower = new System.Windows.Forms.ComboBox();
            this.comboBox_Radio_Channel = new System.Windows.Forms.ComboBox();
            this.textBox_ACK_Received_Radio = new System.Windows.Forms.TextBox();
            this.button_Read_Radio_Data = new System.Windows.Forms.Button();
            this.button_Save_Radio_Data = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBox_DataRate = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBox_Modulation = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox_Freq_Select = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox_ACK_Received_ADC = new System.Windows.Forms.TextBox();
            this.button_ADC_Read_Data = new System.Windows.Forms.Button();
            this.button_Save_ADC_Data = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_ADC_M_GAIN = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_ADC_P_GAIN = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_ADC_Offset = new System.Windows.Forms.TextBox();
            this.groupBox_Health_Parameters = new System.Windows.Forms.GroupBox();
            this.textBox_ACK_Received_Health = new System.Windows.Forms.TextBox();
            this.button_Read_Data_Health = new System.Windows.Forms.Button();
            this.button_Save_Data_Health = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_Tx_period = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_Temperature = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_CPU_Voltage = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_Battery_Voltage = new System.Windows.Forms.TextBox();
            this.groupBox_Identity_Params = new System.Windows.Forms.GroupBox();
            this.textBox_ACK_Received_Identity = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_Identity_Hw_Case = new System.Windows.Forms.TextBox();
            this.button_Identity_ReadData = new System.Windows.Forms.Button();
            this.button_Identity_SaveData = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_Identity_HW_Version = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_Identity_FW_CRC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_Identity_FW_Ver = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Identity_Node_Type = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Identity_NodeID = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_Build_Serial_Frame.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox_Frame_Header.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox_Health_Parameters.SuspendLayout();
            this.groupBox_Identity_Params.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 541);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox_Build_Serial_Frame);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.button_Send_Data);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial Port";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox_Build_Serial_Frame
            // 
            this.groupBox_Build_Serial_Frame.Controls.Add(this.groupBox6);
            this.groupBox_Build_Serial_Frame.Controls.Add(this.groupBox_Frame_Header);
            this.groupBox_Build_Serial_Frame.Controls.Add(this.groupBox5);
            this.groupBox_Build_Serial_Frame.Location = new System.Drawing.Point(235, 6);
            this.groupBox_Build_Serial_Frame.Name = "groupBox_Build_Serial_Frame";
            this.groupBox_Build_Serial_Frame.Size = new System.Drawing.Size(518, 161);
            this.groupBox_Build_Serial_Frame.TabIndex = 7;
            this.groupBox_Build_Serial_Frame.TabStop = false;
            this.groupBox_Build_Serial_Frame.Text = "Build Serial Frame To Send";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox_Frame_Payload);
            this.groupBox6.Location = new System.Drawing.Point(184, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(174, 136);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Frame Payload (Hexa Values)";
            // 
            // textBox_Frame_Payload
            // 
            this.textBox_Frame_Payload.Location = new System.Drawing.Point(6, 26);
            this.textBox_Frame_Payload.MaxLength = 256;
            this.textBox_Frame_Payload.Multiline = true;
            this.textBox_Frame_Payload.Name = "textBox_Frame_Payload";
            this.textBox_Frame_Payload.Size = new System.Drawing.Size(162, 98);
            this.textBox_Frame_Payload.TabIndex = 6;
            this.textBox_Frame_Payload.Text = "aaaa";
            this.textBox_Frame_Payload.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Frame_Payload_KeyPress);
            // 
            // groupBox_Frame_Header
            // 
            this.groupBox_Frame_Header.Controls.Add(this.label11);
            this.groupBox_Frame_Header.Controls.Add(this.label10);
            this.groupBox_Frame_Header.Controls.Add(this.label9);
            this.groupBox_Frame_Header.Controls.Add(this.label8);
            this.groupBox_Frame_Header.Controls.Add(this.textBox_Msg_Type);
            this.groupBox_Frame_Header.Controls.Add(this.textBox_Send_Time);
            this.groupBox_Frame_Header.Controls.Add(this.textBox_Destination_Node);
            this.groupBox_Frame_Header.Controls.Add(this.textBox_Origin_Node);
            this.groupBox_Frame_Header.Location = new System.Drawing.Point(6, 19);
            this.groupBox_Frame_Header.Name = "groupBox_Frame_Header";
            this.groupBox_Frame_Header.Size = new System.Drawing.Size(172, 136);
            this.groupBox_Frame_Header.TabIndex = 11;
            this.groupBox_Frame_Header.TabStop = false;
            this.groupBox_Frame_Header.Text = "Frame Header (Decimal Values)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Msg Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Send Time ( ms )";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Destination Node";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Origin Node";
            // 
            // textBox_Msg_Type
            // 
            this.textBox_Msg_Type.Location = new System.Drawing.Point(6, 106);
            this.textBox_Msg_Type.MaxLength = 5;
            this.textBox_Msg_Type.Name = "textBox_Msg_Type";
            this.textBox_Msg_Type.Size = new System.Drawing.Size(39, 20);
            this.textBox_Msg_Type.TabIndex = 5;
            this.textBox_Msg_Type.Text = "1";
            this.textBox_Msg_Type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Msg_Type_KeyPress);
            // 
            // textBox_Send_Time
            // 
            this.textBox_Send_Time.Location = new System.Drawing.Point(6, 80);
            this.textBox_Send_Time.MaxLength = 5;
            this.textBox_Send_Time.Name = "textBox_Send_Time";
            this.textBox_Send_Time.Size = new System.Drawing.Size(39, 20);
            this.textBox_Send_Time.TabIndex = 4;
            this.textBox_Send_Time.Text = "1050";
            this.textBox_Send_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Send_Time_KeyPress);
            // 
            // textBox_Destination_Node
            // 
            this.textBox_Destination_Node.Location = new System.Drawing.Point(6, 54);
            this.textBox_Destination_Node.MaxLength = 3;
            this.textBox_Destination_Node.Name = "textBox_Destination_Node";
            this.textBox_Destination_Node.Size = new System.Drawing.Size(39, 20);
            this.textBox_Destination_Node.TabIndex = 3;
            this.textBox_Destination_Node.Text = "1";
            this.textBox_Destination_Node.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Destination_Node_KeyPress);
            // 
            // textBox_Origin_Node
            // 
            this.textBox_Origin_Node.Location = new System.Drawing.Point(6, 28);
            this.textBox_Origin_Node.MaxLength = 5;
            this.textBox_Origin_Node.Name = "textBox_Origin_Node";
            this.textBox_Origin_Node.Size = new System.Drawing.Size(39, 20);
            this.textBox_Origin_Node.TabIndex = 2;
            this.textBox_Origin_Node.Text = "0";
            this.textBox_Origin_Node.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Origin_Node_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton_raw_encoding);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox_Stop_Frame_Char);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.textBox_Start_Frame_Char);
            this.groupBox5.Controls.Add(this.radioButton_base64_encoding);
            this.groupBox5.Location = new System.Drawing.Point(364, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(148, 136);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Frame Encoding";
            // 
            // radioButton_raw_encoding
            // 
            this.radioButton_raw_encoding.AutoSize = true;
            this.radioButton_raw_encoding.Location = new System.Drawing.Point(6, 114);
            this.radioButton_raw_encoding.Name = "radioButton_raw_encoding";
            this.radioButton_raw_encoding.Size = new System.Drawing.Size(142, 17);
            this.radioButton_raw_encoding.TabIndex = 10;
            this.radioButton_raw_encoding.TabStop = true;
            this.radioButton_raw_encoding.Text = "Binary raw (no encoding)";
            this.radioButton_raw_encoding.UseVisualStyleBackColor = true;
            this.radioButton_raw_encoding.CheckedChanged += new System.EventHandler(this.radioButton_raw_encoding_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Stop Char";
            // 
            // textBox_Stop_Frame_Char
            // 
            this.textBox_Stop_Frame_Char.Enabled = false;
            this.textBox_Stop_Frame_Char.Location = new System.Drawing.Point(28, 69);
            this.textBox_Stop_Frame_Char.Name = "textBox_Stop_Frame_Char";
            this.textBox_Stop_Frame_Char.Size = new System.Drawing.Size(22, 20);
            this.textBox_Stop_Frame_Char.TabIndex = 8;
            this.textBox_Stop_Frame_Char.Text = ">";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Start Char";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_Start_Frame_Char
            // 
            this.textBox_Start_Frame_Char.Enabled = false;
            this.textBox_Start_Frame_Char.Location = new System.Drawing.Point(28, 43);
            this.textBox_Start_Frame_Char.MaxLength = 1;
            this.textBox_Start_Frame_Char.Name = "textBox_Start_Frame_Char";
            this.textBox_Start_Frame_Char.Size = new System.Drawing.Size(22, 20);
            this.textBox_Start_Frame_Char.TabIndex = 1;
            this.textBox_Start_Frame_Char.Text = "<";
            // 
            // radioButton_base64_encoding
            // 
            this.radioButton_base64_encoding.AutoSize = true;
            this.radioButton_base64_encoding.Location = new System.Drawing.Point(7, 20);
            this.radioButton_base64_encoding.Name = "radioButton_base64_encoding";
            this.radioButton_base64_encoding.Size = new System.Drawing.Size(64, 17);
            this.radioButton_base64_encoding.TabIndex = 0;
            this.radioButton_base64_encoding.TabStop = true;
            this.radioButton_base64_encoding.Text = "Base64 ";
            this.radioButton_base64_encoding.UseVisualStyleBackColor = true;
            this.radioButton_base64_encoding.CheckedChanged += new System.EventHandler(this.radioButton_base64_encoding_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_Data_Received);
            this.groupBox4.Location = new System.Drawing.Point(6, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(747, 254);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Received";
            // 
            // textBox_Data_Received
            // 
            this.textBox_Data_Received.Location = new System.Drawing.Point(6, 19);
            this.textBox_Data_Received.Multiline = true;
            this.textBox_Data_Received.Name = "textBox_Data_Received";
            this.textBox_Data_Received.ReadOnly = true;
            this.textBox_Data_Received.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Data_Received.Size = new System.Drawing.Size(735, 229);
            this.textBox_Data_Received.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_Data_To_Send);
            this.groupBox3.Location = new System.Drawing.Point(235, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 80);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Sent";
            // 
            // textBox_Data_To_Send
            // 
            this.textBox_Data_To_Send.Location = new System.Drawing.Point(6, 17);
            this.textBox_Data_To_Send.Multiline = true;
            this.textBox_Data_To_Send.Name = "textBox_Data_To_Send";
            this.textBox_Data_To_Send.ReadOnly = true;
            this.textBox_Data_To_Send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Data_To_Send.Size = new System.Drawing.Size(506, 57);
            this.textBox_Data_To_Send.TabIndex = 6;
            // 
            // button_Send_Data
            // 
            this.button_Send_Data.Location = new System.Drawing.Point(128, 173);
            this.button_Send_Data.Name = "button_Send_Data";
            this.button_Send_Data.Size = new System.Drawing.Size(101, 76);
            this.button_Send_Data.TabIndex = 3;
            this.button_Send_Data.Text = "SEND FRAME";
            this.button_Send_Data.UseVisualStyleBackColor = true;
            this.button_Send_Data.Click += new System.EventHandler(this.button_Send_Data_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.button_Open_Port);
            this.groupBox2.Location = new System.Drawing.Point(6, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 49);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(101, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // button_Open_Port
            // 
            this.button_Open_Port.Location = new System.Drawing.Point(6, 19);
            this.button_Open_Port.Name = "button_Open_Port";
            this.button_Open_Port.Size = new System.Drawing.Size(102, 23);
            this.button_Open_Port.TabIndex = 0;
            this.button_Open_Port.Text = "OPEN PORT";
            this.button_Open_Port.UseVisualStyleBackColor = true;
            this.button_Open_Port.Click += new System.EventHandler(this.button_Open_Port_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Combo_Parity_Bits);
            this.groupBox1.Controls.Add(this.Combo_Baud_Rate);
            this.groupBox1.Controls.Add(this.Combo_Data_Bits);
            this.groupBox1.Controls.Add(this.Combo_Stop_Bits);
            this.groupBox1.Controls.Add(this.Combo_Port_Number);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comm Port Control";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DATA BITS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "PORT NUMBER";
            // 
            // Combo_Parity_Bits
            // 
            this.Combo_Parity_Bits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Parity_Bits.FormattingEnabled = true;
            this.Combo_Parity_Bits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.Combo_Parity_Bits.Location = new System.Drawing.Point(6, 127);
            this.Combo_Parity_Bits.Name = "Combo_Parity_Bits";
            this.Combo_Parity_Bits.Size = new System.Drawing.Size(121, 21);
            this.Combo_Parity_Bits.TabIndex = 5;
            // 
            // Combo_Baud_Rate
            // 
            this.Combo_Baud_Rate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Baud_Rate.FormattingEnabled = true;
            this.Combo_Baud_Rate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.Combo_Baud_Rate.Location = new System.Drawing.Point(6, 47);
            this.Combo_Baud_Rate.Name = "Combo_Baud_Rate";
            this.Combo_Baud_Rate.Size = new System.Drawing.Size(121, 21);
            this.Combo_Baud_Rate.TabIndex = 4;
            // 
            // Combo_Data_Bits
            // 
            this.Combo_Data_Bits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Data_Bits.FormattingEnabled = true;
            this.Combo_Data_Bits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.Combo_Data_Bits.Location = new System.Drawing.Point(6, 73);
            this.Combo_Data_Bits.Name = "Combo_Data_Bits";
            this.Combo_Data_Bits.Size = new System.Drawing.Size(121, 21);
            this.Combo_Data_Bits.TabIndex = 3;
            // 
            // Combo_Stop_Bits
            // 
            this.Combo_Stop_Bits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Stop_Bits.FormattingEnabled = true;
            this.Combo_Stop_Bits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.Combo_Stop_Bits.Location = new System.Drawing.Point(6, 100);
            this.Combo_Stop_Bits.Name = "Combo_Stop_Bits";
            this.Combo_Stop_Bits.Size = new System.Drawing.Size(121, 21);
            this.Combo_Stop_Bits.TabIndex = 2;
            // 
            // Combo_Port_Number
            // 
            this.Combo_Port_Number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Port_Number.FormattingEnabled = true;
            this.Combo_Port_Number.Location = new System.Drawing.Point(6, 22);
            this.Combo_Port_Number.Name = "Combo_Port_Number";
            this.Combo_Port_Number.Size = new System.Drawing.Size(121, 21);
            this.Combo_Port_Number.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox_Health_Parameters);
            this.tabPage2.Controls.Add(this.groupBox_Identity_Params);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BaseStation Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.comboBox_TxPower);
            this.groupBox8.Controls.Add(this.comboBox_Radio_Channel);
            this.groupBox8.Controls.Add(this.textBox_ACK_Received_Radio);
            this.groupBox8.Controls.Add(this.button_Read_Radio_Data);
            this.groupBox8.Controls.Add(this.button_Save_Radio_Data);
            this.groupBox8.Controls.Add(this.label29);
            this.groupBox8.Controls.Add(this.label28);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.comboBox_DataRate);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.comboBox_Modulation);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.comboBox_Freq_Select);
            this.groupBox8.Location = new System.Drawing.Point(536, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(226, 298);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Radio Parameters (Decimal)";
            // 
            // comboBox_TxPower
            // 
            this.comboBox_TxPower.DropDownHeight = 80;
            this.comboBox_TxPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TxPower.FormattingEnabled = true;
            this.comboBox_TxPower.IntegralHeight = false;
            this.comboBox_TxPower.Location = new System.Drawing.Point(6, 127);
            this.comboBox_TxPower.Name = "comboBox_TxPower";
            this.comboBox_TxPower.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TxPower.TabIndex = 15;
            // 
            // comboBox_Radio_Channel
            // 
            this.comboBox_Radio_Channel.DropDownHeight = 80;
            this.comboBox_Radio_Channel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Radio_Channel.FormattingEnabled = true;
            this.comboBox_Radio_Channel.IntegralHeight = false;
            this.comboBox_Radio_Channel.Location = new System.Drawing.Point(6, 100);
            this.comboBox_Radio_Channel.Name = "comboBox_Radio_Channel";
            this.comboBox_Radio_Channel.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Radio_Channel.TabIndex = 14;
            // 
            // textBox_ACK_Received_Radio
            // 
            this.textBox_ACK_Received_Radio.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_ACK_Received_Radio.Location = new System.Drawing.Point(7, 270);
            this.textBox_ACK_Received_Radio.Name = "textBox_ACK_Received_Radio";
            this.textBox_ACK_Received_Radio.Size = new System.Drawing.Size(157, 20);
            this.textBox_ACK_Received_Radio.TabIndex = 13;
            this.textBox_ACK_Received_Radio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Read_Radio_Data
            // 
            this.button_Read_Radio_Data.Location = new System.Drawing.Point(6, 224);
            this.button_Read_Radio_Data.Name = "button_Read_Radio_Data";
            this.button_Read_Radio_Data.Size = new System.Drawing.Size(158, 40);
            this.button_Read_Radio_Data.TabIndex = 12;
            this.button_Read_Radio_Data.Text = "Read Data";
            this.button_Read_Radio_Data.UseVisualStyleBackColor = true;
            this.button_Read_Radio_Data.Click += new System.EventHandler(this.button_Read_Radio_Data_Click);
            // 
            // button_Save_Radio_Data
            // 
            this.button_Save_Radio_Data.Location = new System.Drawing.Point(6, 180);
            this.button_Save_Radio_Data.Name = "button_Save_Radio_Data";
            this.button_Save_Radio_Data.Size = new System.Drawing.Size(158, 38);
            this.button_Save_Radio_Data.TabIndex = 11;
            this.button_Save_Radio_Data.Text = "Save Data";
            this.button_Save_Radio_Data.UseVisualStyleBackColor = true;
            this.button_Save_Radio_Data.Click += new System.EventHandler(this.button_Save_Radio_Data_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(128, 130);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(82, 13);
            this.label29.TabIndex = 10;
            this.label29.Text = "Tx Power (dBm)";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(128, 103);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 13);
            this.label28.TabIndex = 7;
            this.label28.Text = "Channel [0 - 255]";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(128, 76);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(89, 13);
            this.label27.TabIndex = 5;
            this.label27.Text = "Data Rate (Kbps)";
            // 
            // comboBox_DataRate
            // 
            this.comboBox_DataRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DataRate.FormattingEnabled = true;
            this.comboBox_DataRate.Items.AddRange(new object[] {
            "25",
            "50",
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.comboBox_DataRate.Location = new System.Drawing.Point(6, 73);
            this.comboBox_DataRate.Name = "comboBox_DataRate";
            this.comboBox_DataRate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_DataRate.TabIndex = 4;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(128, 49);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 13);
            this.label26.TabIndex = 3;
            this.label26.Text = "Modulation";
            // 
            // comboBox_Modulation
            // 
            this.comboBox_Modulation.DisplayMember = "0";
            this.comboBox_Modulation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Modulation.FormattingEnabled = true;
            this.comboBox_Modulation.Items.AddRange(new object[] {
            "2FSK",
            "4FSK",
            "2GSFK BT=1",
            "4GFSK BT=1",
            "ASK_OOK",
            "2GFSK BT=0.5",
            "4GFSK BT=0.5"});
            this.comboBox_Modulation.Location = new System.Drawing.Point(6, 46);
            this.comboBox_Modulation.Name = "comboBox_Modulation";
            this.comboBox_Modulation.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Modulation.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(128, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "Freq Band (MHz)";
            // 
            // comboBox_Freq_Select
            // 
            this.comboBox_Freq_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Freq_Select.FormattingEnabled = true;
            this.comboBox_Freq_Select.Items.AddRange(new object[] {
            "868 European",
            "915 American"});
            this.comboBox_Freq_Select.Location = new System.Drawing.Point(6, 19);
            this.comboBox_Freq_Select.Name = "comboBox_Freq_Select";
            this.comboBox_Freq_Select.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Freq_Select.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox_ACK_Received_ADC);
            this.groupBox7.Controls.Add(this.button_ADC_Read_Data);
            this.groupBox7.Controls.Add(this.button_Save_ADC_Data);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.textBox_ADC_M_GAIN);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.textBox_ADC_P_GAIN);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.textBox_ADC_Offset);
            this.groupBox7.Location = new System.Drawing.Point(360, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(170, 298);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "ADC Parameters (Hexa C2)";
            // 
            // textBox_ACK_Received_ADC
            // 
            this.textBox_ACK_Received_ADC.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_ACK_Received_ADC.Location = new System.Drawing.Point(6, 270);
            this.textBox_ACK_Received_ADC.Name = "textBox_ACK_Received_ADC";
            this.textBox_ACK_Received_ADC.Size = new System.Drawing.Size(156, 20);
            this.textBox_ACK_Received_ADC.TabIndex = 8;
            this.textBox_ACK_Received_ADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_ADC_Read_Data
            // 
            this.button_ADC_Read_Data.Location = new System.Drawing.Point(6, 224);
            this.button_ADC_Read_Data.Name = "button_ADC_Read_Data";
            this.button_ADC_Read_Data.Size = new System.Drawing.Size(157, 40);
            this.button_ADC_Read_Data.TabIndex = 7;
            this.button_ADC_Read_Data.Text = "Read Data";
            this.button_ADC_Read_Data.UseVisualStyleBackColor = true;
            this.button_ADC_Read_Data.Click += new System.EventHandler(this.button_ADC_Read_Data_Click);
            // 
            // button_Save_ADC_Data
            // 
            this.button_Save_ADC_Data.Location = new System.Drawing.Point(6, 180);
            this.button_Save_ADC_Data.Name = "button_Save_ADC_Data";
            this.button_Save_ADC_Data.Size = new System.Drawing.Size(157, 38);
            this.button_Save_ADC_Data.TabIndex = 6;
            this.button_Save_ADC_Data.Text = "Save Data";
            this.button_Save_ADC_Data.UseVisualStyleBackColor = true;
            this.button_Save_ADC_Data.Click += new System.EventHandler(this.button_Save_ADC_Data_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(100, 76);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "ADC M Gain";
            // 
            // textBox_ADC_M_GAIN
            // 
            this.textBox_ADC_M_GAIN.Location = new System.Drawing.Point(6, 73);
            this.textBox_ADC_M_GAIN.Name = "textBox_ADC_M_GAIN";
            this.textBox_ADC_M_GAIN.Size = new System.Drawing.Size(93, 20);
            this.textBox_ADC_M_GAIN.TabIndex = 4;
            this.textBox_ADC_M_GAIN.Text = "827f";
            this.textBox_ADC_M_GAIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(100, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = "ADC P Gain";
            // 
            // textBox_ADC_P_GAIN
            // 
            this.textBox_ADC_P_GAIN.Location = new System.Drawing.Point(6, 46);
            this.textBox_ADC_P_GAIN.MaxLength = 5;
            this.textBox_ADC_P_GAIN.Name = "textBox_ADC_P_GAIN";
            this.textBox_ADC_P_GAIN.Size = new System.Drawing.Size(93, 20);
            this.textBox_ADC_P_GAIN.TabIndex = 2;
            this.textBox_ADC_P_GAIN.Text = "82b4";
            this.textBox_ADC_P_GAIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(100, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "ADC Offset";
            // 
            // textBox_ADC_Offset
            // 
            this.textBox_ADC_Offset.Location = new System.Drawing.Point(6, 19);
            this.textBox_ADC_Offset.MaxLength = 5;
            this.textBox_ADC_Offset.Name = "textBox_ADC_Offset";
            this.textBox_ADC_Offset.Size = new System.Drawing.Size(93, 20);
            this.textBox_ADC_Offset.TabIndex = 0;
            this.textBox_ADC_Offset.Text = "fffd";
            this.textBox_ADC_Offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox_Health_Parameters
            // 
            this.groupBox_Health_Parameters.Controls.Add(this.textBox_ACK_Received_Health);
            this.groupBox_Health_Parameters.Controls.Add(this.button_Read_Data_Health);
            this.groupBox_Health_Parameters.Controls.Add(this.button_Save_Data_Health);
            this.groupBox_Health_Parameters.Controls.Add(this.label21);
            this.groupBox_Health_Parameters.Controls.Add(this.textBox_Tx_period);
            this.groupBox_Health_Parameters.Controls.Add(this.label20);
            this.groupBox_Health_Parameters.Controls.Add(this.textBox_Temperature);
            this.groupBox_Health_Parameters.Controls.Add(this.label19);
            this.groupBox_Health_Parameters.Controls.Add(this.textBox_CPU_Voltage);
            this.groupBox_Health_Parameters.Controls.Add(this.label18);
            this.groupBox_Health_Parameters.Controls.Add(this.textBox_Battery_Voltage);
            this.groupBox_Health_Parameters.Location = new System.Drawing.Point(184, 6);
            this.groupBox_Health_Parameters.Name = "groupBox_Health_Parameters";
            this.groupBox_Health_Parameters.Size = new System.Drawing.Size(170, 298);
            this.groupBox_Health_Parameters.TabIndex = 1;
            this.groupBox_Health_Parameters.TabStop = false;
            this.groupBox_Health_Parameters.Text = "Health Parameters";
            // 
            // textBox_ACK_Received_Health
            // 
            this.textBox_ACK_Received_Health.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_ACK_Received_Health.Location = new System.Drawing.Point(7, 270);
            this.textBox_ACK_Received_Health.Name = "textBox_ACK_Received_Health";
            this.textBox_ACK_Received_Health.Size = new System.Drawing.Size(157, 20);
            this.textBox_ACK_Received_Health.TabIndex = 9;
            this.textBox_ACK_Received_Health.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Read_Data_Health
            // 
            this.button_Read_Data_Health.Location = new System.Drawing.Point(6, 224);
            this.button_Read_Data_Health.Name = "button_Read_Data_Health";
            this.button_Read_Data_Health.Size = new System.Drawing.Size(158, 40);
            this.button_Read_Data_Health.TabIndex = 8;
            this.button_Read_Data_Health.Text = "Read Data";
            this.button_Read_Data_Health.UseVisualStyleBackColor = true;
            this.button_Read_Data_Health.Click += new System.EventHandler(this.button_Read_Data_Health_Click);
            // 
            // button_Save_Data_Health
            // 
            this.button_Save_Data_Health.Location = new System.Drawing.Point(7, 180);
            this.button_Save_Data_Health.Name = "button_Save_Data_Health";
            this.button_Save_Data_Health.Size = new System.Drawing.Size(157, 38);
            this.button_Save_Data_Health.TabIndex = 2;
            this.button_Save_Data_Health.Text = "Save Data";
            this.button_Save_Data_Health.UseVisualStyleBackColor = true;
            this.button_Save_Data_Health.Click += new System.EventHandler(this.button_Save_Data_Health_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(105, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 39);
            this.label21.TabIndex = 7;
            this.label21.Text = "Tx period \r\n (minutes)\r\n\r\n";
            // 
            // textBox_Tx_period
            // 
            this.textBox_Tx_period.Location = new System.Drawing.Point(6, 100);
            this.textBox_Tx_period.MaxLength = 5;
            this.textBox_Tx_period.Name = "textBox_Tx_period";
            this.textBox_Tx_period.Size = new System.Drawing.Size(93, 20);
            this.textBox_Tx_period.TabIndex = 6;
            this.textBox_Tx_period.Text = "30";
            this.textBox_Tx_period.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(105, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Temp (Cº)";
            // 
            // textBox_Temperature
            // 
            this.textBox_Temperature.Location = new System.Drawing.Point(6, 73);
            this.textBox_Temperature.Name = "textBox_Temperature";
            this.textBox_Temperature.ReadOnly = true;
            this.textBox_Temperature.Size = new System.Drawing.Size(93, 20);
            this.textBox_Temperature.TabIndex = 4;
            this.textBox_Temperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(105, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Battery (V)";
            // 
            // textBox_CPU_Voltage
            // 
            this.textBox_CPU_Voltage.Location = new System.Drawing.Point(6, 46);
            this.textBox_CPU_Voltage.Name = "textBox_CPU_Voltage";
            this.textBox_CPU_Voltage.ReadOnly = true;
            this.textBox_CPU_Voltage.Size = new System.Drawing.Size(93, 20);
            this.textBox_CPU_Voltage.TabIndex = 2;
            this.textBox_CPU_Voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(105, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "CPU (V)";
            // 
            // textBox_Battery_Voltage
            // 
            this.textBox_Battery_Voltage.Location = new System.Drawing.Point(6, 19);
            this.textBox_Battery_Voltage.Name = "textBox_Battery_Voltage";
            this.textBox_Battery_Voltage.ReadOnly = true;
            this.textBox_Battery_Voltage.Size = new System.Drawing.Size(93, 20);
            this.textBox_Battery_Voltage.TabIndex = 0;
            this.textBox_Battery_Voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox_Identity_Params
            // 
            this.groupBox_Identity_Params.Controls.Add(this.textBox_ACK_Received_Identity);
            this.groupBox_Identity_Params.Controls.Add(this.label17);
            this.groupBox_Identity_Params.Controls.Add(this.textBox_Identity_Hw_Case);
            this.groupBox_Identity_Params.Controls.Add(this.button_Identity_ReadData);
            this.groupBox_Identity_Params.Controls.Add(this.button_Identity_SaveData);
            this.groupBox_Identity_Params.Controls.Add(this.label16);
            this.groupBox_Identity_Params.Controls.Add(this.textBox_Identity_HW_Version);
            this.groupBox_Identity_Params.Controls.Add(this.label15);
            this.groupBox_Identity_Params.Controls.Add(this.textBox_Identity_FW_CRC);
            this.groupBox_Identity_Params.Controls.Add(this.label14);
            this.groupBox_Identity_Params.Controls.Add(this.textBox_Identity_FW_Ver);
            this.groupBox_Identity_Params.Controls.Add(this.label13);
            this.groupBox_Identity_Params.Controls.Add(this.textBox_Identity_Node_Type);
            this.groupBox_Identity_Params.Controls.Add(this.label12);
            this.groupBox_Identity_Params.Controls.Add(this.textBox_Identity_NodeID);
            this.groupBox_Identity_Params.Location = new System.Drawing.Point(6, 6);
            this.groupBox_Identity_Params.Name = "groupBox_Identity_Params";
            this.groupBox_Identity_Params.Size = new System.Drawing.Size(172, 298);
            this.groupBox_Identity_Params.TabIndex = 0;
            this.groupBox_Identity_Params.TabStop = false;
            this.groupBox_Identity_Params.Text = "Identity Parameters (Decimal)";
            // 
            // textBox_ACK_Received_Identity
            // 
            this.textBox_ACK_Received_Identity.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_ACK_Received_Identity.Location = new System.Drawing.Point(6, 270);
            this.textBox_ACK_Received_Identity.Name = "textBox_ACK_Received_Identity";
            this.textBox_ACK_Received_Identity.Size = new System.Drawing.Size(159, 20);
            this.textBox_ACK_Received_Identity.TabIndex = 14;
            this.textBox_ACK_Received_Identity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(107, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "HW Case";
            // 
            // textBox_Identity_Hw_Case
            // 
            this.textBox_Identity_Hw_Case.Location = new System.Drawing.Point(7, 154);
            this.textBox_Identity_Hw_Case.Name = "textBox_Identity_Hw_Case";
            this.textBox_Identity_Hw_Case.Size = new System.Drawing.Size(93, 20);
            this.textBox_Identity_Hw_Case.TabIndex = 12;
            this.textBox_Identity_Hw_Case.Text = "0.0";
            this.textBox_Identity_Hw_Case.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Identity_ReadData
            // 
            this.button_Identity_ReadData.Location = new System.Drawing.Point(6, 224);
            this.button_Identity_ReadData.Name = "button_Identity_ReadData";
            this.button_Identity_ReadData.Size = new System.Drawing.Size(159, 40);
            this.button_Identity_ReadData.TabIndex = 11;
            this.button_Identity_ReadData.Text = "Read Data";
            this.button_Identity_ReadData.UseVisualStyleBackColor = true;
            this.button_Identity_ReadData.Click += new System.EventHandler(this.button_Identity_ReadData_Click);
            // 
            // button_Identity_SaveData
            // 
            this.button_Identity_SaveData.Location = new System.Drawing.Point(6, 180);
            this.button_Identity_SaveData.Name = "button_Identity_SaveData";
            this.button_Identity_SaveData.Size = new System.Drawing.Size(159, 38);
            this.button_Identity_SaveData.TabIndex = 10;
            this.button_Identity_SaveData.Text = "Save Data";
            this.button_Identity_SaveData.UseVisualStyleBackColor = true;
            this.button_Identity_SaveData.Click += new System.EventHandler(this.button_Identity_SaveData_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(107, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "HW Version";
            // 
            // textBox_Identity_HW_Version
            // 
            this.textBox_Identity_HW_Version.Location = new System.Drawing.Point(7, 127);
            this.textBox_Identity_HW_Version.MaxLength = 5;
            this.textBox_Identity_HW_Version.Name = "textBox_Identity_HW_Version";
            this.textBox_Identity_HW_Version.Size = new System.Drawing.Size(93, 20);
            this.textBox_Identity_HW_Version.TabIndex = 8;
            this.textBox_Identity_HW_Version.Text = "0.0";
            this.textBox_Identity_HW_Version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(107, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "FW CRC";
            // 
            // textBox_Identity_FW_CRC
            // 
            this.textBox_Identity_FW_CRC.Location = new System.Drawing.Point(7, 100);
            this.textBox_Identity_FW_CRC.MaxLength = 5;
            this.textBox_Identity_FW_CRC.Name = "textBox_Identity_FW_CRC";
            this.textBox_Identity_FW_CRC.Size = new System.Drawing.Size(93, 20);
            this.textBox_Identity_FW_CRC.TabIndex = 6;
            this.textBox_Identity_FW_CRC.Text = "0";
            this.textBox_Identity_FW_CRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(106, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "FW Version";
            // 
            // textBox_Identity_FW_Ver
            // 
            this.textBox_Identity_FW_Ver.Location = new System.Drawing.Point(7, 73);
            this.textBox_Identity_FW_Ver.MaxLength = 5;
            this.textBox_Identity_FW_Ver.Name = "textBox_Identity_FW_Ver";
            this.textBox_Identity_FW_Ver.Size = new System.Drawing.Size(93, 20);
            this.textBox_Identity_FW_Ver.TabIndex = 4;
            this.textBox_Identity_FW_Ver.Text = "0.0";
            this.textBox_Identity_FW_Ver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(106, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Node Type";
            // 
            // textBox_Identity_Node_Type
            // 
            this.textBox_Identity_Node_Type.Location = new System.Drawing.Point(7, 46);
            this.textBox_Identity_Node_Type.MaxLength = 1;
            this.textBox_Identity_Node_Type.Name = "textBox_Identity_Node_Type";
            this.textBox_Identity_Node_Type.Size = new System.Drawing.Size(93, 20);
            this.textBox_Identity_Node_Type.TabIndex = 2;
            this.textBox_Identity_Node_Type.Text = "0";
            this.textBox_Identity_Node_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Node ID";
            // 
            // textBox_Identity_NodeID
            // 
            this.textBox_Identity_NodeID.Location = new System.Drawing.Point(6, 19);
            this.textBox_Identity_NodeID.MaxLength = 1;
            this.textBox_Identity_NodeID.Name = "textBox_Identity_NodeID";
            this.textBox_Identity_NodeID.Size = new System.Drawing.Size(94, 20);
            this.textBox_Identity_NodeID.TabIndex = 0;
            this.textBox_Identity_NodeID.Text = "1";
            this.textBox_Identity_NodeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Identity_NodeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Identity_NodeID_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 515);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "LiteMote Gateway";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox_Build_Serial_Frame.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox_Frame_Header.ResumeLayout(false);
            this.groupBox_Frame_Header.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox_Health_Parameters.ResumeLayout(false);
            this.groupBox_Health_Parameters.PerformLayout();
            this.groupBox_Identity_Params.ResumeLayout(false);
            this.groupBox_Identity_Params.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Combo_Parity_Bits;
        private System.Windows.Forms.ComboBox Combo_Baud_Rate;
        private System.Windows.Forms.ComboBox Combo_Data_Bits;
        private System.Windows.Forms.ComboBox Combo_Stop_Bits;
        private System.Windows.Forms.ComboBox Combo_Port_Number;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_Send_Data;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_Open_Port;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_Data_Received;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_Data_To_Send;
        private System.Windows.Forms.GroupBox groupBox_Build_Serial_Frame;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Stop_Frame_Char;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Start_Frame_Char;
        private System.Windows.Forms.RadioButton radioButton_base64_encoding;
        private System.Windows.Forms.RadioButton radioButton_raw_encoding;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox_Frame_Header;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Msg_Type;
        private System.Windows.Forms.TextBox textBox_Send_Time;
        private System.Windows.Forms.TextBox textBox_Destination_Node;
        private System.Windows.Forms.TextBox textBox_Origin_Node;
        private System.Windows.Forms.TextBox textBox_Frame_Payload;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox_Identity_Params;
        private System.Windows.Forms.Button button_Identity_ReadData;
        private System.Windows.Forms.Button button_Identity_SaveData;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_Identity_HW_Version;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_Identity_FW_CRC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_Identity_FW_Ver;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Identity_Node_Type;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_Identity_NodeID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_Identity_Hw_Case;
        private System.Windows.Forms.TextBox textBox_ACK_Received_Identity;
        private System.Windows.Forms.GroupBox groupBox_Health_Parameters;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_Battery_Voltage;
        private System.Windows.Forms.TextBox textBox_CPU_Voltage;
        private System.Windows.Forms.TextBox textBox_ACK_Received_Health;
        private System.Windows.Forms.Button button_Read_Data_Health;
        private System.Windows.Forms.Button button_Save_Data_Health;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_Tx_period;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_Temperature;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_ADC_P_GAIN;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_ADC_Offset;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_ADC_M_GAIN;
        private System.Windows.Forms.Button button_Save_ADC_Data;
        private System.Windows.Forms.TextBox textBox_ACK_Received_ADC;
        private System.Windows.Forms.Button button_ADC_Read_Data;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBox_Freq_Select;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboBox_Modulation;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox comboBox_DataRate;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button button_Save_Radio_Data;
        private System.Windows.Forms.Button button_Read_Radio_Data;
        private System.Windows.Forms.TextBox textBox_ACK_Received_Radio;
        private System.Windows.Forms.ComboBox comboBox_Radio_Channel;
        private System.Windows.Forms.ComboBox comboBox_TxPower;
    }
}

