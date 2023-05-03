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
    public class BesinBilgileriService : BaseService<BesinBilgileri>
    {
        BesinBilgileriRepository besinBilgileriRepository;
        public BesinBilgileriService()
        {
            besinBilgileriRepository = new BesinBilgileriRepository();
        }

        public override bool Delete(int id)
        {
            return besinBilgileriRepository.Delete(id);
        }

        public override List<BesinBilgileri> GetAll()
        {
            return besinBilgileriRepository.GetAll();
        }

        public override BesinBilgileri GetById(int id)
        {
            return besinBilgileriRepository.GetById(id);
        }

        public override bool Insert(BesinBilgileri entity)
        {
            if (string.IsNullOrEmpty(entity.BesinAdi) || string.IsNullOrEmpty(entity.Kalori.ToString()) || string.IsNullOrEmpty(entity.OlcuBirimi.ToString()) || string.IsNullOrEmpty(entity.Gram.ToString()))
            {
                throw new Exception("Besin Adı, Kalori, Ölçü Birimi ve Gramaj boş geçilemez");
            }
            return besinBilgileriRepository.Insert(entity);
        }

        public override bool Update(BesinBilgileri entity)
        {
            return besinBilgileriRepository.Update(entity);
        }

        public BesinBilgileri GetByBesin(string besin)
        {
            return besinBilgileriRepository.GetByBesin(besin);
        }

        public List<BesinBilgileri> GetByBesin2(string besin)
        {
            return besinBilgileriRepository.GetByBesin2(besin);
        }
    }
}
