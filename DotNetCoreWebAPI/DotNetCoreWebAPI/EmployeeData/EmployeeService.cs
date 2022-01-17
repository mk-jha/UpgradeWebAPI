using DotNetCoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebAPI.EmployeeData
{
    public class EmployeeService: IEmployeeData
    {
        private EmployeeContext _employeeContext;
        public EmployeeService(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            _employeeContext.Employees.Add(employee);
            _employeeContext.SaveChanges();
            return employee;
        }
        public List<Employee> GetEmployees()
        {
            return _employeeContext.Employees.ToList();
        }
        public Employee GetEmployee(Guid id)
        {
            var employee= _employeeContext.Employees.Find(id);
            return employee;
        }
    }
}
