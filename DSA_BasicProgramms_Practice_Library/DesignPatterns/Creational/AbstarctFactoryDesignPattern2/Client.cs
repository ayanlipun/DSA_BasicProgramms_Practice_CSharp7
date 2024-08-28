using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.AbstarctFactoryDesignPattern2
{
    public class Client
    {
        private readonly ICar _car;
        private readonly ITruck _truck;

        public Client(IvehicleFactory factory)
        {
            _car = factory.CreateCar();
            _truck = factory.CreateTruck();
        }

        public void Run()
        {
            _car.Drive();
            _truck.Haul();
        }
    }
}
