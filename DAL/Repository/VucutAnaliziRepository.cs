using DAL.Context;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class VucutAnaliziRepository : BaseRepository<VucutAnalizi>
    {
        DietHubDbContext db;

        public VucutAnaliziRepository()
        {
            db = new DietHubDbContext();
        }

        public override bool Delete(int id)
        {
            VucutAnalizi deleteVucutAnaliz = db.VucutAnalizleri.Find(id);
            deleteVucutAnaliz.Statu = false;
            return db.SaveChanges() > 0;
        }

        public override List<VucutAnalizi> GetAll()
        {
            return db.VucutAnalizleri.ToList();
        }

        public override VucutAnalizi GetById(int id)
        {
            return db.VucutAnalizleri.Find(id);
        }

        public override bool Insert(VucutAnalizi entity)
        {
            db.VucutAnalizleri.Add(entity);
            return db.SaveChanges() > 0;
        }

        public override bool Update(VucutAnalizi entity)
        {
            var updateVucutAnalizi = GetById(entity.ID);
            db.Entry(updateVucutAnalizi).CurrentValues.SetValues(entity);
            return db.SaveChanges() > 0;
        }
    }
}
