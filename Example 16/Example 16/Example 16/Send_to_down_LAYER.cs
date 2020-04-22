using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_16
{
    class Send_to_down_LAYER
    {
        public static int[] Buffer_DCU_send = new int[10];
        public static int[] DCU_send_down_Layer()
        {
            /*
             * Gửi các thông số được cài đặt như
             * PanID
             * Ngưỡng RSSI
             * DestAddress cho lần đầu khởi tạo mạng
             * Địa chỉ của DCU
             * nwkScale
             */         
            DCU.nwkScale = 0x0400;
            DCU.PanID = 0xABCD;

            Buffer_DCU_send[0] = DCU.nwkScale;
            Buffer_DCU_send[1] = DCU.nwkScale;
            Buffer_DCU_send[2] = DCU.nwkScale;
            Buffer_DCU_send[3] = DCU.nwkScale;
            return Buffer_DCU_send;
        }
        void Config_data()
        {
            // Đoc các giá trị được gửi bởi METER random ra các giá trị RSSI và Serial ra và tiến hành config
        }
    }
}
