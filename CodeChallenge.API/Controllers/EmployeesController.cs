using CodeChallenge.API.Models;
using CodeChallenge.API.Models.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.API.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IList<Employee>> Get()
        {
            var employees = GetEmployees();
            return employees.ToList();
        }

        // GET api/values
        [HttpGet("department/{departmentId}")]
        public ActionResult<IList<Employee>> Get(int departmentId)
        {
            var employees = GetEmployees(departmentId);
            return employees.ToList();
        }

        private IList<Employee> GetEmployees() 
        {
            EmployeeService employeeService = new EmployeeService();

            return employeeService.ListAll();

        }
        private IEnumerable<Employee> GetEmployees(int departmentId)
        {
            EmployeeService employeeService = new EmployeeService();

            return employeeService.GetAllEmployeesByDepartment(departmentId);

        }
    }
}
