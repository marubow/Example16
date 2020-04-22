using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_16
{
    class Send_to_up_LAYER
    {
       
        public  List<METER> list_Meter = new List<METER>();
        //public  List<METER> list_coppy_Layer01 = new List<METER>();
        public List<METER> CopyLayer01 = new List<METER>();
        public List<METER> CopyLayer02 = new List<METER>();
        public List<METER> CopyLayer03 = new List<METER>();
        public List<METER> CopyLayer04 = new List<METER>();
        public List<METER> CopyLayer05 = new List<METER>();

        Random rand = new Random();
        public void Creat_random_RSSI_Serial()
        {
            for(int i = 0; i < METER.Quantity_number_node; i++)
            {
                METER mETER = new METER(rand.Next(150, 500), rand.Next(19991999, 19993000));
                list_Meter.Add(mETER);               
            }           
        }
        public void Creat_random_RSSI_Serial_fix()
        {
            Send_to_up_LAYER sent = new Send_to_up_LAYER();
            Creat_random_RSSI_Serial();
            for(int i = 0; i < METER.Quantity_number_node; i++)
            {
                for(int j =i +1; j < METER.Quantity_number_node; j++)
                {
                    if(sent.list_Meter[i].getSerial() == sent.list_Meter[j].getSerial())
                    {
                        Console.WriteLine(sent.list_Meter[i].getSerial());
                    }
                }
            }
        }
    }
}
