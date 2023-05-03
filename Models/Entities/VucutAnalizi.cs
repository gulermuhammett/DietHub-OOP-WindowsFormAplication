using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class VucutAnalizi : IStatus
    {
        public VucutAnalizi()//emre istedi
        {
            VucutAnaliziTarihi = DateTime.Now;
        }

        public int ID { get; set; }
        public float VKI { get; set; }
        public float VYO { get; set; }
        public float BMH { get; set; }

        public DateTime VucutAnaliziTarihi { get; set; }
        public virtual int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
        public bool Statu { get; set; }
    }
}
