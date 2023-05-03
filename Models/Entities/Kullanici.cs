using Models.Abstract;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Kullanici : IStatus
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Boy { get; set; }
        public float Kilo { get; set; }
        public float BoyunCevresi { get; set; }
        public float BelCevresi { get; set; }
        public float BasenCevresi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public string Eposta { get; set; }

        private string _sifre;

        public string Sifre
        {
            get { return _sifre; }
            set
            {
                if (value.Length < 6 || value.Length > 20)
                    throw new ArgumentException("Şifre en az 6 karakterli, en fazla 20 karakterli olmalıdır.");

                if (!value.Any(c => char.IsUpper(c)))
                    throw new ArgumentException("Şifre en az bir büyük harf içermelidir.");

                if (!value.Any(c => char.IsLower(c)))
                    throw new ArgumentException("Şifre en az bir küçük harf içermelidir.");

                if (!value.Any(c => char.IsDigit(c)))
                    throw new ArgumentException("Şifre en az bir sayı içermelidir.");

                if (!value.Any(c => !char.IsLetterOrDigit(c)))
                    throw new ArgumentException("Şifre en az bir özel karakter içermelidir.");

                _sifre = value;
            }
        }

        public ICollection<HedefBilgileri> HedefBilgileris { get; set; }

        public ICollection<AktiviteBilgileri> AktiviteBilgileris { get; set; }

        public ICollection<Su> Sular { get; set; }

        public ICollection<VucutAnalizi> VucutAnalizleri { get; set; }

        public ICollection<EgzersizBilgileri> Egzersizler { get; set; }
        public ICollection<Menu> Menuler { get; set; }

        public bool Statu { get; set; } = false;


        public int YasHesapla(DateTime dogumTarihi)
        {
            TimeSpan span = DateTime.Now - dogumTarihi;
            int age = (int)(span.TotalDays / 365.25);
            return age;
        }
    }
}