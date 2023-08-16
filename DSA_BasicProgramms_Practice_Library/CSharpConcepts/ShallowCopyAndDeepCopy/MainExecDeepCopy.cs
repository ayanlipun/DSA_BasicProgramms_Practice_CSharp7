using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DSA_BasicProgramms_Practice_Library.CSharpConcepts.ShallowCopyAndDeepCopy.EmployeeDeep;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.ShallowCopyAndDeepCopy
{
    public class MainExecDeepCopy
    {
        public static void ExecMainExecDeepCopy()
        {
            EmployeeDeep employee = new EmployeeDeep
            {
                Name = "Winsome",
                Department = "Software",
                EmpAddress = new AddressDeep { Name = "Bangalore" }
            };

            EmployeeDeep employee1 = employee.GetClone();

            employee1.Name = "Basket";
            employee1.EmpAddress.Name = "Hyderabad";
            employee1.Department = "BPO";

            Console.WriteLine("Employee 1:");
            Console.WriteLine("Name:" + employee.Name + " Address:" + employee.EmpAddress.Name + " Department:" + employee.Department);
            Console.WriteLine("Employee 2:");
            Console.WriteLine("Name:" + employee1.Name + " Address:" + employee1.EmpAddress.Name + " Department:" + employee1.Department);

        }
    }
    public class EmployeeDeep
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public AddressDeep EmpAddress { get; set; }

        //Creating a Cloned Object of the Current Object
        public EmployeeDeep GetClone()
        {
            EmployeeDeep employee = (EmployeeDeep)this.MemberwiseClone();
            employee.EmpAddress = EmpAddress.GetClone();
            return employee;
        }

        public class AddressDeep
        {
            public string Name { get; set; }
            public AddressDeep GetClone()
            {
                return (AddressDeep)this.MemberwiseClone();
            }
        }
    }
}
