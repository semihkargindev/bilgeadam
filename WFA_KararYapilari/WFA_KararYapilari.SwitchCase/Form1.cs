using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KararYapilari.SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeger2_Click(object sender, EventArgs e)
        {
            string mevsim = txtGelenDeger1.Text.ToLower();
            switch(mevsim)
            {
                case "yaz": { MessageBox.Show("Haziran - Temmuz - Ağustos"); break; }

                case "kış": { MessageBox.Show("Aralık - Ocak - Şubat"); break; }

                case "sonbahar": { MessageBox.Show("Eylül - Ekim - Kasım"); break; }

                case "ilkbahar": { MessageBox.Show("Mart - Nisan - Mayıs"); break; }

                default: { MessageBox.Show("Böyle bir ay bulunamadı!"); break; }
            }
        }

        private void btnDeger3_Click(object sender, EventArgs e)
        {
            string ay = txtGelenDeger1.Text.ToLower();

            switch(ay)
            {
                case "aralık": { MessageBox.Show("Kış Mevsimi"); break; }
                case "ocak": { MessageBox.Show("Kış Mevsimi"); break; }
                case "şubat": { MessageBox.Show("Kış Mevsimi"); break; }
                case "mart": { MessageBox.Show("İlkbahar Mevsimi"); break; }
                case "nisan": { MessageBox.Show("İlkbahar Mevsimi"); break; }
                case "mayıs": { MessageBox.Show("İlkbahar Mevsimi"); break; }
                case "haziran": { MessageBox.Show("Yaz Mevsimi"); break; }
                case "temmuz": { MessageBox.Show("Yaz Mevsimi"); break; }
                case "oğustos": { MessageBox.Show("Yaz Mevsimi"); break; }
                case "eylül": { MessageBox.Show("Sonbahar Mevsimi"); break; }
                case "ekim": { MessageBox.Show("Sonbahar Mevsimi"); break; }
                case "kasım": { MessageBox.Show("Sonbahar Mevsimi"); break; }
                default: { MessageBox.Show("Lütfen Geçerli Bir Ay Giriniz ! "); break; }
            }
        }

        private void btnDeger5_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(txtGelenDeger1.Text);
           
            if(sayi < 5) { MessageBox.Show("Sayı 5'den Küçüktür"); }
            else if(sayi > 5) { MessageBox.Show("Sayı 5'den Büyüktür"); }
            else{ MessageBox.Show("Sayı 5'e Eşittir."); }

            switch(sayi)
            {
                case int s when s > 5:
                    {
                        MessageBox.Show("Sayı 5'den Büyüktür.");
                        break;
                    }
                case int s when s < 5:
                    {
                        MessageBox.Show("Sayı 5'den Küçüktür.");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Sayı 5'e Eşittir.");
                        break;
                    }
            }


        }

        private void btnDeger6_Click(object sender, EventArgs e)
        {
            //int sayi2 = int.Parse(txtGelenDeger1.Text);
            
            //string mesaj = sayi2 switch
            //{
            //    sayi2 > 5 => "",
            //    sayi2 < 5 => ""
            //}
        }
    }
}
