using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityConfigurations
{
    internal class MenuConfiguration : EntityTypeConfiguration<Menu>
    {
        public MenuConfiguration()
        {
            Property(a => a.MenuID).IsRequired();

            HasRequired(a => a.kullanici).WithMany(a => a.Menuler).HasForeignKey(a => a.KullaniciID);
        }
    }
}
