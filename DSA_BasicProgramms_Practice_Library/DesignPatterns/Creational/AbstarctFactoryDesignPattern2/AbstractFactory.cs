using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.AbstarctFactoryDesignPattern2
{
    public interface IvehicleFactory
    {
        ICar CreateCar();
        ITruck CreateTruck();
    }
}
