﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowStructure.Repository
{
    public class Repository<T> : IRepository<T>
    {
        public List<T> Getall()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            
            throw new NotImplementedException();
            
        }

        public int Save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
