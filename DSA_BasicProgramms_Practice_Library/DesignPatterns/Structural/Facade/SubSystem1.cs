using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Structural.Facade
{
    public class SubSystem1
    {
        public string Operation1()
        {
            return "Subsystem1 :  Ready!\n";
        }

        public string OperationN()
        {
            return "Subsystem1 :  Go!\n";
        }
    }
}
