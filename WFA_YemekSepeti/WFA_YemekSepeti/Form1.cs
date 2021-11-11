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
using WECPOFLogic;

namespace WFA_YemekSepeti
{
    public partial class EtLokantasıSiparis : MetroForm
    {
        public EtLokantasıSiparis()
        {
            InitializeComponent();
        }
        public void yemeklerekle()
        {
            cmbxYemekSec1.Items.Add("Kebap");
            cmbxYemekSec1.Items.Add("Pilav");
            cmbxYemekSec2.Items.Add("Kebap");
            cmbxYemekSec2.Items.Add("Pilav");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yemeklerekle();
            btnSiparisOzeti.Image = Image.FromFile("../../image/asci.png");
        }

        private void cmbxYemekSec1_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cmbxYemekSec1.Text=="Kebap"){ cmbxYemekSec2.Items.Remove("Kebap"); }
            if (cmbxYemekSec1.Text == "Pilav") { cmbxYemekSec2.Items.Remove("Pilav"); }

        }

        private void cmbxYemekSec2_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cmbxYemekSec2.Text == "Kebap") { cmbxYemekSec1.Items.Remove("Kebap"); }
            if (cmbxYemekSec2.Text == "Pilav") { cmbxYemekSec1.Items.Remove("Pilav"); }


        }

        private void txtPorsiyon1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPorsiyon2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       public void FormSifirla()
        {
            cmbxYemekSec1.Text = "";
            cmbxYemekSec2.Text = "";
            cmbxYemekSec1.Items.Clear();
            cmbxYemekSec2.Items.Clear();
            yemeklerekle();
            txtPorsiyon1.Text = "";
            txtPorsiyon2.Text = "";
            cmbxYemekSec1.Focus();
            cmbxYemekSec2.Focus();
            cmbxYemekSec1.Focus();
          

        }
        public void Siparisozet()
        {
            MessageBox.Show(
                  "         Sipariş Fişi         \n\n\n" +
                  "Kebap            :       " + int.Parse(txtPorsiyon1.Text) * 20 + " TL \n" +
                  "Pilav               :       " + int.Parse(txtPorsiyon2.Text) * 15 + " TL \n" +
                  "Toplam Tutar :       " + ((int.Parse(txtPorsiyon2.Text) * 15) + (int.Parse(txtPorsiyon1.Text) * 20)) + " TL "

                  , "Yemek Sepeti Sipariş");
        }

        private void btnSiparisAl_Click_1(object sender, EventArgs e)
        {
            if (cmbxYemekSec1.Text != "" && cmbxYemekSec2.Text != "" && txtPorsiyon1.Text != "" && txtPorsiyon2.Text != "")
            {
                Siparisozet();
                lblToplamTutar.Text = ((int.Parse(txtPorsiyon2.Text) * 15) + (int.Parse(txtPorsiyon1.Text) * 20)) + " TL ";
                FormSifirla();
            }
            else { MessageBox.Show("Yemek Ve Porsiyon Bilgilerinizi Lütfen Eksiksiz Doldurunuz!"); }
        }

        private void btnSiparisIptal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz İptal Edildi!");
            FormSifirla();
            lblToplamTutar.Text = "0 TL";
        }
        private void btnSiparisOzeti_Click(object sender, EventArgs e)
        {
            if (cmbxYemekSec1.Text != "" && cmbxYemekSec2.Text != "" && txtPorsiyon1.Text != "" && txtPorsiyon2.Text != "")
            {
                Siparisozet();
                 
            }
            else { MessageBox.Show("Yemek Ve Porsiyon Bilgilerinizi Lütfen Eksiksiz Doldurunuz!"); }

        }
    }
}
