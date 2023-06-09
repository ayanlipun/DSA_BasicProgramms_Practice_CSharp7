using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Structural.Adapter2
{
    public class Compound
    {
        protected float boilingPoint;
        protected float meltingPoint;
        protected double molecularWeight;
        protected string molecularFormula;


        public virtual void Display()
        {
            Console.WriteLine("\nCompound: Unknown-----------");
        }
    }
}
