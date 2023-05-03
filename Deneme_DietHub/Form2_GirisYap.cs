using BLL;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme_DietHub
{
    public partial class Form2_GirisYap : Form
    {
        KullaniciService kullaniciService = new KullaniciService();
        public Form2_GirisYap()
        {
            InitializeComponent();
            txtSifre.PasswordChar = '*';
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici kullanici = new Kullanici()
                {
                    Eposta = txtEmail.Text,
                    Sifre = txtSifre.Text
                };
                kullanici = kullaniciService.KullaniciGirisKontrol(kullanici);

                if (kullanici.Statu==true)
                {
                    Form10_Admin frm10 = new Form10_Admin();
                    this.Hide();
                    frm10.Show();
                }
                else
                {
                    Form6_Anasayfa frm6 = new Form6_Anasayfa(kullanici);
                    this.Hide();
                    frm6.Show();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void pcGeri_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void Form2_GirisYap_Load(object sender, EventArgs e)
        {

        }
    }
}
