using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Yield_In_CSharp
{
    public class YieldLogicSection
    {
        public static IEnumerable<int> getNumber()
        {
            // create a list of integers 
            List<int> myList = new List<int> { -1, -4, 3, 5 };

            foreach (var num in myList)
            {
                // returns positive number from myList 
                if (num >= 0)
                {
                    yield return num;

                    // location of the code is preserved 
                    // so on the next iteration getNumber() is executed from here 
                    Console.WriteLine("....");
                }
            }
        }
    }
}
