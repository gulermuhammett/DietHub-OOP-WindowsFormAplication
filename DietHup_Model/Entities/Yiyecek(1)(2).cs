using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietHup_Model.Entities
{
    public class Yiyecek
    {
        public int YiyecekID { get; set; }
        public string YiyecekAdi { get; set; }
        public string Olcek { get; set; }
        public int Gramaj { get; set; }
        public int Kalori { get; set; }
        public int Protein { get; set; }
        public int Yag { get; set; }
        public int Karbohidrat { get; set; }

        public int KategoriID { get; set; } // kategori tablosu bağlantısı
        public Kategori Kategori { get; set; }
    }
}
