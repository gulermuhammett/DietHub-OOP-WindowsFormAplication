using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityConfigurations
{
    public class SuConfiguration : EntityTypeConfiguration<Su>
    {
        public SuConfiguration()
        {
            Property(a => a.ID).IsRequired();
            HasRequired(a => a.Kullanici).WithMany(a => a.Sular).HasForeignKey(a => a.KullaniciID);
        }
    }
}
