using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.API.Models.Business
{
    public class EmployeeService
    {
        private DepartmentService departmentService;

        private IList<Employee> employees;

        private Employee employee1, employee2, employee3;

        public EmployeeService()
        {
            departmentService = new DepartmentService();
            
            employees = new List<Employee>();

            InitializeDepartments();

            InitializeEmployees();

            LoadEmployeesListOfDepartments();
        }
        public IEnumerable<Employee> GetAll() 
        {
            return ListAll();
        }

        public IList<Employee> ListAll() 
        {
            return employees;
        }

        public IList<Employee> GetAllEmployeesByDepartment(int departmentId)
        {
            IList<Employee> employeesByDepartment = new List<Employee>();

            IList<Department> departments = departmentService.ListAllDepartments();

            foreach( var department in departments) 
            {
                if (department.Id == departmentId)
                    employeesByDepartment = department.Employees;
            }           

            return employeesByDepartment;
        }

        private void InitializeDepartments()
        {
            departmentService.InitializeDepartments();
        }
        private void InitializeEmployees()
        {
            employee1 = new Employee(1, "Keanu", "Reeves", "actor", "Somewhere in the US", 1);
            employee2 = new Employee(2, "Paul", "McCartney", "singer", "Somewhere in the UK", 2);
            employee3 = new Employee(3, "Ed", "Sheeran", "singer", "Somewhere in the UK", 2);

            LoadEmployeesList();

        }
        private void LoadEmployeesList()
        {
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
        }

        private void LoadEmployeesListOfDepartments()
        {
            departmentService.LoadEmployeesList(employees);
        }
    }
}

