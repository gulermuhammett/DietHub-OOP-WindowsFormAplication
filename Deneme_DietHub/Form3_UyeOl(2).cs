using BLL;
using Models.Entities;
using Models.Enums;
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
    public partial class Form3_UyeOl : Form
    {
        KullaniciService kullaniciService;
        public Form3_UyeOl()
        {
            InitializeComponent();
            kullaniciService = new KullaniciService();
        }
        
        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    MessageBox.Show("Şifre tekrarı hatali");
                    return;
                }
                Kullanici kullanici = new Kullanici()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet),cbCinsiyet.Text),
                    Boy = Convert.ToInt32(txtBoy.Text),
                    Kilo = float.Parse(txtKilo.Text),
                    Eposta = txtEmail.Text,
                    Sifre = txtSifre.Text
                };
                
                bool result = kullaniciService.Insert(kullanici);
                MessageBox.Show(result ? "Kullanıcı eklendi" : "Kullanıcı eklenemedi");
                Form4_Hedef form4_Hedef = new Form4_Hedef(kullanici);
                this.Hide();
                form4_Hedef.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_UyeOl_Load(object sender, EventArgs e)
        {
            cbCinsiyet.Items.Add(Cinsiyet.Erkek);
            cbCinsiyet.Items.Add(Cinsiyet.Kadın);

        }
    }
}
