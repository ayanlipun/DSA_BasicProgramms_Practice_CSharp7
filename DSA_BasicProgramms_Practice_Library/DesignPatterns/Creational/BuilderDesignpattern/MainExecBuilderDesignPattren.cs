using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.BuilderDesignpattern
{
    public class MainExecBuilderDesignPattren
    {
        public static void GetBuilderDesignPattrenExecution()
        {
            var director = new Director();
            var builder = new ConcreteBuilder();


            director.Builder = builder;

            Console.WriteLine("Standard basic prodcut :");
            director.BuildMinimalVariableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeatureProduct();
            Console.WriteLine(builder.GetProduct().ListParts());


            Console.WriteLine("Custom products :");
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
            Console.WriteLine(builder.GetProduct().ListParts());
        }
    }
}
