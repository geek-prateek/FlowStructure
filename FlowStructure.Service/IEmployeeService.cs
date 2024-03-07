using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowStructure.Service
{
    public interface IEmployeeService
    {
        void GetEmployee();
        void GetEmployeeById(int id);
        void Save();
    }
}
