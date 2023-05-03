using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietHup_Model.Entities
{
    public class Egzersiz
    {
        

        public int ID { get; set; }
        public string EgzersizAdi { get; set; }
        public int EgzersizSuresi { get; set; }
        public int YaktigiKaloriMiktari { get; set; }
    }
}
