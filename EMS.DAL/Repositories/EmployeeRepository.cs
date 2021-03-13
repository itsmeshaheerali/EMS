using EMS.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DAL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly aezion_emsEntities _context;

        public EmployeeRepository(aezion_emsEntities dbContext)
        {
            _context = dbContext;
        }

        public void Create(Employee employee)
        {
            if(employee == null)
            {
                return;
            }

            _context.Entry(employee).State = System.Data.Entity.EntityState.Added;

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = _context.Employees.Find(id);
            if(employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }

        public Employee Get(int id)
        {
            return _context.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public void Update(Employee employee)
        {
            var existing = _context.Employees.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);

            if(existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(employee);
                _context.SaveChanges();
            }

        }
    }
}
