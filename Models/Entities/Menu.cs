using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Menu
    {
        public Menu()
        {
            Yiyecekler= new List<BesinBilgileri>();
        }
        public int MenuId { get; set; }
        public Ogun OgunAdi { get; set; }
        public DateTime Tarih { get; set; }
        public int MenuToplamKalori { get; set; }
        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
        public List<BesinBilgileri> Yiyecekler { get; set; }
    }
}
