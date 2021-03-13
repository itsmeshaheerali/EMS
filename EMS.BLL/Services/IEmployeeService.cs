using EMS.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BLL.Services
{
    public interface IEmployeeService
    {
        List<EmployeeDTO> GetAll();
        EmployeeDTO GetById(int id);
        void Create(EmployeeDTO employee);
        void Update(EmployeeDTO employee);
        void Delete(int id);
    }
}
