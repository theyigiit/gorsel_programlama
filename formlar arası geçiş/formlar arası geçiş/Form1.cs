using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlar_arası_geçiş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.label4.Text = textBox1.Text;
            double s1 = Convert.ToDouble(textBox2.Text);
            double s2 = Convert.ToDouble(textBox3.Text);
            double s3 = Convert.ToDouble(textBox4.Text);
            double hesapla = (s1 + s2 + s3) / 3;
            frm2.label5.Text = Convert.ToString(hesapla);
            if (hesapla<50)
            {
                frm2.label6.Text = "kaldın";
                frm2.label6.ForeColor = Color.Red;
            }
            else
            {
                frm2.label6.Text = "geçtin";
                frm2.label6.ForeColor = Color.Green;
            }
            frm2.ShowDialog();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
