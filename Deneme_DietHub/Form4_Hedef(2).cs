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

        private void button1_Click(object sender, EventArgs e)
        {
            HedefService hedefService = new HedefService();

            HedefBilgileri hedefBilgileri = new HedefBilgileri();
            hedefBilgileri.Hedef = Models.Enums.Hedef.KiloAlmak;
            hedefBilgileri.HedefKatSayi = hedefBilgileri.HedefKatsayi(hedefBilgileri.Hedef);
            hedefBilgileri.KullaniciID = _kullanici.ID;
            hedefService.Insert(hedefBilgileri);
           
        }
    }
}
