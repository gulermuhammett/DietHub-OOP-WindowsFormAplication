using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class BesinBilgileri : IStatus
    {
        public int ID { get; set; }
        public string BesinAdi { get; set; }
        public string OlcuBirimi { get; set; }
        public float Gram { get; set; }
        public float Kalori { get; set; }
        public float Karbonhidrat { get; set; }
        public float Yağ { get; set; }
        public float Protein { get; set; }
        public bool Statu { get; set; }

        public virtual int MenuID { get; set; }
        public Menu menu { get; set; }
    }
}
