using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.API.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Employee> Employees { get; set; }

        public Department(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
            Employees = new List<Employee>();
        }
    }
}
