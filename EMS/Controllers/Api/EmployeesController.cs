using EMS.BLL.DTO;
using EMS.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EMS.Controllers.Api
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public List<EmployeeDTO> GetEmployees()
        {
            return _employeeService.GetAll();
        }

        [HttpGet]
        public EmployeeDTO GetEmployee(int id)
        {
            return _employeeService.GetById(id);
        }

        [HttpPost]
        public void PostEmployee(EmployeeDTO employeeDTO)
        {
            _employeeService.Create(employeeDTO);
        }

        [HttpDelete]
        public void DeleteEmployee(int id)
        {
            _employeeService.Delete(id);
        }
    }
}
