using Models.Abstract;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class EgzersizBilgileri
    {
        public int ID { get; set; }
        public Egzersiz Egzersiz { get; set; }
        public float KaloriDegeri { get; set; }
        public DateTime EgzersizTarihi { get; set; }

        public virtual int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
        
        
        public int EgzersizKalori(int sure, Egzersiz egzersiz)
        {
            int kalori = 0;

            switch (egzersiz)
            {
                case Egzersiz.AerobikDusukTempo:
                    kalori = 6 * sure;
                    break;
                case Egzersiz.AerobikStep:
                    kalori = 8 * sure;
                    break;
                case Egzersiz.AurobikSuda:
                    kalori = 5 * sure;
                    break;
                case Egzersiz.PedalCevirme:
                    kalori = 12 * sure;
                    break;
                case Egzersiz.Jimnastik:
                    kalori = 5 * sure;
                    break;
                case Egzersiz.EliptikAntenman:
                    kalori = 10 * sure;
                    break;
                case Egzersiz.KurekCekme:
                    kalori = 8 * sure;
                    break;
                case Egzersiz.Kayak:
                    kalori = 11 * sure;
                    break;
                case Egzersiz.Yoga:
                    kalori = 5 * sure;
                    break;
                case Egzersiz.Okculuk:
                    kalori = 4 * sure;
                    break;
                case Egzersiz.Basketbol:
                    kalori = 9 * sure;
                    break;
                case Egzersiz.Bilardo:
                    kalori = 3 * sure;
                    break;
                case Egzersiz.Bowling:
                    kalori = 3 * sure;
                    break;
                case Egzersiz.Eskrim:
                    kalori = 7 * sure;
                    break;
                case Egzersiz.Dans:
                    kalori = 6 * sure;
                    break;
                case Egzersiz.Fencing:
                    kalori = 7 * sure;
                    break;
                case Egzersiz.Golf:
                    kalori = 6 * sure;
                    break;
                case Egzersiz.Hockey:
                    kalori = 9 * sure;
                    break;
                case Egzersiz.BuzPateni:
                    kalori = 8 * sure;
                    break;
                case Egzersiz.Yurume:
                    kalori = 7 * sure;
                    break;
                case Egzersiz.Dagcilik:
                    kalori = 8 * sure;
                    break;
                case Egzersiz.Jumping:
                    kalori = 11 * sure;
                    break;
                case Egzersiz.Dalicilik:
                    kalori = 8 * sure;
                    break;
                case Egzersiz.Futbol:
                    kalori = 8 * sure;
                    break;
                case Egzersiz.TaiChi:
                    kalori = 5 * sure;
                    break;
                case Egzersiz.Voleybol:
                    kalori = 3 * sure;
                    break;
                default:
                    break;
            }
            return kalori;
        }
    }


}
