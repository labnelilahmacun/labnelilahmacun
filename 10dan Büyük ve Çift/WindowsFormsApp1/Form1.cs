using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sayı = Convert.ToInt16(textBox1.Text);
            if ( Sayı % 2 == 0) 
            {
                label1.Text = "Çift";
            }
         else
            {
                label1.Text = "Tek";
            }
            if (Sayı < 10)
            {
                label2.Text = "Tek Basamaklı";
            }
            if (Sayı >= 10&& Sayı == 99)
            {
                label2.Text = "Çift Basamaklı";
            }
            else
            {
                label2.Text = "Basamak Sayısı Hesaplanmadı";
            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
