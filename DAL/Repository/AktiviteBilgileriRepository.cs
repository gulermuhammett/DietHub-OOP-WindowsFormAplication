using DAL.Context;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class AktiviteBilgileriRepository : BaseRepository<AktiviteBilgileri>
    {
        DietHubDbContext db;

        public AktiviteBilgileriRepository()
        {
            db = new DietHubDbContext();
        }

        public override bool Delete(int id)
        {
            AktiviteBilgileri deleteAktivite = db.Aktiviteler.Find(id);
            return db.SaveChanges() > 0;
        }

        public override List<AktiviteBilgileri> GetAll()
        {
            return db.Aktiviteler.ToList();
        }

        public override AktiviteBilgileri GetById(int id)
        {
            return db.Aktiviteler.Find(id);
        }

        public override bool Insert(AktiviteBilgileri entity)
        {
            db.Aktiviteler.Add(entity);
            return db.SaveChanges() > 0;
        }

        public override bool Update(AktiviteBilgileri entity)
        {
            var updateAktivite = GetById(entity.ID);
            db.Entry(updateAktivite).CurrentValues.SetValues(entity);
            return db.SaveChanges() > 0;
        }
    }
}
