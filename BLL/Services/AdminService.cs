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
    public class AdminService : BaseService<Admin>
    {
        AdminRepository adminRepository;
        public AdminService()
        {
            adminRepository = new AdminRepository();
        }

        public override bool Delete(int id)
        {
            return adminRepository.Delete(id);
        }

        public override List<Admin> GetAll()
        {
            return adminRepository.GetAll();
        }

        public override Admin GetById(int id)
        {
            return adminRepository.GetById(id);
        }

        public override bool Insert(Admin entity)
        {
            if (string.IsNullOrEmpty(entity.Sifre) || string.IsNullOrEmpty(entity.Eposta))
            {
                throw new Exception("Şifre ve E-Posta boş geçilemez");
            }
            return adminRepository.Insert(entity);
        }

        public override bool Update(Admin entity)
        {
            return adminRepository.Update(entity);
        }
    }
}
