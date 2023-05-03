using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Admin : IStatus
    {
        public int ID { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public bool Statu { get; set; }
    }
}
