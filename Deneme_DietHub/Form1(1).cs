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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Form2_GirisYap girisYap = new Form2_GirisYap();
            this.Hide();
            girisYap.ShowDialog();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            Form3_UyeOl uyeOl = new Form3_UyeOl();
            this.Hide();
            uyeOl.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                       
        }
    }
}
