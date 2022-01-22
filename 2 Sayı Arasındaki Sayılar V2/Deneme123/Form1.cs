using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme123
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
            if (sayi1<sayi2)
            for (int i = sayi1; i <= sayi2; i++)
            {
                listBox1.Items.Add(i);
            }
            else
            for(int ğ = sayi1; ğ >= sayi2; ğ--)
            {
                listBox1.Items.Add(ğ);
            }
        }
    }
}
