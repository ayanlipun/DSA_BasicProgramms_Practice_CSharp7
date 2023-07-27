using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Asynchronous
{
    public class MainExecutionRetrydesignPattren
    {
        public static void ExecuteRetryDesignPattern()
        {
            Console.WriteLine("Main Method Started");
            RetryDesignPattern.RetryMethod();
            Console.WriteLine("Main Method Completed");            
        }
    }
}
