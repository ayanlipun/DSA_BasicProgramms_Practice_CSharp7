﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.LINQ.LeftOuterJoin
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { ID = 1, Name = "Preety", AddressId = 1},
                new Employee { ID = 2, Name = "Priyanka", AddressId =2},
                new Employee { ID = 3, Name = "Anurag", AddressId = 0},
                new Employee { ID = 4, Name = "Pranaya", AddressId = 0},
                new Employee { ID = 5, Name = "Hina", AddressId = 5},
                new Employee { ID = 6, Name = "Sambit", AddressId = 6}
            };
        }
    }
}
