using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityConfigurations
{
    internal class BesinBilgileriConfiguration : EntityTypeConfiguration<BesinBilgileri>
    {
        public BesinBilgileriConfiguration()
        {
            Property(a => a.ID).IsRequired();

            HasRequired(a => a.menu).WithMany(a => a.Besinler).HasForeignKey(a => a.MenuID);
        }
    }
}
