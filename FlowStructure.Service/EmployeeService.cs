using FlowStructure.Data;
using FlowStructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowStructure.Service
{
    public class EmployeeService: IEmployeeService
    {
        IRepository<Company> _employee;

        public EmployeeService()
        {
            _employee = StructuralMapConfigurator.GetInstance<IRepository<Company>>();
            //_employee = Company;
        }

        public void GetEmployee()
        {
            _employee
        }

        public void GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
