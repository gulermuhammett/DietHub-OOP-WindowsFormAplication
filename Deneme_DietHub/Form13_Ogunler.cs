using BLL;
using BLL.Services;
using DAL.Context;
using DAL.Repository;
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
using System.Xml.Linq;

namespace Deneme_DietHub
{
    public partial class Form13_Ogunler : Form
    {
        KullaniciService kullaniciService = new KullaniciService();
        Kullanici _kullanici;
        BesinBilgileriService besinBilgileriService = new BesinBilgileriService();
        public Form13_Ogunler(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            
        }

        private void Form13_Ogunler_Load(object sender, EventArgs e)
        {
            var result = besinBilgileriService.GetAll();
            dataGridView1.DataSource = result;
            lblHedefKalori.Text = kullaniciService.BazalMetabolizmaHesapla(_kullanici).ToString();
            cmbEgzersiz.DataSource = Enum.GetValues(typeof(Egzersiz));
        }

        int sayacSabah = 0;
        int sayacOgle = 0;
        int sayacAksam = 0;
        int sayacAraOgun = 0;
        int silinecekId;
        int seciliId;

        float kalori = 0;
        float karbonhidrat = 0;
        float yag = 0;
        float protein = 0;
        float toplamKalori = 0;

        private void btnKahvaltiyaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var yemek = besinBilgileriService.GetById(seciliId);
                lbKahvalti.Items.Add(yemek.BesinAdi);
                kalori += yemek.Kalori;
                karbonhidrat += yemek.Karbonhidrat;
                protein += yemek.Protein;
                yag += yemek.Yag;
                lblKahvaltiKalori.Text = kalori.ToString();
                lblKahvaltiCarb.Text = karbonhidrat.ToString();
                lblKahvaltiYag.Text = yag.ToString();
                lblKahvaltiProtein.Text = protein.ToString();
                toplamKalori += yemek.Kalori;
                lblAlinanKalori.Text = (toplamKalori + toplamKaloriOgle + toplamKaloriAksam + toplamKaloriAra).ToString();
                lblKalanKalori.Text = (kullaniciService.BazalMetabolizmaHesapla(_kullanici) - toplamKalori).ToString();
                sayacSabah++;
                if (sayacSabah > 0)
                {
                    btnKahvaltiSil.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen seçim yapınız" + ex.Message);
            }
        }

        private void btnKahvaltiSil_Click(object sender, EventArgs e)
        {
            try
            {
                var yemek = besinBilgileriService.GetById(silinecekNesne.ID);
                lbKahvalti.Items.Remove(yemek.BesinAdi);
                kalori -= yemek.Kalori;
                karbonhidrat -= yemek.Karbonhidrat;
                protein -= yemek.Protein;
                yag -= yemek.Yag;
                lblKahvaltiKalori.Text = kalori.ToString();
                lblKahvaltiCarb.Text = karbonhidrat.ToString();
                lblKahvaltiYag.Text = yag.ToString();
                lblKahvaltiProtein.Text = protein.ToString();
                toplamKalori -= yemek.Kalori;
                lblAlinanKalori.Text = (toplamKalori + toplamKaloriOgle + toplamKaloriAksam + toplamKaloriAra).ToString();
                lblKalanKalori.Text = (kullaniciService.BazalMetabolizmaHesapla(_kullanici) - toplamKalori).ToString();
                sayacSabah--;
                if (sayacSabah == 0)
                {
                    btnKahvaltiSil.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen seçim yapınız" + ex.Message);
            }
        }

        float kaloriOgle = 0;
        float karbonhidratOgle = 0;
        float yagOgle = 0;
        float proteinOgle = 0;
        float toplamKaloriOgle = 0;

        private void btnOgleYemegineEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var yemek = besinBilgileriService.GetById(seciliId);
                lbOgleYemegi.Items.Add(yemek.BesinAdi);
                kaloriOgle += yemek.Kalori;
                karbonhidratOgle += yemek.Karbonhidrat;
                proteinOgle += yemek.Protein;
                yagOgle += yemek.Yag;
                lblOgleKalori.Text = kaloriOgle.ToString();
                lblOgleCarb.Text = karbonhidratOgle.ToString();
                lblOgleYag.Text = yagOgle.ToString();
                lblOgleProtein.Text = proteinOgle.ToString();
                toplamKaloriOgle += yemek.Kalori;
                lblAlinanKalori.Text = (toplamKalori + toplamKaloriOgle + toplamKaloriAksam + toplamKaloriAra).ToString();
                lblKalanKalori.Text = (kullaniciService.BazalMetabolizmaHesapla(_kullanici) - toplamKaloriOgle).ToString();
                sayacOgle++;
                if (sayacOgle > 0)
                {
                    btnOgleSil.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen seçim yapınız" + ex.Message);
            }
        }

