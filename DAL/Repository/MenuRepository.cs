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
            db.Menuler.Remove(deleteMenu);
            return db.SaveChanges() > 0;
        }

        public override List<Menu> GetAll()
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
            var updateMenu = GetById(entity.MenuId);
            db.Entry(updateMenu).CurrentValues.SetValues(entity);
            return db.SaveChanges() > 0;
        }

        public List<Menu> GetByDate(DateTime tarih, Kullanici kullanici)                                //servisine eklemedik//
        {
           return  db.Menuler.Where(a => a.Tarih == tarih && a.KullaniciID == kullanici.ID).ToList();
        }



        // günlük öğün kalori mitarı
        // günlük toplam kalori miktarı
        // aylık/haftalık bazda kategorilerin kalori kıyaslaması
        // hangi yemek hangi öğünde ne kadar yenmiş (OrderByDescending)
    }
}
