using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Sayı_Arasındaki_Sayılar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            for(int i =sayi1;i<=sayi2;i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int sayi3 = Convert.ToInt32(textBox3.Text);
            int sayi4 = Convert.ToInt32(textBox4.Text);
            for (int ğ = sayi4; ğ >= sayi3; ğ--)
            {
                listBox2.Items.Add(ğ);
            }
        }
    }
}
