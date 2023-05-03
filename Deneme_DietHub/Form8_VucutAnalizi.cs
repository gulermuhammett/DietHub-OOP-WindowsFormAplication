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
    public partial class Form8_VucutAnalizi : Form
    {
        KullaniciService kullaniciService = new KullaniciService();
        Kullanici _kullanici;
        public Form8_VucutAnalizi(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
        }


        private void Form8_VucutAnalizi_Load(object sender, EventArgs e)
        {
            groupBox2.Text = _kullanici.Ad + " " + _kullanici.Soyad;

            lblVucutKitle.Text = kullaniciService.VucutKitleIndeksHesapla(_kullanici).ToString();
            lblVucutYag.Text = kullaniciService.VucutYagOraniHesapla(_kullanici).ToString();
            lblBazal.Text = kullaniciService.BazalMetabolizmaHesapla(_kullanici).ToString();
            lblBelKalca.Text = kullaniciService.BelKalcaOrani(_kullanici).ToString();

            cmbCinsiyet.Items.Add(Cinsiyet.Erkek);
            cmbCinsiyet.Items.Add(Cinsiyet.Kadın);

            if (_kullanici.Cinsiyet == Cinsiyet.Erkek)
            {
                if (kullaniciService.BelKalcaOrani(_kullanici)>1)
                {
                    lblSaglik.Text = " İnsülin direnci,\n Hipertansiyon,\n Tip 2 diabet,\n Kc yağlanması,\n Kalp ve damar hatalıkları,\n Siroz,\n Kalp yetmezliği,\n Böbrek yetmezliğine yakalanma riski var!";
                }
            }
            else
            {
                if (kullaniciService.BelKalcaOrani(_kullanici) > 0.85)
                {
                    lblSaglik.Text = "insülin direnci, Hipertansiyon, Tip 2 diabet, Kc yağlanması, Kalp ve damar hatalıkları, Siroz, Kalp yetmezliği, Böbrek yetmezliğine yakalanma riski var!";
                }
            }
        }

        private void btnHesapla_Click_1(object sender, EventArgs e)
        {
            Kullanici yeniKullanici = new Kullanici();
            yeniKullanici.Boy = Convert.ToInt32(txtBoy.Text);
            yeniKullanici.Kilo = float.Parse(txtKilo.Text);
            yeniKullanici.DogumTarihi = dtpYas.Value;
            yeniKullanici.Cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.Text);
            yeniKullanici.BoyunCevresi = float.Parse(txtBoyunC.Text);
            yeniKullanici.BelCevresi = float.Parse(txtBelC.Text);
            yeniKullanici.BasenCevresi = float.Parse(txtBasenC.Text);

            label14.Text = kullaniciService.VucutKitleIndeksHesapla(yeniKullanici).ToString();
            label13.Text = kullaniciService.VucutYagOraniHesapla(yeniKullanici).ToString();
            label11.Text = kullaniciService.BazalMetabolizmaKatSayisiz(yeniKullanici).ToString();
        }

        private void pcGeri_Click(object sender, EventArgs e)
        {
            Form6_Anasayfa frm6 = new Form6_Anasayfa(_kullanici);
            this.Hide();
            frm6.Show();
        }
    }
}
