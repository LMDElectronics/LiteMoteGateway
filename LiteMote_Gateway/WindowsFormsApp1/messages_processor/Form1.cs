using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;

using WindowsFormsApp1.Definitions;
using WindowsFormsApp1.conversions;

namespace WindowsFormsApp1
{
    public partial class Form1
    {
        private void OnTimedEvent_bTimer(Object source, System.Timers.ElapsedEventArgs e)
        {
            bTimer.Stop();
            bTimer.Elapsed -= OnTimedEvent_bTimer;
            bTimer.Dispose();

            SetText("", Color.LightYellow);
        }

        public void Process_messages_Rx(List<byte> payload, ushort msgType)
        {
            ushort ackPayload = 0;             

            //process the message received
            switch (msgType)
            {

                case ComDef.MSG_TYPE_RETRIEVE_IDENTITY:
                    
                    break;

                case ComDef.MSG_TYPE_SEND_IDENTITY:

                    textBox_Identity_NodeID.Text = ((payload[0] << 8) + payload[1]).ToString(); 
                    textBox_Identity_Node_Type.Text = ((payload[2] << 8) + payload[3]).ToString(); 
                    textBox_Identity_FW_Ver.Text = payload[4].ToString() + '.' + payload[5].ToString(); 
                    textBox_Identity_FW_CRC.Text = ((payload[6] << 8) + payload[7]).ToString(); 
                    textBox_Identity_HW_Version.Text = payload[8].ToString() + '.' + payload[9].ToString(); 
                    textBox_Identity_Hw_Case.Text = payload[10].ToString() + '.' + payload[11].ToString(); 

                    break;

                case ComDef.MSG_TYPE_SEND_HEALTH_CONF:

                    break;

                case ComDef.MSG_TYPE_SEND_HEALTH:

                    textBox_CPU_Voltage.Text = payload[0].ToString() + '.' + payload[1].ToString();
                    textBox_Battery_Voltage.Text = payload[2].ToString() + '.' + payload[3].ToString();
                    textBox_Temperature.Text = (((sbyte)(payload[4])).ToString() + '.' + payload[5].ToString());
                    textBox_Tx_period.Text = ((payload[6] << 8) + (payload[7])).ToString();

                    break;

                case ComDef.MSG_TYPE_SEND_ADC_CAL:

                    textBox_ADC_Offset.Text = ((payload[0] << 8) + payload[1]).ToString("x2");
                    textBox_ADC_P_GAIN.Text = ((payload[2] << 8) + payload[3]).ToString("x2");
                    textBox_ADC_M_GAIN.Text = ((payload[4] << 8) + payload[5]).ToString("x2");

                    break;

                case ComDef.MSG_TYPE_SEND_RADIO_CONFIG:

                    RadioConversions radConv = new RadioConversions();

                    comboBox_Freq_Select.SelectedIndex  = payload[0];
                    comboBox_Modulation.SelectedIndex   = payload[1];
                    comboBox_DataRate.SelectedIndex     = payload[2];
                    comboBox_Radio_Channel.SelectedIndex = comboBox_Radio_Channel.FindStringExact((payload[3]).ToString());
                    comboBox_TxPower.SelectedIndex = comboBox_TxPower.FindStringExact((radConv.S2LP_From_Byte_To_dBm(payload[4])).ToString());

                    break;

                case ComDef.MSG_TYPE_ACK:

                    //stop aTimer ack has been received
                    aTimer.Stop();
                    aTimer.Elapsed -= OnTimedEvent_bTimer;
                    aTimer.Dispose();

                    ackPayload <<= payload[0];
                    ackPayload |= payload[1];

                    //which message sent has generated the ACK
                    switch (ackPayload)
                    {
                        case ComDef.MSG_TYPE_SEND_IDENTITY:
                            textBox_ACK_Received_Identity.BackColor = Color.YellowGreen;
                            textBox_ACK_Received_Identity.Text = "ACK RECEIVED!";
                            break;

                        case ComDef.MSG_TYPE_SEND_HEALTH_CONF:
                        case ComDef.MSG_TYPE_SEND_HEALTH:
                            textBox_ACK_Received_Health.BackColor = Color.YellowGreen;
                            textBox_ACK_Received_Health.Text = "ACK RECEIVED!";
                            break;

                        case ComDef.MSG_TYPE_SEND_ADC_CAL:
                            textBox_ACK_Received_ADC.BackColor = Color.YellowGreen;
                            textBox_ACK_Received_ADC.Text = "ACK RECEIVED!";
                            break;

                        case ComDef.MSG_TYPE_SEND_RADIO_CONFIG:
                            textBox_ACK_Received_Radio.BackColor = Color.YellowGreen;
                            textBox_ACK_Received_Radio.Text = "ACK RECEIVED!";
                            break;
                    }

                    bTimer = new System.Timers.Timer();
                    bTimer.Elapsed += OnTimedEvent_bTimer;

                    bTimer.Interval = 500;
                    bTimer.Start();

                    break;
            }                        
        }                            
    }
}
