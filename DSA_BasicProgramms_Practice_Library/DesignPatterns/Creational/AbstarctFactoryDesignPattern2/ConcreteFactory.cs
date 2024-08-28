using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.AbstarctFactoryDesignPattern2
{
    public class TeslaFactory : IvehicleFactory
    {
        public ICar CreateCar()
        {
          return new TeslaCar();
        }

        public ITruck CreateTruck()
        {
           return new TeslaTruck();
        }
    }

    public class FordFactory : IvehicleFactory
    {
        public ICar CreateCar()
        {
            return new FordCar();
        }

        public ITruck CreateTruck()
        {
            return new FordTruck();
        }
    }
}
