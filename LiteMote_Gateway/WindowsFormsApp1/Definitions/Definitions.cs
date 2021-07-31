using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Definitions
{
    public class ComDef
    {
        public const int INDEX_HEADER_ORIGIN_ADDRESS       = 0;
        public const int INDEX_HEADER_DESTINATION_ADDRESS  = 1;
        public const int INDEX_HEADER_SEND_TIME_MSB        = 2;
        public const int INDEX_HEADER_SEND_TIME_LSB        = 3;
        public const int INDEX_HEADER_MSG_TYPE_MSB         = 4;
        public const int INDEX_HEADER_MSG_TYPE_LSB         = 5;
        public const int INDEX_HEADER_PAYLOAD              = 6;

        public const int HOST = 0;
        public const int SECOND_SEND_TIME = 1050; //ms

        public const int MSG_TYPE_PING = 1;

        public const int MSG_TYPE_RETRIEVE_IDENTITY                     = 2;
        public const int MSG_TYPE_RETRIEVE_IDENTITY_PAYLOAD_LENGTH      = 0;

        public const int MSG_TYPE_SEND_IDENTITY                         = 3;
        public const int MSG_TYPE_SEND_IDENTITY_PAYLOAD_LENGTH          = 12;

        public const int MSG_TYPE_RETRIEVE_HEALTH                       = 4;
        public const int MSG_TYPE_RETRIEVE_HEALTH_PAYLOAD_LENGHT        = 0;

        public const int MSG_TYPE_SEND_HEALTH                           = 5;
        public const int MSG_TYPE_SEND_HEALTH_PAYLOAD_LENGHT            = 8;

        public const int MSG_TYPE_SEND_HEALTH_CONF                      = 6;
        public const int MSG_TYPE_SEND_HEALTH_CONF_PAYLOAD_LENGHT       = 2;

        public const int MSG_TYPE_RETRIEVE_ADC_CAL                      = 7;
        public const int MSG_TYPE_RETRIEVE_ADC_CAL_LENGTH               = 0;

        public const int MSG_TYPE_SEND_ADC_CAL                          = 8;
        public const int MSG_TYPE_SEND_ADC_CAL_LENGTH                   = 6;

        public const int MSG_TYPE_RETRIEVE_RADIO_CONFIG                 = 9;
        public const int MSG_TYPE_RETRIEVE_RADIO_CONFIG_LENGTH          = 0;

        public const int MSG_TYPE_SEND_RADIO_CONFIG                     = 10;
        public const int MSG_TYPE_SEND_RADIO_CONFIG_LENGTH              = 5;

        public const int MSG_TYPE_ACK                                   = 254;
        public const int MSG_TYPE_ACK_PAYLOAD_LENGTH                    = 2;

        public const int MAX_TX_POWER_VALUES                            = 89;
        public const int MAX_TX_POWER                                   = 14;
        public const int MIN_TX_POWER                                   = -30;
    }
}
