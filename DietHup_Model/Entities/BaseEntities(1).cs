using DietHup_Model.Enumlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietHup_Model.Entities
{
    public abstract class BaseEntities
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Yas { get; set; }
        public string Sifre { get; set; }       //şifreyi kapsulleme yapabiliriz...
        public KullaniciTipi KullaniciTipi { get; set; }

    }
}
