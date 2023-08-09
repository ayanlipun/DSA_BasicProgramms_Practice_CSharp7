using DSA_BasicProgramms_Practice_Library.CSharpConcepts.FluentApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.FluentInterfaceDesignPattren
{
    public class MainExecFluentInterfaceDesignPattren
    {
        public static void ExecMainExecFluentInterfaceDesignPattren()
        {
            FluentEmployee obj = new FluentEmployee();
           
            obj.NameOfTheEmployee("Winsome Basket")
                    .Born("02/07/1992")
                    .WorkingOn("IT")
                    .StaysAt("Bangalore-India");
           
            obj.ShowDetails();
        }
    }
}
