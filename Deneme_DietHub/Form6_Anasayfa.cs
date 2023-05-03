using Deneme_DietHub.Resources;
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
    
    public partial class Form6_Anasayfa : Form
    {
        Kullanici _kullanici;
        public Form6_Anasayfa(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici= kullanici;
        }

        private void btnVucutAnalizi_Click(object sender, EventArgs e)
        {
            Form8_VucutAnalizi frm8 = new Form8_VucutAnalizi(_kullanici);
            this.Hide();
            frm8.Show();
        }

        private void btnSuTakibi_Click(object sender, EventArgs e)
        {
            Form9_SuTakibi frm9 = new Form9_SuTakibi(_kullanici);
            this.Hide();
            frm9.Show();
        }

        private void btnKaloriTakibi_Click(object sender, EventArgs e)
        {
            Form13_Ogunler frm13 = new Form13_Ogunler(_kullanici);
            this.Hide();
            frm13.Show();
        }

        private void btnHedefler_Click(object sender, EventArgs e)
        {
            Form7_Raporlar frm7 = new Form7_Raporlar(_kullanici);
            this.Hide();
            frm7.Show();
        }
    }
}
