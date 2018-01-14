using MovieStore.Business.Entities;
using MovieStore.Data;
using MovieStore.Data.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Data
{
    //public class UnitOfWork : IUnitOfWork
    public class UnitOfWork : IDisposable
    {
        private readonly SQLDBContext _dbContext;
        private bool disposed = false;
        private Dictionary<string, object> repositories;

        public UnitOfWork(SQLDBContext dbContext)
        {
            Database.SetInitializer<SQLDBContext>(null);

            if (dbContext == null)
                throw new ArgumentNullException("dbContext can not be null.");

            _dbContext = dbContext;
        }

        public Repository<T> GetRepository<T>() where T : ModelBase
        {
            if (repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Repository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _dbContext);
                repositories.Add(type, repositoryInstance);
            }
            return (Repository<T>)repositories[type];

        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }

            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
