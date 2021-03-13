using AutoMapper;
using EMS.BLL.DTO;
using EMS.DAL.Entities;
using EMS.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public void Create(EmployeeDTO employee)
        {
            var empObj = _mapper.Map<Employee>(employee);
            _employeeRepository.Create(empObj);
        }

        public void Delete(int id)
        {
            _employeeRepository.Delete(id);
        }

        public List<EmployeeDTO> GetAll()
        {
            var employees = _employeeRepository.GetAll();
            return _mapper.Map<List<EmployeeDTO>>(employees);
        }

        public EmployeeDTO GetById(int id)
        {
            var employee = _employeeRepository.Get(id);
            return _mapper.Map<EmployeeDTO>(employee);
        }

        public void Update(EmployeeDTO employee)
        {
            var empObj = _mapper.Map<Employee>(employee);
            _employeeRepository.Update(empObj);
        }
    }
}
