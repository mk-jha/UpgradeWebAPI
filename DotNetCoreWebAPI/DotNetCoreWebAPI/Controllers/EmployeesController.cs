using DotNetCoreWebAPI.EmployeeData;
using DotNetCoreWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    
    public class EmployeesController : ControllerBase
    {
        private IEmployeeData _employeeData;
        public EmployeesController(IEmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(_employeeData.GetEmployees());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetEmployee(Guid id)
        {
            var employee = _employeeData.GetEmployee(id);
            if (employee != null)
            {
                return Ok(_employeeData.GetEmployee(id));
            }
            return NotFound("Employee does not found");

        }


        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeData.AddEmployee(employee);
            return Created(employee.Id.ToString(), employee);

        }
    }
}
