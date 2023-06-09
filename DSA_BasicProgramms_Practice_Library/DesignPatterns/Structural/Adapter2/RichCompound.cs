using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Structural.Adapter2
{
    public class RichCompound : Compound
    {
        private string chemical;
        private ChemicalDatabank databank;

        public RichCompound(string chemical)
        {
            this.chemical = chemical;
        }

        public override void Display()
        {
            // Adapter

            databank= new ChemicalDatabank();

            boilingPoint = databank.GetCriticalPoint(chemical,"B");
            meltingPoint = databank.GetCriticalPoint(chemical, "M");
            molecularWeight=databank.GetMolecularWeight(chemical);
            molecularFormula=databank.GetMolecularStructure(chemical);

            Console.WriteLine("\nCompound: {0} ------ ", chemical);
            Console.WriteLine(" Formula: {0}", molecularFormula);
            Console.WriteLine(" Weight : {0}", molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", boilingPoint);
        }
    }
}
