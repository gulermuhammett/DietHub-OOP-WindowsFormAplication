using DAL.Context;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class HedefBilgileriRepository : BaseRepository<HedefBilgileri>
    {
        DietHubDbContext db;

        public HedefBilgileriRepository()
        {
            db = new DietHubDbContext();
        }

        public override bool Delete(int id)
        {
            HedefBilgileri deleteHedef = db.HedefBilgileri.Find(id);
            deleteHedef.Statu = false;
            return db.SaveChanges() > 0;
        }

        public override List<HedefBilgileri> GetAll()
        {
            return db.HedefBilgileri.ToList();
        }

        public override HedefBilgileri GetById(int id)
        {
            return db.HedefBilgileri.Find(id);
        }

        public override bool Insert(HedefBilgileri entity)
        {
            db.HedefBilgileri.Add(entity);
            return db.SaveChanges() > 0;
        }

        public override bool Update(HedefBilgileri entity)
        {
            var updateHedef = GetById(entity.ID);
            db.Entry(updateHedef).CurrentValues.SetValues(entity);
            return db.SaveChanges() > 0;
        }
    }
}
