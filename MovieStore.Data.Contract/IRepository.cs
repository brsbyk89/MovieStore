using MovieStore.Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Data.Contract
{
    public interface IRepository<T> where T : ModelBase
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        T Get(int id);
    }
}
