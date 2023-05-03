using DietHup_Model.Enumlar;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietHup_Model.Entities
{
    public class VucutAnalizi
    {
        public VucutAnalizi(User kullanici)
        {
            AnalizTarihi = DateTime.Now;
            _kullanici = kullanici;
        }

        User _kullanici;

        public int ID { get; set; }
        public double Boy { get; set; }
        public double Kilo { get; set; }
        public double BelCevresi { get; set; }
        public double BoyunCevresi { get; set; }
        public double BasenCevresi { get; set; }        
        public float VucutKitleEndeksi { get; set; }
        public float VucutYagOrani { get; set; }
        public float BazalMetabolizmaHizi { get; set; }
        public DateTime AnalizTarihi { get; set; }

        public int UserID { get; set; }   // User Tablosu İlişkisi
        public User User { get; set; }

        
        public float BazalMetabolizmaHiziHesapla(User kullanici, double kilo, double boy)
        {
            if (kullanici.Cinsiyet == Cinsiyet.Erkek )
            {
                return (float)(10 * kilo + 6.25 * boy - 5 * (kullanici.Yas) + 5);
            }
            else
            {
                return (float)(10 * kilo + 6.25 * boy - 5 * (kullanici.Yas) - 161);
            }


        }

        public float VucutYagOraniHesaplama(User kullanici, double bel, double boyun, double boy, double basen)
        {
            float yagOrani;

            if (kullanici.Cinsiyet == Cinsiyet.Erkek)
            {
                yagOrani = (float)(495 / (1.0324 - (0.19077 * Math.Log10(bel - boyun)) + (0.15456 * Math.Log10(boy))) - 450);
                return yagOrani;
            }
            else
            {
                yagOrani = (float)(495 / (1.29579 - (0.35004 * Math.Log10(bel + basen - boyun)) + (0.221 * Math.Log10(boy))) - 450);
                return yagOrani;
            }

        }


    }
}
