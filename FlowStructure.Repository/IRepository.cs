using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowStructure.Repository
{
    public interface IRepository<T>
    {
        List<T> Getall();
        T GetById(int id);

        int Save(T entity);
    }
}
