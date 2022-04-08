using BMI_Hesaplayıcı.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Hesaplayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            txtboy.Focus();

        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            double boy, kilo,sonuc;

            boy = double.Parse(txtboy.Text);
            kilo = double.Parse(txtkilo.Text);

            sonuc = kilo / Math.Pow(boy / 100, 2);

            listBox1.Items.Add(sonuc.ToString("n2"));

            if (sonuc<=18.15)
            {
                zayif.Image = Resources.tik;

            }
            else if (sonuc>=18.5 && sonuc<25)
            {
                saglikli.Image = Resources.tik;
            }
            else if (sonuc>=25 && sonuc<30)
            {
                kilolu.Image = Resources.tik;
            }
            else if (sonuc>=30 && sonuc<40)
            {
                sisman.Image= Resources.tik;
            }
            else
            {
                assisman.Image= Resources.tik;
            }


        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtboy.Text = " ";
            txtkilo.Text = " ";
            listBox1.Items.Clear();
            zayif.Image = Resources.carpi;
            saglikli.Image = Resources.carpi;
            kilolu.Image = Resources.carpi;
            sisman.Image = Resources.carpi;
            assisman.Image = Resources.carpi;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
