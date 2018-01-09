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
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SQLDBContext _dbContext;
        private bool disposed = false;

        public UnitOfWork(SQLDBContext dbContext)
        {
            Database.SetInitializer<SQLDBContext>(null);

            if (dbContext == null)
                throw new ArgumentNullException("dbContext can not be null.");

            _dbContext = dbContext;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new EntityFrameworkRepository<T>(_dbContext);

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