        private void btnOgleSil_Click(object sender, EventArgs e)
        {
            try
            {
                var yemek = besinBilgileriService.GetById(silinecekNesne.ID);
                lbOgleYemegi.Items.Remove(yemek.BesinAdi);
                kaloriOgle -= yemek.Kalori;
                karbonhidratOgle -= yemek.Karbonhidrat;
                proteinOgle -= yemek.Protein;
                yagOgle -= yemek.Yag;
                lblOgleKalori.Text = kaloriOgle.ToString();
                lblOgleCarb.Text = karbonhidratOgle.ToString();
                lblOgleYag.Text = yagOgle.ToString();
                lblOgleProtein.Text = proteinOgle.ToString();
                toplamKaloriOgle -= yemek.Kalori;
                lblAlinanKalori.Text = (toplamKalori + toplamKaloriOgle + toplamKaloriAksam + toplamKaloriAra).ToString();
                lblKalanKalori.Text = (kullaniciService.BazalMetabolizmaHesapla(_kullanici) - toplamKaloriOgle).ToString();
                sayacOgle--;
                if (sayacOgle == 0)
                {
                    btnOgleSil.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen seçim yapınız" + ex.Message);
            }
        }

        float kaloriAksam = 0;
        float karbonhidratAksam = 0;
        float yagAksam = 0;
        float proteinAksam = 0;
        float toplamKaloriAksam = 0;

        private void btnAksamYemegineEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var yemek = besinBilgileriService.GetById(seciliId);
                lbAksamYemegi.Items.Add(yemek.BesinAdi);
                kaloriAksam += yemek.Kalori;
                karbonhidratAksam += yemek.Karbonhidrat;
                proteinAksam += yemek.Protein;
                yagAksam += yemek.Yag;
                lblAksamKalori.Text = kaloriAksam.ToString();
                lblAksamCarb.Text = karbonhidratAksam.ToString();
                lblAksamYag.Text = yagAksam.ToString();
                lblAksamProtein.Text = proteinAksam.ToString();
                toplamKaloriAksam += yemek.Kalori;
                lblAlinanKalori.Text = (toplamKalori + toplamKaloriOgle + toplamKaloriAksam + toplamKaloriAra).ToString();
                lblKalanKalori.Text = (kullaniciService.BazalMetabolizmaHesapla(_kullanici) - toplamKaloriAksam).ToString();
                sayacAksam++;
                if (sayacAksam > 0)
                {
                    btnAksamSil.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen seçim yapınız" + ex.Message);
            }
        }

        private void btnAksamSil_Click(object sender, EventArgs e)
        {
            try
            {
                var yemek = besinBilgileriService.GetById(silinecekNesne.ID);
                lbAksamYemegi.Items.Remove(yemek.BesinAdi);
                kaloriAksam -= yemek.Kalori;
                karbonhidratAksam -= yemek.Karbonhidrat;
                proteinAksam -= yemek.Protein;
                yagAksam -= yemek.Yag;
                lblAksamKalori.Text = kaloriAksam.ToString();
                lblAksamCarb.Text = karbonhidratAksam.ToString();
                lblAksamYag.Text = yagAksam.ToString();
                lblAksamProtein.Text = proteinAksam.ToString();
                toplamKaloriAksam -= yemek.Kalori;
                lblAlinanKalori.Text = (toplamKalori + toplamKaloriOgle + toplamKaloriAksam + toplamKaloriAra).ToString();
                lblKalanKalori.Text = (kullaniciService.BazalMetabolizmaHesapla(_kullanici) - toplamKaloriAksam).ToString();
                sayacAksam--;
                if (sayacAksam == 0)
                {
                    btnAksamSil.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen seçim yapınız" + ex.Message);
            }
        }

        float kaloriAra = 0;
        float karbonhidratAra = 0;
        float yagAra = 0;
        float proteinAra = 0;
        float toplamKaloriAra = 0;

        private void btnAraOguneEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var yemek = besinBilgileriService.GetById(seciliId);
                lbAraOgun.Items.Add(yemek.BesinAdi);
                kaloriAra += yemek.Kalori;
                karbonhidratAra += yemek.Karbonhidrat;
                proteinAra += yemek.Protein;
                yagAra += yemek.Yag;
                lblAraKalori.Text = kaloriAra.ToString();
                lblAraCarb.Text = karbonhidratAra.ToString();
                lblAraYag.Text = yagAra.ToString();
                lblAraProtein.Text = proteinAra.ToString();
                toplamKaloriAra += yemek.Kalori;
                lblAlinanKalori.Text = (toplamKalori + toplamKaloriOgle + toplamKaloriAksam + toplamKaloriAra).ToString();
                lblKalanKalori.Text = (kullaniciService.BazalMetabolizmaHesapla(_kullanici) - toplamKaloriAra).ToString();
                sayacAraOgun++;
                if (sayacAraOgun > 0)
                {
                    btnAraOgunSil.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen seçim yapınız" + ex.Message);
            }
        }

