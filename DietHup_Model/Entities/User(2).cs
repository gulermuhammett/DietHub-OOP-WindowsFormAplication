using DietHup_Model.Enumlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietHup_Model.Entities
{
    public class User : BaseEntities
    {
        public User(DateTime dogumTarihi)
        {
            Yas = DateTime.Now.Year - dogumTarihi.Year;
        }

        public Cinsiyet Cinsiyet { get; set; }
        public KiloHedefi HedefKilo { get; set; }
        public AktiviteDüzeyi AktiviteDüzeyi { get; set; }

        public ICollection<VucutAnalizi> VucutAnalizleri { get; set; } // Vucut analizi tablosu bağlantısı

        public ICollection<SuTuketimi> SuTuketimleri { get; set; } // su tüketimi tablosu bağlantısı

        public float HedefKaloriHesapla(KiloHedefi hedef)    //performansı arttırmak için float tercih edildi :D
        {
            float sayi = 0;
            switch (hedef)
            {
                case KiloHedefi.kiloAlmak:
                    sayi += 150;
                    break;
                case KiloHedefi.KiloVermek:
                    sayi -= 150;
                    break;
                case KiloHedefi.KiloyuKorumak:
                    break;
            }
            return sayi;

        }

        public float AktiviteDüzeyiHesapla(AktiviteDüzeyi hedef)
        {
            float sayi = 0;
            switch (hedef)
            {
                case AktiviteDüzeyi.PekHareketliDegil:sayi = 1.2F;
                   break;
                case AktiviteDüzeyi.AzHareketli:sayi = 1.375F;
                    break;
                case AktiviteDüzeyi.Aktif:sayi = 1.55F;
                    break;
                case AktiviteDüzeyi.ÇokHareketli:sayi=1.9F;
                    break;
            }

            return sayi;
        }



    }
}
