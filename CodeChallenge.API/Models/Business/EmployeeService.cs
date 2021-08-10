using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.API.Models.Business
{
    public class EmployeeService
    {
        public Employee employee1, employee2;
        public IEnumerable<Employee> GetAll() 
        {
            return ListAll();
        }

        public IList<Employee> ListAll() 
        {
            InicializeEmployees();

            IList<Employee> employees = new List<Employee>();

            employees.Add(employee1);
            employees.Add(employee2);

            return employees;
        }

        private void InicializeEmployees()
        {
            employee1 = new Employee(1, "Keanu", "Reeves", "actor", "Somewhere in the US");
            employee2 = new Employee(1, "Paul", "McCartney", "singer", "Somewhere in the UK");
        }
    }
}

