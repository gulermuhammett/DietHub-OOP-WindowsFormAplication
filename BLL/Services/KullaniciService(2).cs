using BLL.Services;
using DAL.Context;
using DAL.Repository;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KullaniciService : BaseService<Kullanici>
    {
        KullaniciRepository kullaniciRepository;
        public KullaniciService() 
        {
            kullaniciRepository = new KullaniciRepository();
        }

        public override bool Delete(int id)
        {
            return kullaniciRepository.Delete(id);
        }

        public override IEnumerable<Kullanici> GetAll()
        {
            return kullaniciRepository.GetAll();
        }

        public override Kullanici GetById(int id)
        {
            return kullaniciRepository.GetById(id);
        }

        public override bool Insert(Kullanici entity)
        {
            if (string.IsNullOrEmpty(entity.Ad) || string.IsNullOrEmpty(entity.Soyad) || string.IsNullOrEmpty(entity.Sifre) || string.IsNullOrEmpty(entity.Eposta))
            {
                throw new Exception("Ad, Soyad, Şifre veya E-Posta boş geçilemez");
            }
            return kullaniciRepository.Insert(entity);
        }

        public override bool Update(Kullanici entity)
        {
            return kullaniciRepository.Update(entity);
        }
    }
}
