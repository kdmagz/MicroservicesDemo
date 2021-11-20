using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Model
{
    public class EmpoyeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public EmpoyeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public List<Employee> GetAllEmployee()
        {
            return _context.employees.ToList();
        }

        public Employee GetEmployeeById(int Id)
        {
            return _context.employees.FirstOrDefault(emp => emp.Id == Id);
        }
    }
}
