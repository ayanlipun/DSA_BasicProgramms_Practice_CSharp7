using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.FactoryDesignPattern
{
    public interface IProduct
    {
        string Operation();
    }


    class ConcreateProdcutA : IProduct
    {
        public ConcreateProdcutA()
        {
            Console.WriteLine("ConcreateProdcutA  instance creation!!");
        }
        public string Operation()
        {
            return "{Result of Concreate prodcut-A}";
        }
    }

    class ConcreateProdcutB : IProduct
    {
        public ConcreateProdcutB()
        {
            Console.WriteLine("ConcreateProdcutB  instance creation!!");
        }
        public string Operation()
        {
            return "{Result of Concreate prodcut-B}";
        }
    }

}
