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
    public partial class Form9_SuTakibi : Form
    {
        Kullanici _kullanici;
        public Form9_SuTakibi(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                lblHedefSu.Text = (int.Parse(txtKilo.Text) * (0.033)).ToString();
                lblBardakSu.Text = (int.Parse(txtKilo.Text) * (0.033) * 1000 / 200).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen kilonuzu giriniz");
            }           
        }

        private void pcGeri_Click(object sender, EventArgs e)
        {
            Form6_Anasayfa frm6 = new Form6_Anasayfa(_kullanici);
            this.Hide();
            frm6.Show();
        }
    }
}
