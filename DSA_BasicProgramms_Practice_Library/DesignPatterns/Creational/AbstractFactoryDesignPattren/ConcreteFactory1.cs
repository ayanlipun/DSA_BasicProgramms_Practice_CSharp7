using DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.AbstractFactoryDesignPattren;
using DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.AbstractFactoryDesignPattren.Intrefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.AbstractFactoryDesignPattren
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
