﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string MailingAdress { get; set; }

        public Employee()
        { 
        }
        public Employee(int id, string firstName, string lastName, string jobTitle, string mailingAdress)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
            MailingAdress = mailingAdress;
        }
    }
}