using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityConfigurations
{
    public class BesinBilgileriConfiguration : EntityTypeConfiguration<BesinBilgileri>
    {
        public BesinBilgileriConfiguration()
        {
            Property(a => a.ID).IsRequired();
            Property(a => a.Gram).IsOptional();

            
            HasRequired(a => a.kategori).WithMany(a => a.BesinBilgileris).HasForeignKey(a => a.KategoriID);
            HasMany(a => a.Menuler).WithMany(a => a.Yiyecekler).Map(a =>
            {
                a.MapLeftKey("MenulerRefID");
                a.MapRightKey("YiyeceklerRefID");
                a.ToTable("MenuBesin");
            });
        }
    }
}
