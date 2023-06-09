using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Structural.Adapter
{
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee= adaptee;
        }
        public string GetRequest()
        {
            return $"This is {this._adaptee.GetSpecification()}";
        }
    }
}
