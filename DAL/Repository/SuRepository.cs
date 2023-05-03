using DAL.Context;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class SuRepository : BaseRepository<Su>
    {
        DietHubDbContext db;

        public SuRepository()
        {
            db = new DietHubDbContext();
        }

        public override bool Delete(int id)
        {
            Su deleteSu = db.Sular.Find(id);
            deleteSu.Statu = false;
            return db.SaveChanges() > 0;
        }

        public override List<Su> GetAll()
        {
            return db.Sular.ToList();
        }

        public override Su GetById(int id)
        {
            return db.Sular.Find(id);
        }

        public override bool Insert(Su entity)
        {
            db.Sular.Add(entity);
            return db.SaveChanges() > 0;
        }

        public override bool Update(Su entity)
        {
            var updateSu = GetById(entity.ID);
            db.Entry(updateSu).CurrentValues.SetValues(entity);
            return db.SaveChanges() > 0;
        }
    }
}
