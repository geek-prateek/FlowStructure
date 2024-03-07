using FlowStructure.Data;
using FlowStructure.Repository;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowStructure.Service
{
    public class StructuralMapConfigurator
    {
        public static Container container;
        public static bool isOk;

        public static void getFunc()
        {
            container = new Container(x =>
            {
                x.For<IRepository<Company>>().Use(() => new Repository<Company>());
                // Company instace
            });
            isOk = true;
        }

        public static T GetInstance<T>()
        {
            if (!isOk)
                getFunc(); //true
            return container.GetInstance<T>();
        }
        /*
        public static Company GetInstance<Company>()
        {
            if (!isOk)
                getFunc(); //True
            return container.GetInstance<Company>();
        }
        */
    }
}
