using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.FluentApi
{
    public class MainExecutionFluentApi
    {
        public static void ExecFluentApi()
        {
            FluentEmployee fluentEmployee = new FluentEmployee();
            fluentEmployee.NameOfTheEmployee("Ayan").Born("10/20/2015").WorkingOn("IT").StaysAt("Bengaluru");           
        }
    }
}
