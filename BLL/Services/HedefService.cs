using DAL.Repository;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HedefService : BaseService<HedefBilgileri>
    {
        HedefBilgileriRepository hedefBilgileriRepository;
        public HedefService()
        {
            hedefBilgileriRepository = new HedefBilgileriRepository();
        }
        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<HedefBilgileri> GetAll()
        {
            throw new NotImplementedException();
        }

        public override HedefBilgileri GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Insert(HedefBilgileri entity)
        {
            return hedefBilgileriRepository.Insert(entity);
        }

        public override bool Update(HedefBilgileri entity)
        {
            throw new NotImplementedException();
        }
    }
}
