using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Structural.Adapter
{
    public class Adaptee
    {
        public string GetSpecification()
        {
            return "Specific request...";
        }
    }
}
