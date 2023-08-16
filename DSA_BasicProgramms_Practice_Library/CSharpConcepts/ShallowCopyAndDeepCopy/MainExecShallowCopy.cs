using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.ShallowCopyAndDeepCopy
{
    public class MainExecShallowCopy
    {
        public static void ExecMainExecShallowCopy()
        {
            Employee employee = new Employee
            {
                Name = "Winsome",
                Department = "Software",
                EmpAddress = new Address { Name = "Bangalore" }
            };

            Employee employee1 = employee.GetClone();

            employee1.Name = "Basket";
            employee1.EmpAddress.Name = "Hyderabad";
            employee1.Department = "BPO";

            Console.WriteLine("Employee 1:");
            Console.WriteLine("Name:" + employee.Name + " Address:" + employee.EmpAddress.Name + " Department:" + employee.Department);
            Console.WriteLine("Employee 2:");
            Console.WriteLine("Name:" + employee1.Name + " Address:" + employee1.EmpAddress.Name + " Department:" + employee1.Department);
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Address EmpAddress { get; set; }

        public Employee GetClone()
        {
            return (Employee)this.MemberwiseClone();
        }
    }

    public class Address
    {
        public string Name { get; set; }
    }
}
