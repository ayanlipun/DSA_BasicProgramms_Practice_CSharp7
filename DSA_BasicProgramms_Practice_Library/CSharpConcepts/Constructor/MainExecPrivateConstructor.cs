using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Constructor
{
    public class MainExecPrivateConstructor
    {
        public static void ExecMainExecPrivateConstructor()
        {
            Child obj = new Child();
        }
    }

    public class Parent
    {
        //Private Constructor
        private Parent()
        {
            Console.WriteLine("Parent Class Private Constructor is Called");
        }
        //Public Constructor
        public Parent(string Message)
        {
            Console.WriteLine("Parent Class Public Constructor is Called");
        }
    }
    public class Child : Parent
    {
        public Child() : base("Hello")
        {
            Console.WriteLine("Child Class Public Constructor is Called");
        }
    }
}
