
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
{
    class Metre
    {
        public int RSSI;
        public int Serial_of_Node;
        public static int Layer;
        public static int Time_slot;
        public static int Quantity_number_node = 15;
        public static int Row;
        public static int Columns = 7;
        public Metre(int RSSI, int Serial_of_Node)
        {
            this.RSSI = RSSI;
            this.Serial_of_Node = Serial_of_Node;
        }

        public void setSerial(int x)
        {
            Serial_of_Node = x;
        }

        public int getSerial()
        {
            return Serial_of_Node;
        }

        public void setRSSI(int x)
        {
            RSSI = x;
        }

        public int getRSSI()
        {
            return RSSI;
        }
    }
}
