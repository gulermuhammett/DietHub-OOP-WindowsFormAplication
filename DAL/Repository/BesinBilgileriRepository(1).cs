using DAL.Context;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class BesinBilgileriRepository : BaseRepository<BesinBilgileri>
    {
        DietHubDbContext db;

        public BesinBilgileriRepository()
        {
            db = new DietHubDbContext();
        }

        public override bool Delete(int id)
        {
            BesinBilgileri deleteBesin = db.BesinBilgileri.Find(id);
            deleteBesin.Statu = false;
            return db.SaveChanges() > 0;
        }

        public override IEnumerable<BesinBilgileri> GetAll()
        {
            return db.BesinBilgileri.ToList();
        }

        public override BesinBilgileri GetById(int id)
        {
            return db.BesinBilgileri.Find(id);
        }

        public override bool Insert(BesinBilgileri entity)
        {
            db.BesinBilgileri.Add(entity);
            return db.SaveChanges() > 0;
        }

        public override bool Update(BesinBilgileri entity)
        {
            var updateBesin = GetById(entity.ID);
            db.Entry(updateBesin).CurrentValues.SetValues(entity);
            return db.SaveChanges() > 0;
        }
    }
}
