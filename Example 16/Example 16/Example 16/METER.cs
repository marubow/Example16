using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_16
{
    class METER
    {
        public  int RSSI;
        public  int Serial_of_Node;
        public  int MAX;
        public static int Layer;
        public static int Time_slot;
        public static int Quantity_number_node = 150;
        public static int Row;
        public static int Columns = 7;
        public static int Radius;
        public int layerabc;
        public List<int> Path_to_DCU = new List<int>();
        #region
        public void setSerial(int x)
        {
            Serial_of_Node = x;
        }
        public int max()
        {
            return MAX;
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
        public int getRadius()
        {
            return Radius;
        }
        public void setRadius(int radius)
        {
            Radius = radius;
        }
        public METER(int RSSI, int Serial_of_Node)
        {
            this.RSSI = RSSI;
            this.Serial_of_Node = Serial_of_Node;            
        }
        public void METER_save_parament()
        {

        }
        public void Listening_any_Node()
        {

        }
        #endregion
        public void setLayer(int x)
        {
            layerabc = x;
        }
        public int getLayer()
        {
            return layerabc;
        }
    }
}
