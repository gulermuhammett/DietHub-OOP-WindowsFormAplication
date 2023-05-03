using DAL.Repository;
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

namespace Deneme_DietHub.Resources
{
    public partial class Form7_Raporlar : Form
    {
        int seciliId;
        Kullanici _kullanici;

        MenuRepository menuRepository = new MenuRepository();
        public Form7_Raporlar(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
        }

        private void Form7_Raporlar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = menuRepository.GetAll();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            seciliId = (int)dataGridView1.CurrentRow.Cells[0].Value;
        }

        private void btnOgunGuncelle_Click(object sender, EventArgs e)
        {
            menuRepository.GetById(seciliId);
        }
    }
}
