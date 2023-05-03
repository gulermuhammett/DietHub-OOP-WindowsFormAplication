using Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityConfigurations
{
    public class AktiviteBilgileriConfiguration : EntityTypeConfiguration<AktiviteBilgileri>
    {
        public AktiviteBilgileriConfiguration()
        {
            Property(a => a.ID).IsRequired();
            Property(a => a.AktiviteKatSayi).IsRequired();
            Property(a => a.Aktivite).IsRequired();

            HasRequired(a => a.Kullanici).WithMany(a => a.AktiviteBilgileris).HasForeignKey(a => a.KullaniciID);
        }
    }
}
