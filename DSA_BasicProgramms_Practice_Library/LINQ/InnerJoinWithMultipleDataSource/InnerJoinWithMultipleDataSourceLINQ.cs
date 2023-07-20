using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.LINQ.InnerJoinWithMultipleDataSource
{
    public class InnerJoinWithMultipleDataSourceLINQ
    {
        public static void ExecInnerJoinWithMultipleDataSource()
        {
            var result = Employee.GetAllEmployees()
                .Join(Address.GetAllAddresses(),
                empL1 => empL1.AddressId,
                addL1 => addL1.ID,
                (empL1, addL1) => new
                {
                    empL1,
                    addL1
                }).Join(Department.GetAllDepartments(),
                 empL2 => empL2.empL1.DepartmentId,
                 deptL1 => deptL1.ID,
                 (empL2, deptL1) => new
                 {
                     empL2,
                     deptL1
                 })
                .Select(data => new
                { 
                    ID =data.empL2.empL1.ID,
                    EmployeeName = data.empL2.empL1.Name,
                    AddressLine= data.empL2.addL1.AddressLine,
                    DepartmentName = data.deptL1.Name                
                }).ToList();

            foreach (var employee in result)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.EmployeeName}, Department = {employee.DepartmentName}, Addres = {employee.AddressLine}");
            }
        }
    }
}
