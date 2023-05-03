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
    public class EgzersizBilgileriService : BaseService<EgzersizBilgileri>
    {
        EgzersizBilgileriRepository egzersizBilgileriRepository;
        public EgzersizBilgileriService()
        {
            egzersizBilgileriRepository = new EgzersizBilgileriRepository();
        }

        public override bool Delete(int id)
        {
            return egzersizBilgileriRepository.Delete(id);
        }

        public override List<EgzersizBilgileri> GetAll()
        {
            return egzersizBilgileriRepository.GetAll();
        }

        public override EgzersizBilgileri GetById(int id)
        {
            return egzersizBilgileriRepository.GetById(id);
        }

        public override bool Insert(EgzersizBilgileri entity)
        {
            if (string.IsNullOrEmpty(entity.KaloriDegeri.ToString()) || string.IsNullOrEmpty(entity.Egzersiz.ToString()))
            {
                throw new Exception("Kalori Değeri ve Egzersiz Adı boş geçilemez");
            }
            return egzersizBilgileriRepository.Insert(entity);
        }

        public override bool Update(EgzersizBilgileri entity)
        {
            return egzersizBilgileriRepository.Update(entity);
        }
    }
}
