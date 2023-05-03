using BLL.Services;
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
    public partial class Form5_Aktivite : Form
    {
        Kullanici _kullanici;
        public Form5_Aktivite(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
        }

        public void Form6Gecis(Kullanici kullanici)
        {
            Form6_Anasayfa frm6 = new Form6_Anasayfa(kullanici);
            this.Hide();
            frm6.Show();
        }

        private void btnPekHareketliDegil_Click(object sender, EventArgs e)
        {
            AktiviteBilgileriService hedefService = new AktiviteBilgileriService();

            AktiviteBilgileri aktiviteBilgileri = new AktiviteBilgileri();
            aktiviteBilgileri.Aktivite = Models.Enums.Aktivite.PekHareketliDeğil;
            aktiviteBilgileri.AktiviteKatSayi = aktiviteBilgileri.AktiviteKatsayiHesapla(aktiviteBilgileri.Aktivite);
            aktiviteBilgileri.KullaniciID = _kullanici.ID;
            hedefService.Insert(aktiviteBilgileri);

            Form6Gecis(_kullanici);
        }

        private void btnAzHareketli_Click(object sender, EventArgs e)
        {
            AktiviteBilgileriService hedefService = new AktiviteBilgileriService();

            AktiviteBilgileri aktiviteBilgileri = new AktiviteBilgileri();
            aktiviteBilgileri.Aktivite = Models.Enums.Aktivite.AzHareketli;
            aktiviteBilgileri.AktiviteKatSayi = aktiviteBilgileri.AktiviteKatsayiHesapla(aktiviteBilgileri.Aktivite);
            aktiviteBilgileri.KullaniciID = _kullanici.ID;
            hedefService.Insert(aktiviteBilgileri);

            Form6Gecis(_kullanici);
        }

        private void btnAktif_Click(object sender, EventArgs e)
        {
            AktiviteBilgileriService hedefService = new AktiviteBilgileriService();

            AktiviteBilgileri aktiviteBilgileri = new AktiviteBilgileri();
            aktiviteBilgileri.Aktivite = Models.Enums.Aktivite.Aktif;
            aktiviteBilgileri.AktiviteKatSayi = aktiviteBilgileri.AktiviteKatsayiHesapla(aktiviteBilgileri.Aktivite);
            aktiviteBilgileri.KullaniciID = _kullanici.ID;
            hedefService.Insert(aktiviteBilgileri);

            Form6Gecis(_kullanici);
        }

        private void btnCokHareketli_Click(object sender, EventArgs e)
        {
            AktiviteBilgileriService hedefService = new AktiviteBilgileriService();

            AktiviteBilgileri aktiviteBilgileri = new AktiviteBilgileri();
            aktiviteBilgileri.Aktivite = Models.Enums.Aktivite.ÇokHareketli;
            aktiviteBilgileri.AktiviteKatSayi = aktiviteBilgileri.AktiviteKatsayiHesapla(aktiviteBilgileri.Aktivite);
            aktiviteBilgileri.KullaniciID = _kullanici.ID;
            hedefService.Insert(aktiviteBilgileri);

            Form6Gecis(_kullanici);
        }

        private void pcGeri_Click(object sender, EventArgs e)
        {
            Form4_Hedef frm4 = new Form4_Hedef(_kullanici);
            this.Hide();
            frm4.Show();
        }
    }
}
