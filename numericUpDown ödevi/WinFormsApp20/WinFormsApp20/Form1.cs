using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double vize, final, sonuc;
                vize = Convert.ToInt32(numericUpDown1.Value);
                final = Convert.ToInt32(numericUpDown2.Value);
                if (vize <= 100 && final <= 100 )
                {
                    sonuc = (vize * 0.4) + (final * 0.6);
                    label3.Text = sonuc.ToString();
                    if (sonuc < 50 || final < 50)
                    {
                        label7.Text = "Kaldınız :(";

                    }
                    else
                    {
                        label7.Text = "Geçtiniz :)";

                    }
                    if (sonuc >= 0 && sonuc <= 49)
                    {
                        label4.Text = "FF";

                    }
                    else if (sonuc >= 50 && sonuc < 59)
                    {
                        label4.Text = "CC";

                    }
                    else if (sonuc > 59 && sonuc <= 69)
                    {
                        label4.Text = "CB";

                    }
                    else if (sonuc > 69 && sonuc <= 79)
                    {
                        label4.Text = "BB";

                    }
                    else if (sonuc > 79 && sonuc <= 89)
                    {
                        label4.Text = "BA";

                    }
                    else if (sonuc > 90 && sonuc <= 100)
                    {
                        label4.Text = "AA";

                    }
                    if (sonuc >= 50 && final >= 50)
                    {
                        label4.ForeColor = Color.Green;
                        label7.ForeColor = Color.Green;
                    }
                    else
                    {
                        label4.ForeColor = Color.Red;
                        label7.ForeColor = Color.Red;
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"bir hata oluştu\n{ex.Message}\n{ex.Data}");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
