using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_16
{
    class DCU
    {
        public static string[] Path_DCU_to_MEETER;
        public static int Serial_of_DCU = 30041975;
        public static int PanID  = 0xABCD;
        public static int ShortAdress  = 0xAA;

        public static int RSSI_Theshold_Layer01 = 100;
        public static int RSSI_Theshold_Layer02 = 120;
        public static int RSSI_Theshold_Layer03 = 150;
        public static int RSSI_Theshold_Layer04 = 170;
        public static int RSSI_Theshold_Layer05 = 190;
        public static int RSSI_Theshold_Layer06 = 210;
        public static int RSSI_Theshold_Layer07 = 250;

        public static int Radius_layer_01 = 1;
        public static int Radius_layer_02 = 2;
        public static int Radius_layer_03 = 3;
        public static int Radius_layer_04 = 4;
        public static int Radius_layer_05 = 5;
        public static int Radius_layer_06 = 6;
        public static int Radius_layer_07 = 7;

        public static int nwkScale = 0x0400;
        public UInt64 DestAddress = 0xFFFFFFFFFFFF;
        public static int SourceAddress = 0xFF;
        public void setSerial(int x)
        {
            Serial_of_DCU = x;
        }
        public int getSerial()
        {
            return Serial_of_DCU;
        }
        public void setDestAddress(UInt64 x)
        {
            DestAddress = x;
        }
        //public int getDestAddress()
        //{
        //    return DestAddress;
        //}
        //public DCU(int Serial_of_DCU, int DestAddress)
        //{
        //    this.Serial_of_DCU = Serial_of_DCU;
        //    this.DestAddress = DestAddress;
        //}
    }
}
