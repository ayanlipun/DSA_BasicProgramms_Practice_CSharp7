using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Constructor
{
    public class MainExecStaticAndNonStaticConstructor1
    {
        public static void ExecMainExecStaticAndNonStaticConstructor1()
        {
            Console.WriteLine("Main Method Started");
            ConstructorsDemo obj1 = new ConstructorsDemo();
            ConstructorsDemo obj2 = new ConstructorsDemo();
            ConstructorsDemo obj3 = new ConstructorsDemo();
            Console.WriteLine("Main Method Completed");
        }
    }
}

public class ConstructorsDemo
{
    public static int x; //It is going to be initialized by static constructor
    public int y; //It is going to be initialized by non-static constructor

    //Static Constructor
    static ConstructorsDemo()
    {
        //This constructor initialized the static variable x with default value i.e. 0
        Console.WriteLine("Static Constructor is Called");
    }
    //Non-Static Constructor
    public ConstructorsDemo()
    {
        //This constructor initialized the static variable y with default value i.e. 0
        Console.WriteLine("Non-Static Constructor is Called");
    }
}

