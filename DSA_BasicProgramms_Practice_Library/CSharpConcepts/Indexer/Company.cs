using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Indexer
{
    public class Company
    {
        private List<Employee> listEmployees = new List<Employee>();

        //Through the constructor initialize the listEmployees variable
        public Company()
        {
            listEmployees.Add(new Employee { EmployeeId = 101, Name = "Pranaya", Gender = "Male", Salary = 1000 });
            listEmployees.Add(new Employee { EmployeeId = 102, Name = "Preety", Gender = "Female", Salary = 2000 });
            listEmployees.Add(new Employee { EmployeeId = 103, Name = "Anurag", Gender = "Male", Salary = 5000 });
            listEmployees.Add(new Employee { EmployeeId = 104, Name = "Priyanka", Gender = "Female", Salary = 4000 });
            listEmployees.Add(new Employee { EmployeeId = 105, Name = "Hina", Gender = "Female", Salary = 3000 });
            listEmployees.Add(new Employee { EmployeeId = 106, Name = "Sambit", Gender = "Male", Salary = 6000 });
            listEmployees.Add(new Employee { EmployeeId = 107, Name = "Tarun", Gender = "Male", Salary = 8000 });
            listEmployees.Add(new Employee { EmployeeId = 108, Name = "Santosh", Gender = "Male", Salary = 7000 });
            listEmployees.Add(new Employee { EmployeeId = 109, Name = "Trupti", Gender = "Female", Salary = 5000 });
        }

        // Integer Indexer
        public string this[int employeeId]
        {
            get
            {
                return listEmployees.FirstOrDefault(z => z.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.FirstOrDefault(z => z.EmployeeId == employeeId).Name = value;
            }
        }


        public string this[string gender]
        {
            get
            {
                return listEmployees.Count(x => x.Gender.ToLower() == gender.ToLower()).ToString();
            }
            set
            {
                foreach (Employee employee in listEmployees)
                {
                    if (employee.Gender == gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }
    }
}
