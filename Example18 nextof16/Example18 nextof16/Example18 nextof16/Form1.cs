using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example18_nextof16
{
    public partial class Form1 : Form
    {
        List<METER> abc = new List<METER>();
        List<METER> list_Meters = new List<METER>();
        List<METER> list_Meters_01 = new List<METER>();
        List<METER> list_Meters_01_soft = new List<METER>();

        List<METER> list_Meters_02 = new List<METER>();
        List<METER> list_Meters_03 = new List<METER>();
        List<METER> list_Meters_04 = new List<METER>();
        List<METER> list_Meters_05 = new List<METER>();
        List<METER> list_Meters_06 = new List<METER>();
        List<METER> list_Meters_07 = new List<METER>();
        int counter_layer01, counter_layer02, counter_layer03, counter_layer04, counter_layer05, counter_layer06, counter_layer07;
        DCU dCU = new DCU();

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setupDCU();
            Random_RSSI_Serial_METER();
            //Show_intoCosnole();
            //Filter();
        }
        void setupDCU()
        {            
            dCU.setSerial(30041975);
            dCU.setShortAddress(0xAA);
            dCU.setnwkScale(1024);
        }

        private void Soft_Click(object sender, EventArgs e)
        {
            Clear();
            Soft_list01();
        }

        void Random_RSSI_Serial_METER()
        {
            for (int i = 0; i < dCU.getnwkScale(); i++)
            {
                for (int j = i+ 1; j < dCU.getnwkScale(); j++)
                {
                    METER mETER = new METER(random.Next(19991999, 19993000), random.Next(150, 500));
                    list_Meters.Add(mETER);               
                }                              
            }
            for (int i = 0; i < dCU.getnwkScale(); i++)
            {
                for (int j = i+1 ; j < dCU.getnwkScale(); j++)
                {
                    if(list_Meters[i].getSerial_ofNode() == list_Meters[j].getSerial_ofNode())
                    {
                        listBox1.Items.Add("Trung tai "+i);
                        listBox1.Items.Add(list_Meters[i].getSerial_ofNode());
                        listBox1.Items.Add("Thay moi bang ");
                        list_Meters[i].setSerial_ofNode(random.Next(19991999, 19993000));
                        listBox1.Items.Add(list_Meters[i].getSerial_ofNode());

                    }
                }
            }          
        }

        private void display_Click(object sender, EventArgs e)
        {
            Filter();
            Show_intoCosnole();
        }

        void Show_intoCosnole()
        {           
            for (int i = 0; i < dCU.getnwkScale(); i++)
            {
                listBox1.Items.Add(list_Meters[i].getSerial_ofNode());
                listBox1.Items.Add(list_Meters[i].getRSSI_ofNode());
            }
            listBox9.Items.Add(dCU.getSerial());
            listBox9.Items.Add(dCU.getShortAddress());
        }
        void Filter()
        {
            for (int i = 0; i < dCU.getnwkScale(); i++)
            {
                if (list_Meters[i].getRSSI_ofNode() >= 450)
                {
                    counter_layer01 = counter_layer01 + 1;
                    list_Meters[i].setRadius_ofNode(1);
                    listBox2.Items.Add(list_Meters[i].getSerial_ofNode());
                    //listBox2.Items.Add(list_Meters[i].getRSSI_ofNode());
                    // copy to list other
                    list_Meters_01.Add(list_Meters[i]);
                    // set Radius of layer
                    //list_Meters_01[i].setRadius_ofNode(1);
                   
                }
                if ((list_Meters[i].getRSSI_ofNode() >= 400) &&(list_Meters[i].getRSSI_ofNode() < 450))
                {
                    counter_layer02 = counter_layer02 + 1;
                    list_Meters[i].setRadius_ofNode(2);
                    listBox3.Items.Add(list_Meters[i].getSerial_ofNode());
                    //listBox3.Items.Add(list_Meters[i].getRSSI_ofNode());
                    list_Meters_02.Add(list_Meters[i]);
                    //list_Meters_02[i].setRadius_ofNode(2);

                }
                if ((list_Meters[i].getRSSI_ofNode() >= 350) &&(list_Meters[i].getRSSI_ofNode() < 400))
                {
                    counter_layer03 = counter_layer03 + 1;
                    list_Meters[i].setRadius_ofNode(3);

                    listBox4.Items.Add(list_Meters[i].getSerial_ofNode());
                    //listBox4.Items.Add(list_Meters[i].getRSSI_ofNode());
                    list_Meters_03.Add(list_Meters[i]);
                    //list_Meters_03[i].setRadius_ofNode(3);

                }
                if ((list_Meters[i].getRSSI_ofNode() >= 300) &&(list_Meters[i].getRSSI_ofNode() < 350))
                {
                    counter_layer04 = counter_layer04 + 1;
                    list_Meters[i].setRadius_ofNode(4);

                    listBox5.Items.Add(list_Meters[i].getSerial_ofNode());
                    //listBox5.Items.Add(list_Meters[i].getRSSI_ofNode());
                    list_Meters_04.Add(list_Meters[i]);
                    //list_Meters_04[i].setRadius_ofNode(4);

                }
                if ((list_Meters[i].getRSSI_ofNode() >= 250) &&(list_Meters[i].getRSSI_ofNode() < 300))
                {
                    counter_layer05 = counter_layer05 + 1;
                    list_Meters[i].setRadius_ofNode(5);

                    listBox6.Items.Add(list_Meters[i].getSerial_ofNode());
                    //listBox6.Items.Add(list_Meters[i].getRSSI_ofNode());
                    list_Meters_05.Add(list_Meters[i]);
                    //list_Meters_05[i].setRadius_ofNode(5);
                }
                if ((list_Meters[i].getRSSI_ofNode() < 250) && (list_Meters[i].getRSSI_ofNode() >= 200))
                {
                    counter_layer06 = counter_layer06 + 1;
                    list_Meters[i].setRadius_ofNode(6);

                    listBox7.Items.Add(list_Meters[i].getSerial_ofNode());
                    //listBox7.Items.Add(list_Meters[i].getRSSI_ofNode());
                    list_Meters_06.Add(list_Meters[i]);
                    //list_Meters_06[i].setRadius_ofNode(6);
                }
                if(list_Meters[i].getRSSI_ofNode() < 200)
                {
                    counter_layer07 = counter_layer07 + 1;
                    list_Meters[i].setRadius_ofNode(7);

                    listBox8.Items.Add(list_Meters[i].getSerial_ofNode());
                    //listBox8.Items.Add(list_Meters[i].getRSSI_ofNode());
                    list_Meters_07.Add(list_Meters[i]);
                }
            }
            textBox1.Text = "Node: "+ counter_layer01.ToString() + " Radius " + list_Meters_01[0].getRadius_ofNode().ToString(); 
            //textBox1.Text = list_Meters_01[0].getRadius_ofNode().ToString();
            textBox2.Text = "Node: " + counter_layer02.ToString() + " Radius " + list_Meters_02[0].getRadius_ofNode().ToString(); ;
            textBox3.Text = "Node: " + counter_layer03.ToString() + " Radius " + list_Meters_03[0].getRadius_ofNode().ToString(); ;
            textBox4.Text = "Node: " + counter_layer04.ToString() + " Radius " + list_Meters_04[0].getRadius_ofNode().ToString(); ;
            textBox5.Text = "Node: " + counter_layer05.ToString() + " Radius " + list_Meters_05[0].getRadius_ofNode().ToString(); ;
            textBox6.Text = "Node: " + counter_layer06.ToString() + " Radius " + list_Meters_06[0].getRadius_ofNode().ToString(); ;
            textBox8.Text = "Node: " + counter_layer07.ToString() + " Radius " + list_Meters_07[0].getRadius_ofNode().ToString(); ;
            textBox7.Text = "Node: " + dCU.getnwkScale().ToString();
        }
        void Clear()
        {
            // Clear all display in listBox[i]
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            // soft all list_Meter copy

            // Soft list_Meters_01
            // soft max to min of list_Meter[i]
        }
        void Soft_list01()
        {                   
            Console.WriteLine(list_Meters_01.Count);
            // soft all node
            for (int i = 0; i < list_Meters_01.Count; i++)
            {
                for (int j = 0; j < list_Meters_01.Count; j++)
                {
                    if (list_Meters_01[i].getRSSI_ofNode() < list_Meters_01[j].getRSSI_ofNode())
                    {
                        list_Meters_01_soft[i] = list_Meters_01[i];
                        list_Meters_01[i] = list_Meters_01[j];
                        list_Meters_01[j] = list_Meters_01_soft[i];
                    }
                }
            }
            for (int i = 0; i < list_Meters_01.Count; i++)
            {
                listBox9.Items.Add(list_Meters_01[i].getSerial_ofNode());
            }
        }
        void The_way_walk_to_DCU()
        {

        }
        #region
        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


    }
}
