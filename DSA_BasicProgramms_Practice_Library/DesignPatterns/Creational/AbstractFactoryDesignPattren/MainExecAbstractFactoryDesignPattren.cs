using DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.AbstractFactoryDesignPattren.Intrefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.AbstractFactoryDesignPattren
{
    public class MainExecAbstractFactoryDesignPattren
    {
        public static void GetAbstractFactoryDesignpattrenExecution()
        {
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing client code with the second factory type...");
            ClientMethod(new ConcreteFactory2());
            Console.WriteLine();
        }

        public static void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
