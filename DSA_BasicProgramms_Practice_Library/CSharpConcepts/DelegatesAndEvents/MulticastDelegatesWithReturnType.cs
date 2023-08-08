using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.DelegatesAndEvents
{
    public delegate int SampleDelegate();
    public class MulticastDelegatesWithReturnType
    {
        public static void ExecMulticastDelegatesWithReturnType()
        {
            SampleDelegate del = new SampleDelegate(MethodOne);
            del += MethodTwo;

            // The Value Returned By Delegate will be 2, returned by the MethodTwo(),
            // as it is the last method in the invocation list.
            int ValueReturnedByDelegate = del();
            Console.WriteLine($"Returned Value = {ValueReturnedByDelegate}");
        }
        public static int MethodOne()
        {
            Console.WriteLine("MethodOne is Executed");
            return 1;
        }
       
        public static int MethodTwo()
        {
            Console.WriteLine("MethodTwo is Executed");
            return 2;
        }
    }
}