        private void btnAraOgunSil_Click(object sender, EventArgs e)
        {
            try
            {
                var yemek = besinBilgileriService.GetById(silinecekNesne.ID);
                lbAraOgun.Items.Remove(yemek.BesinAdi);
                kaloriAra -= yemek.Kalori;
                karbonhidratAra -= yemek.Karbonhidrat;
                proteinAra -= yemek.Protein;
                yagAra -= yemek.Yag;
                lblAraKalori.Text = kaloriAra.ToString();
                lblAraCarb.Text = karbonhidratAra.ToString();
                lblAraYag.Text = yagAra.ToString();
                lblAraProtein.Text = proteinAra.ToString();
                toplamKaloriAra -= yemek.Kalori;
                lblAlinanKalori.Text = (toplamKalori + toplamKaloriOgle + toplamKaloriAksam + toplamKaloriAra).ToString();
                lblKalanKalori.Text = (kullaniciService.BazalMetabolizmaHesapla(_kullanici) - toplamKalori).ToString();
                sayacAraOgun--;
                if (sayacAraOgun == 0)
                {
                    btnAraOgunSil.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen seçim yapınız" + ex.Message);
            }
        }

        BesinBilgileri silinecekNesne;
        private void lbKahvalti_MouseClick(object sender, MouseEventArgs e)
        {
            var selectedItem = lbKahvalti.SelectedItem.ToString();

            if (selectedItem != null)
            {
                silinecekNesne = besinBilgileriService.GetByBesin(selectedItem);
            }
        }

        private void lbOgleYemegi_MouseClick(object sender, MouseEventArgs e)
        {
            var selectedItem = lbOgleYemegi.SelectedItem.ToString();

            if (selectedItem != null)
            {
                silinecekNesne = besinBilgileriService.GetByBesin(selectedItem);
            }
        }

        private void lbAksamYemegi_MouseClick(object sender, MouseEventArgs e)
        {
            var selectedItem = lbAksamYemegi.SelectedItem.ToString();

            if (selectedItem != null)
            {
                silinecekNesne = besinBilgileriService.GetByBesin(selectedItem);
            }
        }

        private void lbAraOgun_MouseClick(object sender, MouseEventArgs e)
        {
            var selectedItem = lbAraOgun.SelectedItem.ToString();

            if (selectedItem != null)
            {
                silinecekNesne = besinBilgileriService.GetByBesin(selectedItem);
            }
        }

        EgzersizBilgileri egzersizBilgileri = new EgzersizBilgileri();
        int toplamKaloriEgzersiz = 0;
        private void btnEgzersizEkle_Click(object sender, EventArgs e)
        {
            Egzersiz egzersiz = (Egzersiz)Enum.Parse(typeof(Egzersiz), cmbEgzersiz.Text);
            lbEgzersiz.Items.Add(egzersiz);
            int harcananKalori = egzersizBilgileri.EgzersizKalori(int.Parse(txtSure.Text), egzersiz);
            toplamKaloriEgzersiz += harcananKalori;
            lblEgzersizKalori.Text = toplamKaloriEgzersiz.ToString();
            lblAlinanKalori.Text = (toplamKalori + toplamKaloriOgle + toplamKaloriAksam + toplamKaloriAra - toplamKaloriEgzersiz).ToString();
            lblKalanKalori.Text = (kullaniciService.BazalMetabolizmaHesapla(_kullanici) - toplamKalori - toplamKaloriEgzersiz).ToString();
        }

        private void btnEgzersizSil_Click(object sender, EventArgs e)
        {
            Egzersiz egzersiz = (Egzersiz)Enum.Parse(typeof(Egzersiz), cmbEgzersiz.Text);
            lbEgzersiz.Items.Remove(egzersiz);
            int harcananKalori = egzersizBilgileri.EgzersizKalori(int.Parse(txtSure.Text), egzersiz);
            toplamKaloriEgzersiz -= harcananKalori;
            lblEgzersizKalori.Text = toplamKaloriEgzersiz.ToString();
            lblAlinanKalori.Text = (toplamKalori + toplamKaloriOgle + toplamKaloriAksam + toplamKaloriAra - toplamKaloriEgzersiz).ToString();
            lblKalanKalori.Text = (kullaniciService.BazalMetabolizmaHesapla(_kullanici) - toplamKalori - toplamKaloriEgzersiz).ToString();
        }

        private void txtBesinAra_TextChanged(object sender, EventArgs e)
        {
            if (txtBesinAra.Text == null)
            {
                dataGridView1.DataSource = besinBilgileriService.GetAll();
            }
            else
            {
                dataGridView1.DataSource = besinBilgileriService.GetByBesin2(txtBesinAra.Text);
            }
        }

        private void pcGeri_Click(object sender, EventArgs e)
        {
            Form6_Anasayfa frm6 = new Form6_Anasayfa(_kullanici);
            this.Hide();
            frm6.Show();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            seciliId = (int)dataGridView1.CurrentRow.Cells[0].Value;
        }
    }
}
