using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityConfigurations
{
    public class KullaniciConfiguration : EntityTypeConfiguration<Kullanici>
    {
        public KullaniciConfiguration()
        {
            Property(a => a.Ad).HasMaxLength(50);
            Property(a => a.Soyad).HasMaxLength(50);
            //HasIndex(a => a.Eposta).IsUnique();

            //Relation

        }
    }
}
