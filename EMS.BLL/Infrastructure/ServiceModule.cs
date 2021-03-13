using EMS.DAL.Entities;
using EMS.DAL.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<aezion_emsEntities>().To<aezion_emsEntities>();
            Bind<IEmployeeRepository>().To<EmployeeRepository>();
        }
    }
}
