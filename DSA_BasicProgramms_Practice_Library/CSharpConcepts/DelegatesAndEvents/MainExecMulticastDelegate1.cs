using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.DelegatesAndEvents
{
    public delegate void MathDelegate(int No1, int No2);
    public class MainExecMulticastDelegate1
    {
        //Static
        public static void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
        }
        //Static
        public static void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
        }
        //Non-Static
        public void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
        }
        //Non-Static 
        public void Div(int x, int y)
        {
            Console.WriteLine($"Division of {x} and {y} is : {x / y}");
        }
       public static void ExecMulticastDelegate1()
        {
            MainExecMulticastDelegate1 p = new MainExecMulticastDelegate1();

            MathDelegate del1 = new MathDelegate(Add);

            MathDelegate del2 = new MathDelegate(MainExecMulticastDelegate1.Sub);            
            MathDelegate del3 = new MathDelegate(p.Mul);
            MathDelegate del4 = new MathDelegate(p.Div);
           
            MathDelegate del5 = del1 + del2 + del3 + del4;
            Delegate[] InvocationList = del5.GetInvocationList();
            Console.WriteLine("InvocationList:");
            foreach (var item in InvocationList)
            {
                Console.WriteLine($" {item}");
            }
            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate::");
            del5.Invoke(20, 5);
            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate After Removing one Delegate:");
            del5 -= del2;
            del5(22, 7);
            Console.ReadKey();
        }
    }
}
