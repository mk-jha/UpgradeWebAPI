using DotNetCoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebAPI.EmployeeData
{
    public interface IEmployeeData
    {
        Employee AddEmployee(Employee employee);
        List<Employee> GetEmployees();
        Employee GetEmployee(Guid id);
    }
}
