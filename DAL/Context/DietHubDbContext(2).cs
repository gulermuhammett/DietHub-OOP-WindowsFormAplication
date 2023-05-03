using DAL.EntityConfigurations;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class DietHubDbContext : DbContext
    {
        public DietHubDbContext() : base("Server=DESKTOP-J8GJSHH\\SQLEXPRESS;DataBase=DietHubDB;User Id=sa;Password=1234;")
        {

        }

        public DbSet<Admin> Adminler { get; set; }
        public DbSet<AktiviteBilgileri> Aktiviteler { get; set;}
        public DbSet<BesinBilgileri> BesinBilgileri { get; set; }
        public DbSet<EgzersizBilgileri> EgzersizBilgileri { get; set; }
        public DbSet<HedefBilgileri> HedefBilgileri { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Su> Sular { get; set; }
        public DbSet<VucutAnalizi> VucutAnalizleri { get; set; }
        public DbSet<Menu> Menuler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdminConfiguration());
            modelBuilder.Configurations.Add(new AktiviteBilgileriConfiguration());
            modelBuilder.Configurations.Add(new BesinBilgileriConfiguration());
            modelBuilder.Configurations.Add(new EgzersizBilgileriConfiguration());
            modelBuilder.Configurations.Add(new HedefBilgileriConfiguration());
            modelBuilder.Configurations.Add(new KullaniciConfiguration());
            modelBuilder.Configurations.Add(new SuConfiguration());
            modelBuilder.Configurations.Add(new VucutAnaliziConfiguration());
            modelBuilder.Configurations.Add(new MenuConfiguration());

        }
    }
}
