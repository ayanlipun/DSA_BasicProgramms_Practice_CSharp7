using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Constructor
{
    public class MainExecStaticAndNonStaticConstructor
    {
        static MainExecStaticAndNonStaticConstructor()
        {
            Console.WriteLine("Static Constructor is Called");
        }

        public MainExecStaticAndNonStaticConstructor()
        {
            Console.WriteLine("Non-Static Constructor is Called");
        }

        public static void ExecMainExecStaticAndNonStaticConstructor()
        {
            Console.WriteLine("Main Method Body..");
        }
    }
}
