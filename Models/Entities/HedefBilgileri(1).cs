using Models.Abstract;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class HedefBilgileri : IStatus
    {
        public int ID { get; set; }
        public float HedefKatSayi { get; set; }
        public Hedef Hedef { get; set; }
        //public DateTime HedefTarihi { get; set; }
        public virtual int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
        public bool Statu { get; set; }


        public float HedefKatsayi(Hedef hedef)
        {
            float katSayi = 0;

            switch (hedef)
            {
                case Hedef.KiloAlmak:
                    katSayi = 150;
                    break;
                case Hedef.KiloyuKorumak:
                    katSayi = 0;
                    break;
                case Hedef.KiloVermek:
                    katSayi = -150;
                    break;
                default:
                    break;
            }
            return katSayi;
        }
    }
}
