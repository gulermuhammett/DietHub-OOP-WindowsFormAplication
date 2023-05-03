using Models.Abstract;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class BesinBilgileri
    {
        public int ID { get; set; }
        public string BesinAdi { get; set; }
        public OlcuBirimi OlcuBirimi { get; set; }
        public float Gram { get; set; }
        public float Kalori { get; set; }
        public float Karbonhidrat { get; set; }
        public float Yag { get; set; }
        public float Protein { get; set; }

        public  int KategoriID { get; set; }
        public  Kategori kategori { get; set;}

        public  ICollection<Menu> Menuler { get; set; }
    }
}
