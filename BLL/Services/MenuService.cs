using DAL.Repository;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MenuService : BaseService<Menu>
    {
        MenuRepository menuRepository;
        public MenuService()
        {
            menuRepository = new MenuRepository();
        }
        public override bool Delete(int id)
        {
            return menuRepository.Delete(id);
        }

        public override List<Menu> GetAll()
        {
            return menuRepository.GetAll();
        }

        public override Menu GetById(int id)
        {
            return menuRepository.GetById(id);
        }

        public override bool Insert(Menu entity)
        {
            return menuRepository.Insert(entity);
        }

        public override bool Update(Menu entity)
        {
            return menuRepository.Update(entity);
        }

        public List<Menu> OgunToplamKalori(int id)
        {
            var list = menuRepository.GetAll().Where(a => a.KullaniciID == id).Select(m => new Menu { Tarih = m.Tarih, OgunAdi = m.OgunAdi, MenuToplamKalori = m.MenuToplamKalori })
                    .OrderBy(m => m.Tarih)
                    .ToList();
            return list;
        }
        public List<Menu> GunlukToplamKalori(int id)
        {
            var list = OgunToplamKalori(id).GroupBy(a => a.Tarih.Date).Select(m => new Menu { Tarih = m.Key, MenuToplamKalori = m.Sum(a => a.MenuToplamKalori) }).OrderBy(m => m.Tarih).ToList();
            return list;
        }
    }
}
