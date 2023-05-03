using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityConfigurations
{
    public class MenuConfiguration : EntityTypeConfiguration<Menu>
    {
        public MenuConfiguration()
        {
            Property(a => a.OgunAdi).IsRequired();

            HasRequired(a => a.Kullanici).WithMany(b => b.Menuler).HasForeignKey(c => c.KullaniciID);
           

        }
    }
}
