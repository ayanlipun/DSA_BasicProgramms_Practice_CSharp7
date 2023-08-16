/*
    Method Overloading to Make Optional Parameter in C#
*/

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Optional_Paramaters
{
    public class MainExecOptionalParamaters2
    {
        public static void ExecMainExecOptionalParamaters2()
        {
            ADDNumbers(10, 20);
            ADDNumbers(10, 20, new int[] { 30, 40, 50 });
        }

        public static void ADDNumbers(int FN, int SN, int[] restOfTheNumbers)
        {
            int result = FN + SN;
            foreach (int i in restOfTheNumbers)
            {
                result += i;
            }
            Console.WriteLine("Total = " + result.ToString());
        }
        public static void ADDNumbers(int FN, int SN)
        {
            int result = FN + SN;
            Console.WriteLine("Total = " + result.ToString());
        }
    }
}
