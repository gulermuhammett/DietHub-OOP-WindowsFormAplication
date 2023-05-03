using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using System.Data.Entity;

namespace DAL.Repository
{
    public abstract class BaseRepository<T> where T : class
    {
        //private readonly DietHubDbContext _connectionString;

        //private DbSet<T> _dbSet;
        //public BaseRepository(DietHubDbContext connectionString)
        //{
        //    _connectionString = connectionString;
        //    _dbSet = _connectionString.Set<T>();
        //}

        DietHubDbContext dbContext;

        public BaseRepository()
        {
            dbContext = new DietHubDbContext();
        }

        public abstract List<T> GetAll();
        public abstract T GetById(int id);
        public abstract bool Insert(T entity);
        public abstract bool Update(T entity);
        public abstract bool Delete(int id);
    }
}
