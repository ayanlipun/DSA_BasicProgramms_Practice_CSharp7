/*
 Parameters Optional by Specifying Parameter Defaults
 */

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Optional_Paramaters
{
    public class MainExecOptionalParamaters3
    {
        public static void ExecMainExecOptionalParamaters3()
        {
            ADDNumbers(10, 20);       
            ADDNumbers(10, 20, new int[] { 30, 40, 50 });
        }

        public static void ADDNumbers(int FN, int SN, int[] restOfTheNumbers = null)
        {
            int result = FN + SN;
            //Loop through the restOfTheNumbers only if it is not null else we will get runtime error
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
