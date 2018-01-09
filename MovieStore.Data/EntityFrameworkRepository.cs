using MovieStore.Data.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Data
{
    public class EntityFrameworkRepository<T, TEntityKey, D> : IRepository<T,D>
        where T : class, IIdentifiableEntity<TEntityKey>, new()
        where D : DbContext, new() 
   
    {
        private DbSet _dbSet;

        public EntityFrameworkRepository()
        {

        }

        public EntityFrameworkRepository(DbContext dbContext)
        {
            _dbSet = D.Set<TEntityKey>();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = Get(id);

            if (entity != null)
                _dbSet.Remove(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Attach(entity);
            _dbSet.Remove(entity);
        }

        public T Get(int id)
        {
            return _dbSet.Find(id) as T;
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            D.Entry(entity).State = EntityState.Modified;
        }
    }
}
