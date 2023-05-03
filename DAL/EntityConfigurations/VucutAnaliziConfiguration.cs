using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityConfigurations
{
    public class VucutAnaliziConfiguration : EntityTypeConfiguration<VucutAnalizi>
    {
        public VucutAnaliziConfiguration()
        {
            Property(a => a.ID).IsRequired();
            HasRequired(a => a.Kullanici).WithMany(a => a.VucutAnalizleri).HasForeignKey(a => a.KullaniciID);
        }
    }
}
