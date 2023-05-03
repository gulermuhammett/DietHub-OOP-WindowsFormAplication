using DAL.Context;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public abstract class BaseService<T> where T : class
    {        
        
        public BaseService()
        {
            
        }

        public abstract List<T> GetAll();
        public abstract T GetById(int id);
        public abstract bool Insert(T entity);
        public abstract bool Update(T entity);
        public abstract bool Delete(int id);

    }
}
