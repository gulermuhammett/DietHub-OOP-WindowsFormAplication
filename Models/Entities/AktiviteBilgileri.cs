using Models.Abstract;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class AktiviteBilgileri
    {
        public int ID { get; set; }
        public float AktiviteKatSayi { get; set; }
        public Aktivite Aktivite { get; set; }

        public virtual int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }


        public float AktiviteKatsayiHesapla(Aktivite aktivite)
        {
            float katSayi = 0;

            switch (aktivite)
            {
                case Aktivite.PekHareketliDeğil:
                    katSayi = 1.2F;
                    break;
                case Aktivite.AzHareketli:
                    katSayi = 1.375F;
                    break;
                case Aktivite.Aktif:
                    katSayi = 1.55F;
                    break;
                case Aktivite.ÇokHareketli:
                    katSayi = 1.9F;
                    break;
                default:
                    break;
            }
            return katSayi;
        }
    }
}
