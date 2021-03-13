using EMS.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DAL.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee Get(int id);
        void Create(Employee employee);

        void Update(Employee employee);

        void Delete(int id);
    }
}
