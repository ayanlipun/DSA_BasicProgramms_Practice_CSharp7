/*
    Parameter Optional Using OptionalAttribute
 */

using System.Runtime.InteropServices;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Optional_Paramaters
{
    public class MainExecOptionalParamaters5
    {
        public static void ExecMainExecOptionalParamaters5()
        {
            ADDNumbers(10, 20);
            ADDNumbers(10, 20, new int[] { 30, 40, 50 });
        }

        public static void ADDNumbers(int FN, int SN, [Optional] int[] restOfTheNumbers)
        {
            int result = FN + SN;           
            if (restOfTheNumbers != null)
            {
                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Total = " + result.ToString());
        }
    }
}
