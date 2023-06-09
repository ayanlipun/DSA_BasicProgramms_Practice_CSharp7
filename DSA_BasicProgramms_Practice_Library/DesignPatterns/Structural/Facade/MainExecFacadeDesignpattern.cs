using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Structural.Facade
{
    public class MainExecFacadeDesignpattern
    {
        public static void GetFacadeDesignpattrenExecution()
        { 
            SubSystem1 subSystem1= new SubSystem1();
            Subsystem2 subsystem2   = new Subsystem2 ();

            Facade facade = new Facade (subSystem1, subsystem2);
            Client.ClientCode(facade);
        }
    }
}
