using DAL.Context;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class KullaniciRepository : BaseRepository<Kullanici>
    {
        DietHubDbContext db;
              

        public KullaniciRepository()
        {
            db = new DietHubDbContext();
        }

        public override bool Delete(int id)
        {
            Kullanici deleteHedef = db.Kullanicilar.Find(id);
            deleteHedef.Statu = false;
            return db.SaveChanges() > 0;
        }

        public override IEnumerable<Kullanici> GetAll()
        {
            return db.Kullanicilar.ToList();
        }

        public override Kullanici GetById(int id)
        {
            return db.Kullanicilar.Find(id);
        }

        public override bool Insert(Kullanici entity)
        {
            db.Kullanicilar.Add(entity);
            return db.SaveChanges() > 0;
        }

        public override bool Update(Kullanici entity)
        {
            var updateKullanici = GetById(entity.ID);
            db.Entry(updateKullanici).CurrentValues.SetValues(entity);
            return db.SaveChanges() > 0;
        }
    }
}
