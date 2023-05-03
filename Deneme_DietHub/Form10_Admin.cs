using BLL.Services;
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
    public partial class Form10_Admin : Form
    {

        BesinBilgileriService besinBilgileriService = new BesinBilgileriService();
        public Form10_Admin()
        {
            InitializeComponent();
        }

        private void Form10_Admin_Load(object sender, EventArgs e)
        {
            var result = besinBilgileriService.GetAll();
            dataGridView1.DataSource = result;
            cmbOlcuBirimi.DataSource = Enum.GetValues(typeof(OlcuBirimi));
        }

        int seciliId;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            seciliId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            BesinBilgileri besin = besinBilgileriService.GetById(seciliId);
            txtBesinAdi.Text = besin.BesinAdi.ToString();
            cmbOlcuBirimi.SelectedItem = besin.OlcuBirimi;
            txtGram.Text = besin.Gram.ToString();
            txtKalori.Text = besin.Kalori.ToString();
            txtKarbonhidrat.Text = besin.Karbonhidrat.ToString();
            txtYag.Text = besin.Yag.ToString();
            txtProtein.Text = besin.Protein.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            BesinBilgileri besin = new BesinBilgileri()
            {
                BesinAdi = txtBesinAdi.Text,
                OlcuBirimi = (OlcuBirimi)Enum.Parse(typeof(OlcuBirimi), cmbOlcuBirimi.Text),
                Gram = float.Parse(txtGram.Text),
                Kalori = float.Parse(txtKalori.Text),
                Karbonhidrat = float.Parse(txtKarbonhidrat.Text),
                Yag = float.Parse(txtYag.Text),
                Protein = float.Parse(txtProtein.Text),
                KategoriID = cbKategori.SelectedIndex + 1,
            };
            besinBilgileriService.Insert(besin);

            dataGridView1.DataSource = besinBilgileriService.GetAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var besin = besinBilgileriService.GetById(seciliId);
            besin.BesinAdi = txtBesinAdi.Text;
            besin.OlcuBirimi = (OlcuBirimi)Enum.Parse(typeof(OlcuBirimi), cmbOlcuBirimi.Text);
            besin.Gram = float.Parse(txtGram.Text);
            besin.Kalori = float.Parse(txtKalori.Text);
            besin.Karbonhidrat = float.Parse(txtKarbonhidrat.Text);
            besin.Yag = float.Parse(txtYag.Text);
            besin.Protein = float.Parse(txtProtein.Text);
            besin.KategoriID = cbKategori.SelectedIndex + 1;
            besinBilgileriService.Update(besin);

            dataGridView1.DataSource = besinBilgileriService.GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            besinBilgileriService.Delete(seciliId);

            dataGridView1.DataSource = besinBilgileriService.GetAll();
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
