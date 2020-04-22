using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
{
    public partial class Form1 : Form
    {
        List<Metre> list = new List<Metre>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            randomabc();
        }
        void randomabc()
        {
            Random rd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                Metre metre = new Metre(rd.Next(1, 100), rd.Next(1, 100));// sao
                list.Add(metre);
            }
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(list[i].getRSSI());
            }
        }
    }
}
