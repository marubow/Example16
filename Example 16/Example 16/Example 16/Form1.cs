using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // list tổng các node ban đầu.
        Send_to_up_LAYER abc = new Send_to_up_LAYER();
       

        List<METER> listtt = new List<METER>();
     

        
        Send_to_up_LAYER copy_layer01 = new Send_to_up_LAYER();
        
        public static int count_layer01;
        public static int count_layer02;
        public static int count_layer03;
        public static int count_layer04;
        public static int count_layer05;
        public static int count_layer06;
        public static int count_layer07;
        public static int count_total;

        public static int[] Array_layer01 = new int[count_layer01];
        // Bảng đường đi của từng con tại một thời điểm
        public static int[,] Path_layer01 = new int[count_layer01, 2];
        public static int[,] Path_layer02 = new int[count_layer02, 2];
        public static int[,] Path_layer03 = new int[count_layer03, 3];
        public static int[,] Path_layer04 = new int[count_layer04, 4];
        public static int[,] Path_layer05 = new int[count_layer05, 5];
        public static int[,] Path_layer06 = new int[count_layer06, 6];
        public static int[,] Path_layer07 = new int[count_layer07, 7];

        public static string[,] Node_around_layer01 = new string[count_layer01, 2];
        public static string[,] Node_around_layer02 = new string[count_layer02, 2];
        public static string[,] Node_around_layer03 = new string[count_layer03, 2];
        public static string[,] Node_around_layer04 = new string[count_layer04, 2];
        public static string[,] Node_around_layer05 = new string[count_layer05, 2];
        public static string[,] Node_around_layer06 = new string[count_layer06, 2];
        public static string[,] Node_around_layer07 = new string[count_layer07, 2];
        private void Form1_Load(object sender, EventArgs e)
        {
            // gọi lên fuction
            abc.Creat_random_RSSI_Serial();
            if( count_total == 7)
            {
                button4.Enabled = false;
            }
        }       
        // Lọc các giá trị của list vừa tạo ra
        void Creat_random_RSSI_Serial_filter()
        {
            abc.Creat_random_RSSI_Serial();
            #region
            //for(int i = 0; i < METER.Quantity_number_node; i++)
            //{
            //    for(int j = i+ 1; j < METER.Quantity_number_node;j++)
            //    {
            //        if(abc.list_Meter[i].getSerial() != abc.list_Meter[j].getSerial())
            //        {
            //            // coppy những vị trí khác nhau của abc.list vào trong 1 mảng khác.
            //        }
            //    }
            //}    
            #endregion
        }
        // Tạo thành công các node Meter và lưu vào mảng
        private void button1_Click(object sender, EventArgs e)
        {
            
            // Hiển thị các giá trị
            for(int i = 0; i < METER.Quantity_number_node; i++)
            {
                Console.WriteLine(abc.list_Meter[i].getSerial());
                Console.WriteLine(abc.list_Meter[i].getRSSI());
            }
        }
        void Filter_Layer()
        {
            for(int i  = 0; i < METER.Quantity_number_node; i++)
            {
              
                if(abc.list_Meter[i].getRSSI() < DCU.RSSI_Theshold_Layer01)
                {
                    Console.WriteLine(abc.list_Meter[i].getSerial());
                    Console.WriteLine(abc.list_Meter[i].getRSSI());
                }    
            }
        }
        void Filter_else()
        {
            for (int i = 0; i < METER.Quantity_number_node; i++)
            {
                if (abc.list_Meter[i].getRSSI() < DCU.RSSI_Theshold_Layer01)
                {
                    Console.WriteLine(abc.list_Meter[i].getSerial());
                    Console.WriteLine(abc.list_Meter[i].getRSSI());
                }
            }
        }
        #region
        private void button2_Click(object sender, EventArgs e)
        {
            Filter_Layer();
            Console.WriteLine("Cac gia tri con lai la: ");
            Filter_else();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            // hien thi cac gia tri cua DCU
            DCU dcu = new DCU();
            listBox1.Items.Add("PanID  " + DCU.PanID);
            listBox1.Items.Add("Source " + DCU.SourceAddress);
            listBox1.Items.Add("Serial " + DCU.Serial_of_DCU);
            listBox1.Items.Add("Nodelist " + METER.Quantity_number_node);
            //for (int i = 0; i < METER.Quantity_number_node; i++)
            //{
            //    listBox2.Items.Add(abc.list_Meter[i].getSerial());
            //    //listBox2.Items.Add(abc.list_Meter[i].getRSSI());
            //}
            Random randdnnd = new Random();
            for (int i = 0; i < METER.Quantity_number_node; i++)
            {               
                for (int j =i +1; j < METER.Quantity_number_node; j++)
                {                    
                    if (abc.list_Meter[i].getSerial() == abc.list_Meter[j].getSerial())
                    {
                        
                        Console.WriteLine("Serial trùng là : "+i+" " + abc.list_Meter[i].getSerial());
                        abc.list_Meter[i].setSerial(randdnnd.Next(19992000,19993000));
                        Console.WriteLine("Serial sau khi sua la " + abc.list_Meter[i].getSerial());
                        //abc.list_Meter[j].setSerial(randdnnd.Next(19992000, 19993000));
                        // Lưu lại lsist giá tr                      
                    }
                }              
            }
            for (int i = 0; i < METER.Quantity_number_node; i++)
            {
                listBox2.Items.Add(abc.list_Meter[i].getSerial());
                listBox2.Items.Add(abc.list_Meter[i].getRSSI());
            }
            btnBegin.Enabled = false;
            textBox1.Text = "Cài đặt DCU và khởi tạo Meter";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            //btn1();
            btn1_test();
            count_total = 1;
        }
        void btn1()
        {
           
            for (int i = 0; i < METER.Quantity_number_node; i++ )
            {
                if(abc.list_Meter[i].getRSSI() > 450)
                {
                    count_layer01 = count_layer01 + 1;
                    //listBox3.Items.Add("So " + i);
                    // hiển thị ra listbox
                    listBox3.Items.Add(abc.list_Meter[i].getSerial());
                    //listBox3.Items.Add(abc.list_Meter[i].getRSSI());
                    // lưu vào mảng khác.
                }                
            }
            listBox3.Items.Add("So " + count_layer01);
            textBox2.Text = "So Node :" + count_layer01.ToString();
            button3.Enabled = false;

        }
        void btn1_test()
        {
            for (int i = 0; i < METER.Quantity_number_node; i++)
            {
                if (abc.list_Meter[i].getRSSI() > 450)
                {
                    // đếm số lượng phần tử có RSSI > 450
                    count_layer01 = count_layer01 + 1;                   
                    // hiển thị ra listbox
                    listBox3.Items.Add(abc.list_Meter[i].getSerial());
                    //listBox3.Items.Add(abc.list_Meter[i].getRSSI()); 
                    abc.CopyLayer01.Add(abc.list_Meter[i]);
                }
            }
            #region
            //for (int i = 0; i < METER.Quantity_number_node; i++)
            //{
            //    if (abc.list_Meter[i].getRSSI() > 450)
            //    {
            //        // copy into copylayer01 and display listbox10
            //        abc.CopyLayer01.Add(abc.list_Meter[i]);
            //    }
            //}
            // Sap xep cac gia tri RSSI
            #endregion

            for (int i = 0; i < count_layer01; i++)
            {
                listBox10.Items.Add(abc.CopyLayer01[i].getRSSI());
            }
           
            listBox3.Items.Add("So " + count_layer01);
            textBox2.Text = "So Node :" + count_layer01.ToString();
            button3.Enabled = false;

        }
        #region
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion
     

        private void button4_Click(object sender, EventArgs e)
        {
            btnall();
            button4.Enabled = false;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            btn5();
            count_total = count_total + 1;
        }
        void btn5()
        {
            for (int i = 0; i < METER.Quantity_number_node; i++)
            {
                if ((abc.list_Meter[i].getRSSI() >= 400) && (abc.list_Meter[i].getRSSI() < 450))
                {
                    count_layer02 = count_layer02 + 1;
                    //listBox3.Items.Add("So " + i);
                    // hiển thị
                    listBox4.Items.Add(abc.list_Meter[i].getSerial());
                    //listBox4.Items.Add(abc.list_Meter[i].getRSSI());
                    // lưu vào mảng khác.
                }

            }
            listBox4.Items.Add("So " + count_layer02);
            textBox3.Text = "So Node :" + count_layer02.ToString();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
            btn6();
            count_total = count_total + 1;
        }
        void btn6()
        {
            for (int i = 0; i < METER.Quantity_number_node; i++)
            {
                if ((abc.list_Meter[i].getRSSI() >= 350) && (abc.list_Meter[i].getRSSI() < 400))
                {
                    count_layer03 = count_layer03 + 1;
                    //listBox3.Items.Add("So " + i);
                    // hiển thị
                    listBox5.Items.Add(abc.list_Meter[i].getSerial());
                    //listBox5.Items.Add(abc.list_Meter[i].getRSSI());
                    // lưu vào mảng khác.
                }

            }
            listBox5.Items.Add("So " + count_layer03);
            textBox4.Text = "So Node :" + count_layer03.ToString();
            button6.Enabled = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
            btn7();
            count_total = count_total + 1;
        }
        void btn7()
        {
            for (int i = 0; i < METER.Quantity_number_node; i++)
            {
                if ((abc.list_Meter[i].getRSSI() >= 300) && (abc.list_Meter[i].getRSSI() < 350))
                {
                    count_layer04 = count_layer04 + 1;
                    //listBox3.Items.Add("So " + i);
                    // hiển thị
                    listBox6.Items.Add(abc.list_Meter[i].getSerial());
                    //listBox6.Items.Add(abc.list_Meter[i].getRSSI());
                    // lưu vào mảng khác.
                }

            }
            listBox6.Items.Add("So " + count_layer04);
            textBox5.Text = "So Node :" + count_layer04.ToString();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox7.Items.Clear();
            btn8();
            count_total = count_total + 1;
        }
        void btn8()
        {
            for (int i = 0; i < METER.Quantity_number_node; i++)
            {
                if ((abc.list_Meter[i].getRSSI() >= 250) && (abc.list_Meter[i].getRSSI() < 300))
                {
                    count_layer05 = count_layer05 + 1;
                    //listBox3.Items.Add("So " + i);
                    // hiển thị
                    listBox7.Items.Add(abc.list_Meter[i].getSerial());
                    //listBox7.Items.Add(abc.list_Meter[i].getRSSI());
                    // lưu vào mảng khác.
                }

            }
            listBox7.Items.Add("So " + count_layer05);
            textBox6.Text = "So Node :" + count_layer05.ToString();
            button8.Enabled = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            listBox8.Items.Clear();
            btn9();
            count_total = count_total + 1;
        }
        void btn9()
        {
            for (int i = 0; i < METER.Quantity_number_node; i++)
            {
                if ((abc.list_Meter[i].getRSSI() >= 200) && (abc.list_Meter[i].getRSSI() < 250))
                {
                    count_layer06 = count_layer06 + 1;
                    //listBox3.Items.Add("So " + i);
                    // hiển thị
                    listBox8.Items.Add(abc.list_Meter[i].getSerial());
                    //listBox8.Items.Add(abc.list_Meter[i].getRSSI());
                    // lưu vào mảng khác.
                }

            }
            listBox8.Items.Add("So " + count_layer06);
            textBox7.Text = "So Node :" + count_layer06.ToString();
            button9.Enabled = false;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            listBox9.Items.Clear();
            btn10();
            count_total = count_total + 1;
        }
        void btn10()
        {
            for (int i = 0; i < METER.Quantity_number_node; i++)
            {
                if ((abc.list_Meter[i].getRSSI() >= 150) && (abc.list_Meter[i].getRSSI() < 200))
                {
                    count_layer07 = count_layer07 + 1;
                    //listBox3.Items.Add("So " + i);
                    // hiển thị
                    listBox9.Items.Add(abc.list_Meter[i].getSerial());
                    //listBox9.Items.Add(abc.list_Meter[i].getRSSI());
                    // lưu vào mảng khác.
                }

            }
            listBox9.Items.Add("So " + count_layer07);
            textBox8.Text = "So Node :" + count_layer07.ToString();
            button10.Enabled = false;
        }
        
        void btnall()
        {
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            btn1();
            btn5();
            btn7();
            btn6();
            btn8();
            btn9();
            btn10();

        }
        #endregion
        #region
        void Filt_layer_01()
        {
            // connect with DCU;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        void Copy_and_fill_Path_Layer01()
        {
            for (int i = 0; i < count_layer01; i++)
            {
                    // Đường dẫn gồm hai thành phần và copy tất cả đường dẫn đã được lưu vào trong mảng [count_layer01, 2]
                    Path_layer01[i, 0] = DCU.ShortAdress;
                    Path_layer01[i, 1] = abc.CopyLayer01[i].getSerial();              
            }
        }
        void Copy_and_fill_Path_Layer02()
        {
             
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < METER.Quantity_number_node; i++)
            {
                if (abc.list_Meter[i].getRSSI() > 450)
                {
                    // đếm số lượng phần tử có RSSI > 450
                    count_layer01 = count_layer01 + 1;
                    // hiển thị ra listbox
                    listBox3.Items.Add(abc.list_Meter[i].getSerial());
                    abc.CopyLayer01.Add(abc.list_Meter[i]);
                }
            }     
            for (int i = 0; i < count_layer01; i++)
            {
                listBox10.Items.Add(abc.CopyLayer01[i].getRSSI());
            }
            listBox3.Items.Add("So " + count_layer01);
            textBox2.Text = "So Node :" + count_layer01.ToString();
            button3.Enabled = false;
            // sắp xếp các giá trị của abc.CopyLayer01;
            string temp;
            for (int i = 0; i < count_layer01; i++)
            {
                for (int j = 0; j < count_layer01; j++)
                {
                    if (abc.CopyLayer01[i].getRSSI() < abc.CopyLayer01[j].getRSSI())
                    {
                        temp = abc.CopyLayer01[i].getRSSI().ToString();
                        //DecoupeTableau(abc.CopyLayer01[i], abc.CopyLayer02[j]);
                    }
                }              
            }
        }
        static void DecoupeTableau(IList<int> dst, IEnumerable<int> src)
        {
            int i = 0;
            foreach (var value in src.Take(4))
            {
                dst[i] = value;
                i++;
            }
        }
    }
}
