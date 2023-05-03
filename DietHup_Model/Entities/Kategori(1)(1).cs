using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietHup_Model.Entities
{
    public class Kategori
    {
        public int KategoriID { get; set; }
        public int KategoriAdi { get; set; }

        ICollection<Yiyecek> Yiyecekler { get;set; } // yiyecek tablosu bağlantısı
    }
}
