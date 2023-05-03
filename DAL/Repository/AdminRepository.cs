using DAL.Context;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class AdminRepository : BaseRepository<Admin>
    {
        DietHubDbContext db;

        public AdminRepository()
        {
            db = new DietHubDbContext();
        }


        public override bool Delete(int id)
        {
            Admin deleteAdmin = db.Adminler.Find(id);
            deleteAdmin.Statu = false;
            return db.SaveChanges() > 0;
        }

        public override List<Admin> GetAll()
        {
            return db.Adminler.ToList();
        }

        public override Admin GetById(int id)
        {
            return db.Adminler.Find(id);
        }

        public override bool Insert(Admin entity)
        {
            db.Adminler.Add(entity);
            return db.SaveChanges() > 0;
        }

        public override bool Update(Admin entity)
        {
            var updateAdmin = GetById(entity.ID);
            db.Entry(updateAdmin).CurrentValues.SetValues(entity);
            return db.SaveChanges() > 0;
        }
    }
}
