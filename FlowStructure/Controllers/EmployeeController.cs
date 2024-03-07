using FlowStructure.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FlowStructure.Controllers
{
    public class EmployeeController : ApiController
    {
        IEmployeeService _employee;

        public EmployeeController()
        {

            _employee = StructuralMapConfigurator.GetInstance<IEmployeeService>();
        }

        public int GetAll()
        {
            return 10;
        }
    }
}
