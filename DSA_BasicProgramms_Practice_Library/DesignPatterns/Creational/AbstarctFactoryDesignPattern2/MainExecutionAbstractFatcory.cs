using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.AbstarctFactoryDesignPattern2
{
    public class MainExecutionAbstractFatcory
    {

        public void MainExecutionAbstractFatcoryMainMethod()
        {
            IvehicleFactory teslaFactory = new TeslaFactory();
            Client teslaClient = new Client(teslaFactory);
            teslaClient.Run();

            IvehicleFactory fordFactory = new FordFactory();
            Client fordClient = new Client(fordFactory);
            fordClient.Run();
        }
    }
}
