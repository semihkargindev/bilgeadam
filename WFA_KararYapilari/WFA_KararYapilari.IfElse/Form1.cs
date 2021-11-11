using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KararYapilari.IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            string metin = txtYaziAlani.Text;

            if (metin == "admin")
            {
                MessageBox.Show("Hoşgeldin Sahip");
            }
            else
            {
                MessageBox.Show("Geçersiz Kullanıcı Adı!");
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtYaziAlani.Text);

            if (sayi < 0 )
            {
                MessageBox.Show("Not 0'dan Küçük Olamaz!");
            }
            else if  (sayi > 100)
            {
                MessageBox.Show("Not 100'den Büyük Olamaz!");
            }
            else
            {
                MessageBox.Show("Geçerli Bir Sayı Girdiniz! =>  [0]",sayi.ToString());
            }
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            int txtsayi = Convert.ToInt32(txtYaziAlani.Text);

         
            if (txtsayi % 2 == 0)
            {
                MessageBox.Show("Sayı Çifttir");
            }                     
            else
            {
                MessageBox.Show("Sayı Tektir");
            }

        }   

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            string txtsifre = txtYaziAlani.Text;

            if (txtsifre.Length >= 8)
            {
                MessageBox.Show("Geçerli Şifre");
            }
            else
            {
                MessageBox.Show("Şifreniz 8 Karekter Veya Daha Uzun Olmalı!");
            }
        }
    }
}
