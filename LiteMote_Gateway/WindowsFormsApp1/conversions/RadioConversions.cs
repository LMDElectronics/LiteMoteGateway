using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsFormsApp1.Definitions;

namespace WindowsFormsApp1.conversions
{
    class RadioConversions
    {
        public byte S2LP_From_Dbm_To_Byte(float data)
        {
            byte i = 0;            
            byte retVal = 0;
            float value = ComDef.MIN_TX_POWER;
            List<float> byteTable = new List<float>();

            //clamping max and min values
            if (data <= ComDef.MIN_TX_POWER) data = ComDef.MIN_TX_POWER;
            if (data >= ComDef.MAX_TX_POWER) data = ComDef.MAX_TX_POWER;

            //creating table 
            for (i = 0; i < ComDef.MAX_TX_POWER_VALUES; i++)
            {
                byteTable.Add(value);
                value = value + (float)0.5;                
            }

            //checking the closest value to data to return the index            
            for(i=0; i < byteTable.Count; i++)
            {
                if( i < byteTable.Count - 1)
                {
                    if ((data >= byteTable[i]) && ((data < byteTable[i + 1])))
                    {
                        retVal = i;
                        break;
                    }
                }
                else
                {
                    retVal = (byte)(byteTable.Count - 1);
                    break;
                }
            }

            return retVal;
        }

        public float S2LP_From_Byte_To_dBm(byte data)
        {
            byte i = 0;
            List<float> byteTable = new List<float>();
            float value = ComDef.MIN_TX_POWER;

            //creating table 
            for (i = 0; i < ComDef.MAX_TX_POWER_VALUES; i++)
            {
                byteTable.Add(value);
                value = value + (float)0.5;
            }

            return byteTable[data];
        }
    }
}

