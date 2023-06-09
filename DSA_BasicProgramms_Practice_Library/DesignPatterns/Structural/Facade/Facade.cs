using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Structural.Facade
{
    public class Facade
    {
        protected SubSystem1 _subSystem1;
        protected Subsystem2 _subSystem2;

        public Facade(SubSystem1 subSystem1, Subsystem2 subSystem2)
        {
            this._subSystem1 = subSystem1;
            this._subSystem2 = subSystem2;
        }

        public string Operation()
        {
            string result = "Facade intilizes subsystems:\n";
            result += this._subSystem1.Operation1();
            result += this._subSystem2.Operation1();

            result += "Facade orders subsyetms to perform the action:\n";
            result += this._subSystem1.OperationN();
            result += this._subSystem2.OperationZ();

            return result;
        }
    }
}
