using DAL.Context;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class MenuRepository : BaseRepository<Menu>
    {
        DietHubDbContext db;

        public MenuRepository()
        {
            db = new DietHubDbContext();
        }

        public override bool Delete(int id)
        {
            Menu deleteMenu = db.Menuler.Find(id);
            deleteMenu.Statu = false;
            return db.SaveChanges() > 0;
        }

        public override IEnumerable<Menu> GetAll()
        {
            return db.Menuler.ToList();
        }

        public override Menu GetById(int id)
        {
            return db.Menuler.Find(id);
        }

        public override bool Insert(Menu entity)
        {
            db.Menuler.Add(entity);
            return db.SaveChanges() > 0;
        }

        public override bool Update(Menu entity)
        {
            var updateMenu = GetById(entity.MenuID);
            db.Entry(updateMenu).CurrentValues.SetValues(entity);
            return db.SaveChanges() > 0;
        }
    }
}
