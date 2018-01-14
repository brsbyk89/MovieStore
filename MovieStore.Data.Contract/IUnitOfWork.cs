﻿using MovieStore.Business.Entities;
using MovieStore.Data.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Data.Contract
{
    public interface IUnitOfWork : IDisposable
    {
        //Repository<T> GetRepository<T>() where T : ModelBase;   
        int SaveChanges(); 
    }
}
