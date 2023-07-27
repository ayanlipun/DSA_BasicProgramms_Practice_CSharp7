using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.MethodOverloading_And_Overriding
{
    public class MainExecutionOverloadding
    {
        public static void ExecMainExecutionOverloadding()
        {
           var result = MethodOverloadingConcepts.AddNumbers(1, 2);
            Console.WriteLine($"Result is {result}");

            var result1 = MethodOverloadingConcepts.AddNumbers(1, 2,3);
            Console.WriteLine($"Result is {result1}");
        }
    }
}
