using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example18_nextof16
{
    class METER
    {
        public  int Serial_ofNode;
        public  int RSSI_ofNode;
        public  int Radius_ofNode;
        public  int DestAddress;
        public static int a;
        public int[] Path_toDCU;
       
        public void setSerial_ofNode(int x)
        {
            Serial_ofNode = x;
        }
        public int getSerial_ofNode()
        {
            return Serial_ofNode;
        }
        public void setRSSI_ofNode(int x)
        {
            RSSI_ofNode = x;
        }
        public int getRSSI_ofNode()
        {
            return RSSI_ofNode;
        }
        public void setRadius_ofNode(int x)
        {
            Radius_ofNode = x;
        }
        public int getRadius_ofNode()
        {
            return Radius_ofNode;
        } 
        public METER(int x, int y)
        {
            this.Serial_ofNode = x;
            this.RSSI_ofNode = y;
        }
        public void setDestAddress(int x)
        {
            DestAddress = x;
        }
        public int getDestAddress()
        {
            return DestAddress;
        }

       
    }
}
