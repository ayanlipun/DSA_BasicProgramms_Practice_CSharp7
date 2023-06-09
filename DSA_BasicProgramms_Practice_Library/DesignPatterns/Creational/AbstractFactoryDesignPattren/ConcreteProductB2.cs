using DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.AbstractFactoryDesignPattren.Intrefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.AbstractFactoryDesignPattren
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"The result of the B1 collaborating with the ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of the product B2.";
        }
    }
}
