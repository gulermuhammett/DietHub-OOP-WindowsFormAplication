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
    public class SuService : BaseService<Su>
    {
        SuRepository suRepository;
        public SuService()
        {
            suRepository = new SuRepository();
        }

        public override bool Delete(int id)
        {
            return suRepository.Delete(id);
        }

        public override List<Su> GetAll()
        {
            return suRepository.GetAll();
        }

        public override Su GetById(int id)
        {
           return suRepository.GetById(id);
        }

        public override bool Insert(Su entity)
        {
            if (string.IsNullOrEmpty(entity.SuMiktari.ToString()) || string.IsNullOrEmpty(entity.SuTarihi.ToString()))
            {
                throw new Exception("Su Miktarı ve Su Tarihi boş geçilemez");
            }
            return suRepository.Insert(entity);
        }

        public override bool Update(Su entity)
        {
            return suRepository.Update(entity);
        }
    }
}
