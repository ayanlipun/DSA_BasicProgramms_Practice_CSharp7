using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.LINQ.Pagging
{
    public class PaggingLINQ
    {
        public static void ExecPaggingLINQ()
        {
            int RecordsPerPage = 4;           
            int PageNumber = 0;

            do
            {
                Console.WriteLine("\nEnter the Page Number Between 1 and 4");
                //Read the Value and if its integer type, then store that value in the PageNumber variable
                if (int.TryParse(Console.ReadLine(), out PageNumber))
                {
                    //Check if PageNumber is > 0 and < 5
                    if (PageNumber > 0 && PageNumber < 5)
                    {
                        //Logic to Implement Paging
                        var employees = Employee.GetAllEmployees() //Data Source
                                    .Skip((PageNumber - 1) * RecordsPerPage) //Skip Logic
                                    .Take(RecordsPerPage).ToList(); //Take Logic
                        Console.WriteLine();
                        Console.WriteLine("Page Number : " + PageNumber);
                        foreach (var emp in employees)
                        {
                            Console.WriteLine($"ID : {emp.ID}, Name : {emp.Name}, Department : {emp.Department}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nPlease Enter a Valid Page Number");
                    }
                }
                else
                {
                    Console.WriteLine("\nPlease Enter a Valid Page Number");
                }
            } while (true);
        }
    }
}
