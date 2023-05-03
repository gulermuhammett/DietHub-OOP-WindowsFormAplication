using DAL.Context;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class EgzersizBilgileriRepository : BaseRepository<EgzersizBilgileri>
    {
        DietHubDbContext db;

        public EgzersizBilgileriRepository()
        {
            db = new DietHubDbContext();
        }

        public override bool Delete(int id)
        {
            EgzersizBilgileri deleteEgzersiz = db.EgzersizBilgileri.Find(id);
            return db.SaveChanges() > 0;
        }

        public override List<EgzersizBilgileri> GetAll()
        {
            return db.EgzersizBilgileri.ToList();
        }

        public override EgzersizBilgileri GetById(int id)
        {
            return db.EgzersizBilgileri.Find(id);
        }

        public override bool Insert(EgzersizBilgileri entity)
        {
            db.EgzersizBilgileri.Add(entity);
            return db.SaveChanges() > 0;
        }

        public override bool Update(EgzersizBilgileri entity)
        {
            var updateEgzersiz = GetById(entity.ID);
            db.Entry(updateEgzersiz).CurrentValues.SetValues(entity);
            return db.SaveChanges() > 0;
        }
    }
}
