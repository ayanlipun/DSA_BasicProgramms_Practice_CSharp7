using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.AbstarctFactoryDesignPattern2
{
    // concrete product A1
    public class TeslaCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving tesla car");
        }
    }

    // concrete product A2
    public class FordCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving ford car"); ;
        }
    }


    // concrete product B1
    public class TeslaTruck : ITruck
    {
        public void Haul()
        {
            Console.WriteLine("Hauling with tesla truck.");
        }
    }


    // concrete product B2
    public class FordTruck : ITruck
    {
        public void Haul()
        {
            Console.WriteLine("Hauling with ford truck.");
        }
    }
}
