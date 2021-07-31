using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1.frame_header
{
    //packing struct 
    [StructLayout(LayoutKind.Sequential,Pack = 1)]
    public struct Header
    {
        public byte origin_node;
        public byte destination_node;
        public ushort send_time;
        public ushort msg_type;
        public byte payload_length;
    }
}
