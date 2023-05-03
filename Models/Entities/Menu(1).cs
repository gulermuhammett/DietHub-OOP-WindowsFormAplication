using Models.Abstract;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Menu : IStatus
    {
        public int MenuID { get; set; }
        public string MenuAdi { get; set; }
        public Ogun MenuTipi { get; set; }
        public float ToplamKalori { get; set; }

        public ICollection<BesinBilgileri> Besinler { get; set; }
        public virtual int KullaniciID { get; set; }
        public Kullanici kullanici { get; set; }
        public bool Statu { get; set; }
    }
}
