using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example18_nextof16
{
    class DCU
    {
        // Các thông số cần thiết để khởi tạo các giá trị của mạng '
        public static int nwkScale;
        public static int Serial;
        public static int ShortAddress;
        public static int RSSI;
        public static int[] Path_toNode;
        public void setSerial(int x)
        {
            Serial = x;
        }
        public int getSerial()
        {
            return Serial;
        }
        public void setShortAddress(int x)
        {
            ShortAddress = x;
        }
        public int getShortAddress()
        {
            return ShortAddress;
        }
        public void setnwkScale(int x)
        {
            nwkScale = x;
        }
        public int getnwkScale()
        {
            return nwkScale;
        }
        
    }
}
