using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Su : IStatus
    {
        public int ID { get; set; }
        public float SuMiktari { get; set; }
        public DateTime SuTarihi { get; set; }
        public virtual int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
        public bool Statu { get; set; }

    }
}
