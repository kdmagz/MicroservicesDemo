using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Model
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployee();
        Employee GetEmployeeById(int Id);
        Employee AddEmployee(Employee employee);
    }
}
