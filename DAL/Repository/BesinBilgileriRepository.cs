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


        public BesinBilgileri LazyLoadings()
        {
            var bes = db.BesinBilgileri.Where(b => b.ID == 1).FirstOrDefault();

            return bes;

        }
        
        public void EagerLoadings()
        {
            var bes = db.BesinBilgileri.Join(db.Kategoriler, b => b.KategoriID, k => k.KategoriID, (b, k) => new
            {
                b.BesinAdi,
                k.KategoriAdi
            }).ToList();
           

        }
        



        public override bool Delete(int id)
        {
            BesinBilgileri deleteBesin = db.BesinBilgileri.Find(id);
            db.BesinBilgileri.Remove(deleteBesin);
            return db.SaveChanges() > 0;
        }


        public override List<BesinBilgileri> GetAll()
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

        public BesinBilgileri GetByBesin(string besin)
        {
            return db.BesinBilgileri.Where(a => a.BesinAdi == besin).FirstOrDefault();
        }

        //public BesinBilgileri GetByBesin2(string besin)
        //{
        //    return db.BesinBilgileri.ToList().Contains(besin).FirstOrDefault();
        //}

        public List<BesinBilgileri> GetByBesin2(string besin)
        {
            return db.BesinBilgileri.Where(a => a.BesinAdi.ToLower().Contains(besin.ToLower())).ToList();

        }
    }
}









