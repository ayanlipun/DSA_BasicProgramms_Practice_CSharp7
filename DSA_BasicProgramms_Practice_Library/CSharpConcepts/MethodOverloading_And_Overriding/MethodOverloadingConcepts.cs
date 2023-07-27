using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.MethodOverloading_And_Overriding
{
    public class MethodOverloadingConcepts
    {
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public static decimal AddNumbers(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
