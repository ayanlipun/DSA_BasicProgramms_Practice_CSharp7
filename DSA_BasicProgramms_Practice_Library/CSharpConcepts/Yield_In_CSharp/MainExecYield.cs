using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Yield_In_CSharp
{
    public class MainExecYield
    {
        public static void GetYieldOutput()
        {
            foreach (var items in YieldLogicSection.getNumber())
            {
                Console.WriteLine(items);
            }
        }
    }
}
