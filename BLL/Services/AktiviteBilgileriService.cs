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
    public class AktiviteBilgileriService : BaseService<AktiviteBilgileri>
    {
        AktiviteBilgileriRepository aktiviteBilgileriRepository;
        public AktiviteBilgileriService()
        {
            aktiviteBilgileriRepository = new AktiviteBilgileriRepository();
        }

        public override bool Delete(int id)
        {
            return aktiviteBilgileriRepository.Delete(id);
        }

        public override List<AktiviteBilgileri> GetAll()
        {
            return aktiviteBilgileriRepository.GetAll();
        }

        public override AktiviteBilgileri GetById(int id)
        {
            return aktiviteBilgileriRepository.GetById(id);
        }

        public override bool Insert(AktiviteBilgileri entity)
        {
            if (string.IsNullOrEmpty(entity.Aktivite.ToString()) || string.IsNullOrEmpty(entity.AktiviteKatSayi.ToString()))
            {
                throw new Exception("Aktivite Adı ve Aktivite Kat Sayısı boş geçilemez");
            }
            return aktiviteBilgileriRepository.Insert(entity);
        }

        public override bool Update(AktiviteBilgileri entity)
        {
            return aktiviteBilgileriRepository.Update(entity);
        }
    }
}
