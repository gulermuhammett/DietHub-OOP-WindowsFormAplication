using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityConfigurations
{
    public class KategoriConfiguration : EntityTypeConfiguration<Kategori>
    {
        public KategoriConfiguration()
        {
            Property(a=>a.KategoriAdi).IsRequired().HasMaxLength(50);

            
        }
    }
}
