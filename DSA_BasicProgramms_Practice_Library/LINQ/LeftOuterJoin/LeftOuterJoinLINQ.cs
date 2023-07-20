using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.LINQ.LeftOuterJoin
{
    public class LeftOuterJoinLINQ
    {
        public static void ExecLeftOuterJoinLINQ()
        {
            ExecLeftOuterJoinLINQMethodBased();
            ExecLeftOuterJoinLINQQueryBased();
        }


        public static void ExecLeftOuterJoinLINQMethodBased()
        {
            var result = Employee.GetAllEmployees() //Left Data Source, Performing Group join with Right Data Source
                                 .GroupJoin(
                                       Address.GetAddress(), //Right Data Source
                                       employee => employee.AddressId, //Outer Key Selector, i.e. Left Data Source Common Property
                                       address => address.ID, //Inner Key Selector, i.e. Right Data Source Common Property
                                       (employee, address) => new { employee, address } //Projecting the Result
                                 )
                                 .SelectMany(
                                       x => x.address.DefaultIfEmpty(), //Performing Left Outer Join 
                                       (employee, address) => new { employee, address } //Final Result Set
                                  );
            //Accessing the Elements using For Each Loop
            foreach (var item in result)
            {
                Console.WriteLine($"Name : {item.employee.employee.Name}, Address : {item.address?.AddressLine} ");
            }
        }

        public static void ExecLeftOuterJoinLINQQueryBased()
        {
            var result = from emp in Employee.GetAllEmployees() //Left Data Source
                         join add in Address.GetAddress() //Right Data Source
                         on emp.AddressId equals add.ID //Inner Join Condition
                         into EmployeeAddressGroup //Performing LINQ Group Join
                         from address in EmployeeAddressGroup.DefaultIfEmpty() //Performing Left Outer Join
                         select new { emp, address }; //Projecting the Result to Anonymous Type, Accessing the Elements using For Each Loop
            foreach (var item in result)
            {
                //Before Accessing the AddressLine, please check null else you will get Null Reference Exception
                Console.WriteLine($"Name : {item.emp.Name}, Address : {item.address?.AddressLine} ");
            }
        }
    }
}
