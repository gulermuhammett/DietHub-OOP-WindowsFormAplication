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
    public partial class Form4_Hedef : Form
    {
        Kullanici _kullanici;
        public Form4_Hedef(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
        }

        public void Form5Gecis(Kullanici kullanici)
        {
            Form5_Aktivite frm5 = new Form5_Aktivite(kullanici);
            this.Hide();
            frm5.Show();
        }

        private void btnKiloAlmak_Click(object sender, EventArgs e)
        {
            HedefService hedefService = new HedefService();

            HedefBilgileri hedefBilgileri = new HedefBilgileri();
            hedefBilgileri.Hedef = Models.Enums.Hedef.KiloAlmak;
            hedefBilgileri.HedefKatSayi = hedefBilgileri.HedefKatsayi(hedefBilgileri.Hedef);
            hedefBilgileri.KullaniciID = _kullanici.ID;
            hedefService.Insert(hedefBilgileri);

            Form5Gecis(_kullanici);
        }

        private void btnKiloKoruma_Click(object sender, EventArgs e)
        {
            HedefService hedefService = new HedefService();

            HedefBilgileri hedefBilgileri = new HedefBilgileri();
            hedefBilgileri.Hedef = Models.Enums.Hedef.KiloyuKorumak;
            hedefBilgileri.HedefKatSayi = hedefBilgileri.HedefKatsayi(hedefBilgileri.Hedef);
            hedefBilgileri.KullaniciID = _kullanici.ID;
            hedefService.Insert(hedefBilgileri);

            Form5Gecis(_kullanici);
        }

        private void btnKiloVermek_Click(object sender, EventArgs e)
        {
            HedefService hedefService = new HedefService();

            HedefBilgileri hedefBilgileri = new HedefBilgileri();
            hedefBilgileri.Hedef = Models.Enums.Hedef.KiloVermek;
            hedefBilgileri.HedefKatSayi = hedefBilgileri.HedefKatsayi(hedefBilgileri.Hedef);
            hedefBilgileri.KullaniciID = _kullanici.ID;
            hedefService.Insert(hedefBilgileri);

            Form5Gecis(_kullanici);
        }

        private void pcGeri_Click(object sender, EventArgs e)
        {
            Form3_UyeOl frm3 = new Form3_UyeOl();
            this.Hide();
            frm3.Show();
        }
    }
}
