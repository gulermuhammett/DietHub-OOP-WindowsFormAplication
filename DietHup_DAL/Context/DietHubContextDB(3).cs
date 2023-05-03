using DietHup_Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietHup_DAL.Context
{
    internal class DietHubContextDB:DbContext
    {
        public DietHubContextDB():base("Server=DESKTOP-OEIFO1O\\CAGRISERVER;Database=HotelsWfaDB;User Id=sa;Password=1234;")
        {

        }

        public DbSet<Admin> Adminler { get; set; }
        public DbSet<AlternatifMenu> AlternatifMenuler { get; set; }
        public DbSet<User> Userlar { get; set; }
        public DbSet<Egzersiz> Egzersizler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Yiyecek> Yiyecekler { get; set; }
        public DbSet<VucutAnalizi> VucutAnalizler { get; set; }
        public DbSet<SuTuketimi> SuTuketimler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add();
        }

    }
}
