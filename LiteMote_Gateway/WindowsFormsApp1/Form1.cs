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
using System.Timers;

using WindowsFormsApp1.conversions;
using WindowsFormsApp1.crc_utils;
using WindowsFormsApp1.frame_header;
using WindowsFormsApp1.Definitions;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

        string data_in;
        string data_decoded;

        Header header_serial_data;
        Header header_rx_serial_data;

        ushort msg_type_sent = 0;

        delegate void SetTextCallback(string text, Color c);

        //base64 encoding related vars
        string base64_frame_Start_char;
        string base64_frame_Stop_char;

        // Create a timer and set a two second interval.
        private System.Timers.Timer aTimer;
        private System.Timers.Timer bTimer;

        public Form1()
        {
            //TEST            
            Console.WriteLine("Starting App...");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ushort i = 0;
            double y = -30;

            string[] ports = SerialPort.GetPortNames();
            Combo_Port_Number.Items.AddRange(ports);

            for (i = 0; i <= 255; i++)
            {
                comboBox_Radio_Channel.Items.Add(i);
            }

            while(y<=16)
            {
                comboBox_TxPower.Items.Add(y.ToString());
                y = y + 0.5;
            }

            radioButton_raw_encoding.Select();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_Open_Port_Click(object sender, EventArgs e)
        {

            if (!serialPort1.IsOpen)
            {
                try
                {
                    //blocking start and stop char text box
                    textBox_Stop_Frame_Char.Enabled = false;
                    textBox_Start_Frame_Char.Enabled = false;

                    serialPort1.PortName = Combo_Port_Number.Text;
                    serialPort1.BaudRate = Convert.ToInt32(Combo_Baud_Rate.Text);
                    serialPort1.DataBits = Convert.ToInt32(Combo_Data_Bits.Text);
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), Combo_Stop_Bits.Text);
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), Combo_Parity_Bits.Text);

                    serialPort1.ReadTimeout = 200;

                    serialPort1.Open();

                    button_Open_Port.Text = "CLOSE PORT";
                    progressBar1.Value = 100;

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
            else
            {
                button_Open_Port.Text = "OPEN PORT";
                progressBar1.Value = 0;

                textBox_Stop_Frame_Char.Enabled = true;
                textBox_Start_Frame_Char.Enabled = true;

                serialPort1.Close();
            }
        }

        private void button_Send_Data_Click(object sender, EventArgs e)
        {
            string data_out;

            byte data_origin_node;
            byte data_destination_node;
            byte[] array_data_send_time = new byte[2];
            byte[] array_data_msg_type = new byte[2];
            byte[] array_payload_lenght = new byte[2];

            byte[] data_header_array = new byte[/*array_data_origin_node*/ 1 + /*array_data_destination_node*/ 1 + array_data_send_time.Length + array_data_msg_type.Length + 1];
            byte[] data_payload_array;

            bool data_overflow_error = false;

            if (serialPort1.IsOpen)
            {
                /*
                - Build frame: header + payload + CRC
                - Encode frame                        
                - Send serial encodedframe 
                */

                textBox_Data_To_Send.Clear();

                if(radioButton_base64_encoding.Checked)
                {
                    //encoding frame to base64                
                    if(UInt32.Parse(textBox_Origin_Node.Text) > 0xffff)
                    {
                        MessageBox.Show("Overflow error, origin node valid address limits [0 - 65535]");
                        data_overflow_error = true;
                    }
                    else
                    {
                        header_serial_data.origin_node = byte.Parse(textBox_Origin_Node.Text);
                    }

                    if (UInt32.Parse(textBox_Destination_Node.Text) > 0xffff)
                    {
                        MessageBox.Show("Overflow error, destination node valid address [0 - 65535]");
                        data_overflow_error = true;
                    }
                    else
                    {
                        header_serial_data.destination_node = byte.Parse(textBox_Destination_Node.Text);
                    }

                    if (UInt32.Parse(textBox_Send_Time.Text) > 0xffff)
                    {
                        MessageBox.Show("Overflow error, send time valid [0 - 5000] ( ms )");
                        data_overflow_error = true;
                    }
                    else
                    {
                        header_serial_data.send_time = ushort.Parse(textBox_Send_Time.Text);
                    }

                    if (ushort.Parse(textBox_Msg_Type.Text) > 0xff)
                    {
                        MessageBox.Show("Overflow error, valid msg types [0 - 255]");
                        data_overflow_error = true;
                    }
                    else
                    {
                        header_serial_data.msg_type = byte.Parse(textBox_Msg_Type.Text);
                    }

                    if (textBox_Frame_Payload.Text.Length > 128 - data_header_array.Length + 2)
                    {
                        MessageBox.Show("Overflow error, valid payload lenght [0 - 119]");
                        data_overflow_error = true;

                        data_payload_array = HexStringConverter.ToByteArray("0");
                    }
                    else
                    {
                        //convert textbox data to hexadecimal byte array
                        data_payload_array = HexStringConverter.ToByteArray(textBox_Frame_Payload.Text);
                        header_serial_data.payload_length = (byte)(data_payload_array.Length);
                    }
                    if (data_overflow_error == false)
                    {                       

                        //arrange data to send it properly via serial port
                        data_origin_node = header_serial_data.origin_node;
                        data_destination_node = header_serial_data.destination_node;

                        array_data_send_time = BitConverter.GetBytes(header_serial_data.send_time);
                        Array.Reverse(array_data_send_time); //big endian data

                        array_data_msg_type = BitConverter.GetBytes(header_serial_data.msg_type);
                        Array.Reverse(array_data_msg_type); //big endian data

                        array_payload_lenght = BitConverter.GetBytes(header_serial_data.payload_length);
                        Array.Reverse(array_payload_lenght); //big endian data

                        //copy data collected from text box to header array
                        data_header_array[ComDef.INDEX_HEADER_ORIGIN_ADDRESS] = data_origin_node;
                        data_header_array[ComDef.INDEX_HEADER_DESTINATION_ADDRESS] = data_destination_node;
                        data_header_array[ComDef.INDEX_HEADER_SEND_TIME_MSB] = array_data_send_time[0];
                        data_header_array[ComDef.INDEX_HEADER_SEND_TIME_LSB] = array_data_send_time[1];
                        data_header_array[ComDef.INDEX_HEADER_MSG_TYPE_MSB] = array_data_msg_type[0];
                        data_header_array[ComDef.INDEX_HEADER_MSG_TYPE_LSB] = array_data_msg_type[1];

                        byte[] array_to_send = new byte[data_header_array.Length + data_payload_array.Length ]; 
                        byte[] array_to_send_plus_crc = new byte[array_to_send.Length + 2];

                        ushort frame_CRC = 0;
                        byte[] array_crc = new byte[2];

                        //form byte array to be sent via serial port
                        System.Buffer.BlockCopy(data_header_array, 0, array_to_send, 0, data_header_array.Length);                       
                        System.Buffer.BlockCopy(data_payload_array, 0, array_to_send, data_header_array.Length, data_payload_array.Length);
           
                        //add CRC to the end of the built frame
                        frame_CRC = CRC_16_ARC.Crc16_ARC(array_to_send);
                        array_crc = BitConverter.GetBytes(frame_CRC);
                        Array.Reverse(array_crc); //big endian data
                        System.Buffer.BlockCopy(array_to_send, 0, array_to_send_plus_crc, 0, data_header_array.Length + data_payload_array.Length);
                        System.Buffer.BlockCopy(array_crc, 0, array_to_send_plus_crc, data_header_array.Length + data_payload_array.Length, 2);

                        //encode to base64
                        data_out = System.Convert.ToBase64String(array_to_send_plus_crc);

                        //ad start and stop characters
                        data_out = textBox_Start_Frame_Char.Text + data_out + textBox_Stop_Frame_Char.Text;

                        //send data
                        serialPort1.Write(data_out);

                        //print sent data
                        textBox_Data_To_Send.Text += data_out + Environment.NewLine;
                    }
                }

                if(radioButton_raw_encoding.Checked)
                {
                    //raw encoding serial frame
                }               
            }
        }

        private void ShowData(object sender, EventArgs e)
        {
            textBox_Data_Received.Text = data_in;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //read data
            data_in = serialPort1.ReadTo(textBox_Stop_Frame_Char.Text);
            //data_in = serialPort1.ReadExisting();

            //flush data received 
            serialPort1.DiscardInBuffer();

            this.Invoke(new EventHandler(Show_Data));
        }
         
        private void Show_Data(object sender, EventArgs e)
        {
            //show data
            textBox_Data_Received.AppendText(DateTime.Now + " " + data_in + ">");
            List<byte> dataPayload = new List<byte>();

            //check if data is encoded
            if(radioButton_base64_encoding.Enabled == true)
            {
                //decode data                
                data_in = data_in.Substring(1);
                byte[] textAsBytes = System.Convert.FromBase64String(data_in);

                //check CRC from received frame
                ushort crc_Received = (ushort)textAsBytes[textAsBytes.Length - 2];
                crc_Received <<= 8;
                crc_Received |= (ushort)textAsBytes[textAsBytes.Length - 1];

                byte[] textAsBytes_Without_CRC = new byte[textAsBytes.Length - 2];
                Array.Copy(textAsBytes, textAsBytes_Without_CRC, textAsBytes.Length - 2);

                if((crc_Received != CRC_16_ARC.Crc16_ARC(textAsBytes_Without_CRC)))
                {
                    //CRC not match, bad frame signal it
                    textBox_Data_Received.AppendText(" " + "->" + " BAD CRC FRAME " + System.Environment.NewLine);
                }
                else
                {
                    //CRC match, frame OK, displaying   

                    data_decoded = BitConverter.ToString(textAsBytes).Replace("-", "");
                    textBox_Data_Received.AppendText(" " + "->" + " " + " CRC OK " + data_decoded + System.Environment.NewLine);
                }

                //Process packet received
                //save header received
                header_rx_serial_data.origin_node = textAsBytes[0];
                header_rx_serial_data.origin_node <<= 8;
                header_rx_serial_data.origin_node |= textAsBytes[1];

                header_rx_serial_data.destination_node = textAsBytes[2];
                header_rx_serial_data.destination_node <<= 8;
                header_rx_serial_data.destination_node |= textAsBytes[3];

                header_rx_serial_data.send_time = textAsBytes[4];
                header_rx_serial_data.send_time <<= 8;
                header_rx_serial_data.send_time |= textAsBytes[5];

                header_rx_serial_data.msg_type = textAsBytes[6];
                header_rx_serial_data.msg_type <<= 8;
                header_rx_serial_data.msg_type |= textAsBytes[7];

                header_rx_serial_data.payload_length = textAsBytes[8];

                //save payload received
                int j = 9;
                for(int i = 0; i < header_rx_serial_data.payload_length; i++)
                {
                    dataPayload.Add(textAsBytes[j++]); 
                }

                Process_messages_Rx(dataPayload, header_rx_serial_data.msg_type);
            }
            else
            {
                //TODO raw frame receiving
            }
        }

        private void radioButton_base64_encoding_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_base64_encoding.Checked)
            {
                //enabling start and stop char selection
                textBox_Start_Frame_Char.Enabled = true;
                textBox_Stop_Frame_Char.Enabled = true;

                //get sart and stop chars from textbox
                base64_frame_Start_char = textBox_Start_Frame_Char.Text; 
                base64_frame_Stop_char = textBox_Stop_Frame_Char.Text;
            }
        }

        private void radioButton_raw_encoding_CheckedChanged(object sender, EventArgs e)
        {
            //disabling start and stop char selection
            textBox_Start_Frame_Char.Clear();
            textBox_Stop_Frame_Char.Clear();

            textBox_Start_Frame_Char.Enabled = false;
            textBox_Stop_Frame_Char.Enabled = false;
        }

        private void textBox_Frame_Payload_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accepting only hexadecimal characters, 8 is backspace
            char c = e.KeyChar;
            if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f') || (c == 8) ))  
            {
                e.Handled = true;
            }
        }

        private void textBox_Origin_Node_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accepting only decimal characters, 8 is backspace
            char c = e.KeyChar;
            if (!((c >= '0' && c <= '9') || (c == 8)))
            {
                e.Handled = true;
            }
        }

        private void textBox_Destination_Node_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accepting only decimal characters, 8 is backspace
            char c = e.KeyChar;
            if (!((c >= '0' && c <= '9') || (c == 8)))
            {
                e.Handled = true;
            }
        }

        private void textBox_Send_Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accepting only decimal characters, 8 is backspace
            char c = e.KeyChar;
            if (!((c >= '0' && c <= '9') || (c == 8)))
            {
                e.Handled = true;
            }
        }

        private void textBox_Msg_Type_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accepting only decimal characters, 8 is backspace
            char c = e.KeyChar;
            if (!((c >= '0' && c <= '9') || (c == 8)))
            {
                e.Handled = true;
            }
        }

        private void textBox_Identity_NodeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accepting only decimal characters, 8 is backspace
            char c = e.KeyChar;
            if (!((c >= '0' && c <= '9') || (c == 8)))
            {
                e.Handled = true;
            }
        }

        private void SetText(string text, Color c)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.

            switch (msg_type_sent)
            {
                case ComDef.MSG_TYPE_SEND_IDENTITY:
                    
                    if (this.textBox_ACK_Received_Identity.InvokeRequired)
                    {
                        SetTextCallback d = new SetTextCallback(SetText);
                        this.Invoke(d, new object[] { text, c });
                    }
                    else
                    {
                        this.textBox_ACK_Received_Identity.Text = text;
                        this.textBox_ACK_Received_Identity.BackColor = c;
                    }

                    break;

                case ComDef.MSG_TYPE_SEND_HEALTH_CONF:

                    if (this.textBox_ACK_Received_Health.InvokeRequired)
                    {
                        SetTextCallback d = new SetTextCallback(SetText);
                        this.Invoke(d, new object[] { text, c });
                    }
                    else
                    {
                        this.textBox_ACK_Received_Health.Text = text;
                        this.textBox_ACK_Received_Health.BackColor = c;
                    }

                    break;

                case ComDef.MSG_TYPE_SEND_ADC_CAL:

                    if (this.textBox_ACK_Received_ADC.InvokeRequired)
                    {
                        SetTextCallback d = new SetTextCallback(SetText);
                        this.Invoke(d, new object[] { text, c });
                    }
                    else
                    {
                        this.textBox_ACK_Received_ADC.Text = text;
                        this.textBox_ACK_Received_ADC.BackColor = c;
                    }

                    break;

                case ComDef.MSG_TYPE_SEND_RADIO_CONFIG:

                    if (this.textBox_ACK_Received_Radio.InvokeRequired)
                    {
                        SetTextCallback d = new SetTextCallback(SetText);
                        this.Invoke(d, new object[] { text, c });
                    }
                    else
                    {
                        this.textBox_ACK_Received_Radio.Text = text;
                        this.textBox_ACK_Received_Radio.BackColor = c;
                    }

                    break;
            }

            //reset msg_type_send
            msg_type_sent = 0;
        }

        private void OnTimedEvent_aTimer(Object source, System.Timers.ElapsedEventArgs e)
        {
            aTimer.Stop();
            aTimer.Elapsed -= OnTimedEvent_aTimer;
            aTimer.Dispose();

            SetText("ACK NOT RECEIVED!", Color.Red);            
        }        

        private void button_Identity_SaveData_Click(object sender, EventArgs e)
        {
            List<byte> msg = new List<byte>();
            UInt16 msgCRC = 0;
            
            string[] arr;            

            //building message
            header_serial_data.origin_node = ComDef.HOST;
            header_serial_data.destination_node = byte.Parse(textBox_Identity_NodeID.Text);
            header_serial_data.send_time = ComDef.SECOND_SEND_TIME;
            header_serial_data.msg_type = ComDef.MSG_TYPE_SEND_IDENTITY;
            header_serial_data.payload_length = ComDef.MSG_TYPE_SEND_IDENTITY_PAYLOAD_LENGTH;

            //fill header
            msg.Add((byte)(header_serial_data.origin_node));
            msg.Add((byte)(header_serial_data.destination_node));
            msg.Add((byte)((header_serial_data.send_time) >> 8));
            msg.Add((byte)((header_serial_data.send_time) & 0x00FF));
            msg.Add((byte)((header_serial_data.msg_type) >> 8));
            msg.Add((byte)((header_serial_data.msg_type) & 0x00FF));
            msg.Add((byte)((header_serial_data.payload_length)));

            //fill payload
            msg.Add((byte)(Convert.ToUInt16(textBox_Identity_NodeID.Text) >> 8));
            msg.Add((byte)(Convert.ToUInt16(textBox_Identity_NodeID.Text) & 0x00FF));

            msg.Add((byte)(Convert.ToUInt16(textBox_Identity_Node_Type.Text) >> 8));
            msg.Add((byte)(Convert.ToUInt16(textBox_Identity_Node_Type.Text) & 0x00FF));

            arr = textBox_Identity_FW_Ver.Text.Split('.');
            msg.Add(Convert.ToByte(arr[0]));
            msg.Add(Convert.ToByte(arr[1]));

            msg.Add((byte)(Convert.ToUInt16(textBox_Identity_FW_CRC.Text) >> 8));
            msg.Add((byte)(Convert.ToUInt16(textBox_Identity_FW_CRC.Text) & 0x00FF));

            arr = textBox_Identity_HW_Version.Text.Split('.');
            msg.Add(Convert.ToByte(arr[0]));
            msg.Add(Convert.ToByte(arr[1]));

            arr = textBox_Identity_Hw_Case.Text.Split('.');
            msg.Add(Convert.ToByte(arr[0]));
            msg.Add(Convert.ToByte(arr[1]));

            //calculating and adding CRC to the end of the built frame
            msgCRC = CRC_16_ARC.Crc16_ARC(msg.ToArray());
            msg.Add((byte)(msgCRC >> 8));
            msg.Add((byte)(msgCRC & 0x00FF));

            msg_type_sent = header_serial_data.msg_type;

            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += OnTimedEvent_aTimer;

            aTimer.Interval = 3000;
            aTimer.Start();

            serialPort1.Write(textBox_Start_Frame_Char.Text + System.Convert.ToBase64String(msg.ToArray()) + textBox_Stop_Frame_Char.Text);
        }

        private void button_Identity_ReadData_Click(object sender, EventArgs e)
        {
            List<byte> msg = new List<byte>();
            UInt16 msgCRC = 0;

            //building message
            header_serial_data.origin_node = ComDef.HOST;
            header_serial_data.destination_node =  Convert.ToByte(textBox_Identity_NodeID.Text);
            header_serial_data.send_time = ComDef.SECOND_SEND_TIME;
            header_serial_data.msg_type = ComDef.MSG_TYPE_RETRIEVE_IDENTITY;
            header_serial_data.payload_length = ComDef.MSG_TYPE_RETRIEVE_IDENTITY_PAYLOAD_LENGTH;

            //fill header
            msg.Add((byte)(header_serial_data.origin_node));
            msg.Add((byte)(header_serial_data.destination_node));
            msg.Add((byte)((header_serial_data.send_time) >> 8));
            msg.Add((byte)((header_serial_data.send_time) & 0x00FF));
            msg.Add((byte)((header_serial_data.msg_type) >> 8));
            msg.Add((byte)((header_serial_data.msg_type) & 0x00FF));
            msg.Add((byte)((header_serial_data.payload_length)));

            //calculating and adding CRC to the end of the built frame
            msgCRC = CRC_16_ARC.Crc16_ARC(msg.ToArray());
            msg.Add((byte)(msgCRC >> 8));
            msg.Add((byte)(msgCRC & 0x00FF));

            serialPort1.Write(textBox_Start_Frame_Char.Text + System.Convert.ToBase64String(msg.ToArray()) + textBox_Stop_Frame_Char.Text);

        }

        private void button_Save_Data_Health_Click(object sender, EventArgs e)
        {
            List<byte> msg = new List<byte>();
            UInt16 msgCRC = 0;

            //building message
            header_serial_data.origin_node = ComDef.HOST;
            header_serial_data.destination_node = Convert.ToByte(textBox_Identity_NodeID.Text);
            header_serial_data.send_time = ComDef.SECOND_SEND_TIME;
            header_serial_data.msg_type = ComDef.MSG_TYPE_SEND_HEALTH_CONF;
            header_serial_data.payload_length = ComDef.MSG_TYPE_SEND_HEALTH_CONF_PAYLOAD_LENGHT;

            //fill header
            msg.Add((byte)(header_serial_data.origin_node));
            msg.Add((byte)(header_serial_data.destination_node));
            msg.Add((byte)((header_serial_data.send_time) >> 8));
            msg.Add((byte)((header_serial_data.send_time) & 0x00FF));
            msg.Add((byte)((header_serial_data.msg_type) >> 8));
            msg.Add((byte)((header_serial_data.msg_type) & 0x00FF));
            msg.Add((byte)((header_serial_data.payload_length)));

            //fill payload
            msg.Add((byte)(Convert.ToUInt16(textBox_Tx_period.Text) >> 8));
            msg.Add((byte)(Convert.ToUInt16(textBox_Tx_period.Text)));

            //calculating and adding CRC to the end of the built frame
            msgCRC = CRC_16_ARC.Crc16_ARC(msg.ToArray());
            msg.Add((byte)(msgCRC >> 8));
            msg.Add((byte)(msgCRC & 0x00FF));

            msg_type_sent = header_serial_data.msg_type;

            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += OnTimedEvent_aTimer;

            aTimer.Interval = 3000;
            aTimer.Start();

            serialPort1.Write(textBox_Start_Frame_Char.Text + System.Convert.ToBase64String(msg.ToArray()) + textBox_Stop_Frame_Char.Text);
        }

        private void button_Read_Data_Health_Click(object sender, EventArgs e)
        {
            List<byte> msg = new List<byte>();
            UInt16 msgCRC = 0;

            //building message
            header_serial_data.origin_node = ComDef.HOST;
            header_serial_data.destination_node = Convert.ToByte(textBox_Identity_NodeID.Text);
            header_serial_data.send_time = ComDef.SECOND_SEND_TIME;
            header_serial_data.msg_type = ComDef.MSG_TYPE_RETRIEVE_HEALTH;
            header_serial_data.payload_length = ComDef.MSG_TYPE_RETRIEVE_HEALTH_PAYLOAD_LENGHT;

            //fill header
            msg.Add((byte)(header_serial_data.origin_node));
            msg.Add((byte)(header_serial_data.destination_node));
            msg.Add((byte)((header_serial_data.send_time) >> 8));
            msg.Add((byte)((header_serial_data.send_time) & 0x00FF));
            msg.Add((byte)((header_serial_data.msg_type) >> 8));
            msg.Add((byte)((header_serial_data.msg_type) & 0x00FF));
            msg.Add((byte)((header_serial_data.payload_length)));

            //calculating and adding CRC to the end of the built frame
            msgCRC = CRC_16_ARC.Crc16_ARC(msg.ToArray());
            msg.Add((byte)(msgCRC >> 8));
            msg.Add((byte)(msgCRC & 0x00FF));

            serialPort1.Write(textBox_Start_Frame_Char.Text + System.Convert.ToBase64String(msg.ToArray()) + textBox_Stop_Frame_Char.Text);
        }

        private void button_Save_ADC_Data_Click(object sender, EventArgs e)
        {
            List<byte> msg = new List<byte>();
            UInt16 msgCRC = 0;

            //building message
            header_serial_data.origin_node = ComDef.HOST;
            header_serial_data.destination_node = Convert.ToByte(textBox_Identity_NodeID.Text);
            header_serial_data.send_time = ComDef.SECOND_SEND_TIME;
            header_serial_data.msg_type = ComDef.MSG_TYPE_SEND_ADC_CAL;
            header_serial_data.payload_length = ComDef.MSG_TYPE_SEND_ADC_CAL_LENGTH;

            //fill header
            msg.Add((byte)(header_serial_data.origin_node));
            msg.Add((byte)(header_serial_data.destination_node));
            msg.Add((byte)((header_serial_data.send_time) >> 8));
            msg.Add((byte)((header_serial_data.send_time) & 0x00FF));
            msg.Add((byte)((header_serial_data.msg_type) >> 8));
            msg.Add((byte)((header_serial_data.msg_type) & 0x00FF));
            msg.Add((byte)((header_serial_data.payload_length)));

            //fill payload
            msg.Add((byte)(Convert.ToInt16(textBox_ADC_Offset.Text, 16) >> 8));
            msg.Add((byte)(Convert.ToInt16(textBox_ADC_Offset.Text, 16)));

            msg.Add((byte)(Convert.ToInt16(textBox_ADC_P_GAIN.Text, 16) >> 8));
            msg.Add((byte)(Convert.ToInt16(textBox_ADC_P_GAIN.Text, 16)));

            msg.Add((byte)(Convert.ToInt16(textBox_ADC_M_GAIN.Text, 16) >> 8));
            msg.Add((byte)(Convert.ToInt16(textBox_ADC_M_GAIN.Text, 16)));

            //calculating and adding CRC to the end of the built frame
            msgCRC = CRC_16_ARC.Crc16_ARC(msg.ToArray());
            msg.Add((byte)(msgCRC >> 8));
            msg.Add((byte)(msgCRC & 0x00FF));

            msg_type_sent = header_serial_data.msg_type;

            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += OnTimedEvent_aTimer;

            aTimer.Interval = 3000;
            aTimer.Start();

            serialPort1.Write(textBox_Start_Frame_Char.Text + System.Convert.ToBase64String(msg.ToArray()) + textBox_Stop_Frame_Char.Text);
        }

        private void button_ADC_Read_Data_Click(object sender, EventArgs e)
        {
            List<byte> msg = new List<byte>();
            UInt16 msgCRC = 0;

            //building message
            header_serial_data.origin_node = ComDef.HOST;
            header_serial_data.destination_node = Convert.ToByte(textBox_Identity_NodeID.Text);
            header_serial_data.send_time = ComDef.SECOND_SEND_TIME;
            header_serial_data.msg_type = ComDef.MSG_TYPE_RETRIEVE_ADC_CAL;
            header_serial_data.payload_length = ComDef.MSG_TYPE_RETRIEVE_ADC_CAL_LENGTH;

            //fill header
            msg.Add((byte)(header_serial_data.origin_node));
            msg.Add((byte)(header_serial_data.destination_node));
            msg.Add((byte)((header_serial_data.send_time) >> 8));
            msg.Add((byte)((header_serial_data.send_time) & 0x00FF));
            msg.Add((byte)((header_serial_data.msg_type) >> 8));
            msg.Add((byte)((header_serial_data.msg_type) & 0x00FF));
            msg.Add((byte)((header_serial_data.payload_length)));

            //calculating and adding CRC to the end of the built frame
            msgCRC = CRC_16_ARC.Crc16_ARC(msg.ToArray());
            msg.Add((byte)(msgCRC >> 8));
            msg.Add((byte)(msgCRC & 0x00FF));

            serialPort1.Write(textBox_Start_Frame_Char.Text + System.Convert.ToBase64String(msg.ToArray()) + textBox_Stop_Frame_Char.Text);
        }

        private void button_Save_Radio_Data_Click(object sender, EventArgs e)
        {
            List<byte> msg = new List<byte>();
            UInt16 msgCRC = 0;

            RadioConversions radConv = new RadioConversions();

            try
            {
                //building message
                header_serial_data.origin_node = ComDef.HOST;
                header_serial_data.destination_node = Convert.ToByte(textBox_Identity_NodeID.Text);
                header_serial_data.send_time = ComDef.SECOND_SEND_TIME;
                header_serial_data.msg_type = ComDef.MSG_TYPE_SEND_RADIO_CONFIG;
                header_serial_data.payload_length = ComDef.MSG_TYPE_SEND_RADIO_CONFIG_LENGTH;

                //fill header
                msg.Add((byte)(header_serial_data.origin_node));
                msg.Add((byte)(header_serial_data.destination_node));
                msg.Add((byte)((header_serial_data.send_time) >> 8));
                msg.Add((byte)((header_serial_data.send_time) & 0x00FF));
                msg.Add((byte)((header_serial_data.msg_type) >> 8));
                msg.Add((byte)((header_serial_data.msg_type) & 0x00FF));
                msg.Add((byte)((header_serial_data.payload_length)));

                //fill payload
                msg.Add((byte)(Convert.ToByte(comboBox_Freq_Select.SelectedIndex)));
                msg.Add((byte)(Convert.ToByte(comboBox_Modulation.SelectedIndex)));
                msg.Add((byte)(Convert.ToByte(comboBox_DataRate.SelectedIndex)));

                msg.Add((byte)(Convert.ToByte(comboBox_Radio_Channel.SelectedItem.ToString())));

                msg.Add((byte)(radConv.S2LP_From_Dbm_To_Byte(float.Parse(comboBox_TxPower.SelectedItem.ToString()))));

                //calculating and adding CRC to the end of the built frame
                msgCRC = CRC_16_ARC.Crc16_ARC(msg.ToArray());
                msg.Add((byte)(msgCRC >> 8));
                msg.Add((byte)(msgCRC & 0x00FF));

                msg_type_sent = header_serial_data.msg_type;

                aTimer = new System.Timers.Timer();
                aTimer.Elapsed += OnTimedEvent_aTimer;

                aTimer.Interval = 3000;
                aTimer.Start();

                serialPort1.Write(textBox_Start_Frame_Char.Text + System.Convert.ToBase64String(msg.ToArray()) + textBox_Stop_Frame_Char.Text);

            }
            catch
            {
                MessageBox.Show("Unable to send message!");
            }
        }

        private void button_Read_Radio_Data_Click(object sender, EventArgs e)
        {
            List<byte> msg = new List<byte>();
            UInt16 msgCRC = 0;

            try
            {
                //building message
                header_serial_data.origin_node = ComDef.HOST;
                header_serial_data.destination_node = Convert.ToByte(textBox_Identity_NodeID.Text);
                header_serial_data.send_time = ComDef.SECOND_SEND_TIME;
                header_serial_data.msg_type = ComDef.MSG_TYPE_RETRIEVE_RADIO_CONFIG;
                header_serial_data.payload_length = ComDef.MSG_TYPE_RETRIEVE_RADIO_CONFIG_LENGTH;

                //fill header
                msg.Add((byte)(header_serial_data.origin_node));
                msg.Add((byte)(header_serial_data.destination_node));
                msg.Add((byte)((header_serial_data.send_time) >> 8));
                msg.Add((byte)((header_serial_data.send_time) & 0x00FF));
                msg.Add((byte)((header_serial_data.msg_type) >> 8));
                msg.Add((byte)((header_serial_data.msg_type) & 0x00FF));
                msg.Add((byte)((header_serial_data.payload_length)));

                //calculating and adding CRC to the end of the built frame
                msgCRC = CRC_16_ARC.Crc16_ARC(msg.ToArray());
                msg.Add((byte)(msgCRC >> 8));
                msg.Add((byte)(msgCRC & 0x00FF));

                serialPort1.Write(textBox_Start_Frame_Char.Text + System.Convert.ToBase64String(msg.ToArray()) + textBox_Stop_Frame_Char.Text);
            }
            catch
            {
                MessageBox.Show("Unable execute read command!");
            }
        }
    }
}
