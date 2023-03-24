using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZİGZAG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 1; i <= 200; i++)
            {


                if (i % 3 == 0)
                {
                    listBox1.Items.Add(i + "ZİG");
                }
                if (i % 5 == 0)
                {

                    listBox1.Items.Add(i + "ZAG");
                }
                if (i % 3 == 0 && i % 5 == 0)
                {

                    listBox1.Items.Add(i + "ZİGZAG");
                }
                if (i % 3 == 0 && i % 5 == 0)
                {

                    listBox1.Items.Add(i + "ZİGZAG");
                }
                sayac++;
            }
        }
    }
}
