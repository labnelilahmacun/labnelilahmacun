using System;
using System.Windows.Forms;

namespace _3ve4_ün_Katı
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
            int i;
            int toplam = 0;
            for (i = 1; i <= 100; i++)
            {
                if (radioButton1.Checked == true && i % 3 == 0)
                {
                    listBox1.Items.Add(i);
                    toplam = toplam + i;
                    label1.Text = toplam.ToString();
                }
                   
            }
            for (i = 1; i <= 100; i++)
            {
                if (radioButton2.Checked == true && i % 4 == 0)
                {
                    listBox1.Items.Add(i);
                    toplam = toplam + i;
                    label1.Text = toplam.ToString();
                }

                    
            }
        }
    }
}
