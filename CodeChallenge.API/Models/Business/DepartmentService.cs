using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.API.Models.Business
{
    public class DepartmentService
    {
        private IList<Department> departments = new List<Department>();

        private Department department1, department2;

        public void InitializeDepartments()
        {
            department1 = new Department(1, "Department of actors", "Somewhere in the US");
            department2 = new Department(2, "Department of singers", "Somewhere in the UK");

            LoadDepartmentsList();
        }

        public IList<Department> ListAllDepartments()
        {
            return departments;
        }
        public void LoadEmployeesList(IList<Employee> employees)
        {
            foreach (var employee in employees)
            {
                AddEmployeeToDepartment(employee);
            }
        }

        private void LoadDepartmentsList()
        {
            departments.Add(department1);
            departments.Add(department2);
        }

        private void AddEmployeeToDepartment(Employee employee)
        {
            foreach (var department in departments)
            {
                if (employee.DepartmentId == department.Id)
                    department.Employees.Add(employee);            
            }
        }

    }

}
