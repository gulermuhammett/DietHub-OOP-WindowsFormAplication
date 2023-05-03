using DAL.Context;
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

        public override IEnumerable<Menu> GetAll()
        {
            return menuRepository.GetAll();
        }

        public override Menu GetById(int id)
        {
            return menuRepository.GetById(id);
        }

        public override bool Insert(Menu entity)
        {
            if (string.IsNullOrEmpty(entity.MenuAdi) || string.IsNullOrEmpty(entity.MenuTipi.ToString()))
            {
                throw new Exception("Menü Adı ve Menü Tipi boş geçilemez");
            }
            return menuRepository.Insert(entity);
        }

        public override bool Update(Menu entity)
        {
            return menuRepository.Update(entity);
        }
    }
}
