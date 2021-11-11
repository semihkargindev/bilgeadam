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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDeger1_Click(object sender, EventArgs e)
        {
            string userName = txtGelenDeger1.Text;
            string password = txtGelenDeger2.Text;


            if (userName =="admin")
            {
                if (password == "123")
                {
                    MessageBox.Show("Tebrikler Giriş Yaptınız.");
                }
                else
                {
                    MessageBox.Show("Kulanıcı Bilgileriniz Yanlış");
                }

            }
            else
            {
                MessageBox.Show("Kullanıcı Bilgileriniz Yanlış");
            }

            if (userName =="admin" && password=="123")
            {
                MessageBox.Show("Tebrikler Giriş Yaptınız");
            }
            else
            {
                MessageBox.Show("Kullanıcı Bilgileriniz Yanlış");
            }

        }

        private void btnDeger2_Click(object sender, EventArgs e)
        {
            int not = Convert.ToInt32(txtGelenDeger1.Text);

            if (not >= 0 && not < 30)
            {
                MessageBox.Show("Notunuz : FF");
            }
            else if (not >= 30 && not < 50)
            {
                MessageBox.Show("Notunuz : DD");
            }
            else if (not >= 50 && not < 70)
            {
                MessageBox.Show("Notunuz : CC");
            }
            else if (not >= 70 && not < 85)
            {
                MessageBox.Show("Notunuz : BB");
            }
            else if (not >= 85 && not <= 100)
            {
                MessageBox.Show("Notunuz : AA");
            }
            else
            {
                MessageBox.Show("Geçersiz Not Aralığı Girdiniz. Tekrar Giriniz ");
            }



        }
    }
}
