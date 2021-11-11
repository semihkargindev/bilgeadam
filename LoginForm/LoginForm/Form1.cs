using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        string randomsayi;
        int denemesayac = 5;

        public void image()
        {
            picb1.Image = Image.FromFile(@"..\..\image\1.PNG");
            picb2.Image = Image.FromFile(@"..\..\image\1.PNG");
            picb3.Image = Image.FromFile(@"..\..\image\1.PNG");
            picb4.Image = Image.FromFile(@"..\..\image\1.PNG");
            picb5.Image = Image.FromFile(@"..\..\image\1.PNG");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            image();
            btnLogin.Image = Image.FromFile(@"..\..\image\2.PNG");
            randomsayi = random.Next(10000000, 99999999).ToString();
            lblRandomSayi.Text = randomsayi;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string GirilenDeger = txtGirilenSayi.Text;
            
            if(txtGirilenSayi.Text!="")
            {
                if (randomsayi == txtGirilenSayi.Text) { MessageBox.Show("Başarılı Giriş Yapıldı \n HOŞGELDİNİZ!"); }
                else
                {
                    randomsayi = random.Next(10000000, 99999999).ToString();
                    lblRandomSayi.Text = randomsayi;
                    txtGirilenSayi.Clear();
                    txtGirilenSayi.Focus();

                    if (denemesayac == 5) { picb5.Image = null; }
                    else if (denemesayac == 4) { picb4.Image = null; }
                    else if (denemesayac == 3) { picb3.Image = null; }
                    else if (denemesayac == 2) { picb2.Image = null; }
                    else if (denemesayac == 1) { picb1.Image = null; }

                    denemesayac = denemesayac - 1;

                    if (denemesayac == 0)
                    {
                        txtGirilenSayi.Enabled = false;
                        btnLogin.Enabled = false;
                        lblRandomSayi.Text = "* * * * * * * *";
                        image();
                        MessageBox.Show("Giriş Sağlanamadı!");
                    }

                }
            }
            else { MessageBox.Show("Lütfen Şifreyi Giriniz"); }
         
           
        }
    }
}
