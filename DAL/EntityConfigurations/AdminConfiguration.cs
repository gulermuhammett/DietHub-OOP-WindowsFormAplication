using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityConfigurations
{
    public class AdminConfiguration : EntityTypeConfiguration<Admin>
    {
        public AdminConfiguration()
        {
            Property(a => a.Eposta).IsRequired().HasMaxLength(50);
            Property(a => a.Sifre).IsRequired().HasMaxLength(20);
        }
    }
}
