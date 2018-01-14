using MovieStore.Business.Entities;
using MovieStore.Data.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Data
{
    public class Repository<T> : IRepository<T> where T : ModelBase
       
    {
        private DbSet _dbSet;
        private readonly DbContext _dbContext;

        public Repository()
        {
            _dbContext = new SQLDBContext("DevSQL");
            _dbSet = _dbContext.Set<T>();
        }

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = Get(id);

            if (entity != null)
            {
                _dbSet.Remove(entity);
                _dbContext.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            _dbSet.Attach(entity);
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }

        public T Get(int id)
        {
            return _dbSet.Find(id) as T;
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
