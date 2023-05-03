using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityConfigurations
{
    public class HedefBilgileriConfiguration : EntityTypeConfiguration<HedefBilgileri>
    {
        public HedefBilgileriConfiguration()
        {
            Property(a => a.ID).IsRequired();
            HasRequired(a => a.Kullanici).WithMany(a => a.HedefBilgileris).HasForeignKey(a => a.KullaniciID);
        }
    }
}
