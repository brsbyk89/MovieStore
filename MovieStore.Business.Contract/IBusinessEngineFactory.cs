﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Business.Contract
{
    public interface IBusinessEngineFactory 
    {
        T GetBusinessEngine<T>() where T : IBusinessEngine; 
    }
}
