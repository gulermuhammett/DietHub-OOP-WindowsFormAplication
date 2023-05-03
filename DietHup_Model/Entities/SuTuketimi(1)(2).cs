using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietHup_Model.Entities
{
    public class SuTuketimi
    {
        public SuTuketimi()
        {
            SuTuketimTarihi = DateTime.Now;
        }

        public int ID { get; set; }
        public float IcilenSuMiktari { get; set; }
        public DateTime SuTuketimTarihi { get; set; }

        public int UserID { get; set; } // User Tablosu İlişkisi
        public User User { get; set; }


    }
}
