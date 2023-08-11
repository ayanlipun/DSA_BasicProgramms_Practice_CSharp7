using DSA_BasicProgramms_Practice_Library.LINQ.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.LINQ.InnerJoin
{
    public class InnerJoinLINQ
    {
        public static void ExecInnerJoinLINQ()
        {
            var result = Employee.GetAllEmployees()
                .Join(Address.GetAllAddresses(),
                    employee => employee.AddressId,
                    address => address.ID,
                    (employee, address) => new
                    {
                        EmployeeName = employee.Name,
                        AddressLine = address.AddressLine
                    }).ToList();

            foreach (var employee in result)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }
        }
    }
}
