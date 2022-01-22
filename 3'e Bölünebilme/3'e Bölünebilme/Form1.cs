using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_e_Bölünebilme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                listBox1.Items.Clear();
                int c, d;
                c = Convert.ToInt32(textBox1.Text);
                for (d = 0; d<= c;d=d +3)
                {
                    listBox1.Items.Add(d);
                }
            }
            if (radioButton2.Checked == true)
            {
                listBox1.Items.Clear();
                int a, b;
                a = Convert.ToInt32(textBox1.Text);
                for (b = 0; b <= a; b = b +5)
                {
                    listBox1.Items.Add(b);
                }
            }
            if (radioButton3.Checked == true)
            {
                listBox1.Items.Clear();
                int g, f;
                g = Convert.ToInt32(textBox1.Text);
                for (f = 0; f <= g; f = f + 9)
                {
                    listBox1.Items.Add(f);
                }
            }
        }
    }
}
