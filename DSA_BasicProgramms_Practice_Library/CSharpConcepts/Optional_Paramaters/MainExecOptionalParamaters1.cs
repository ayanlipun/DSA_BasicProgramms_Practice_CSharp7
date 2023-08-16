/* 
 *** By using params object[] 
*/

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Optional_Paramaters
{
    public class MainExecOptionalParamaters1
    {
        public static void ExecMainExecOptionalParamaters1()
        {
            ADDNumbers(10, 20);
            ADDNumbers(10, 20, 30, 40);
            ADDNumbers(10, 20, new object[] { 30, 40, 50 });
        }
        public static void ADDNumbers(int FN, int SN, params object[] restOfTheNumbers)
        {
            int result = FN + SN;
            foreach (int i in restOfTheNumbers)
            {
                result += i;
            }
            Console.WriteLine("Total = " + result.ToString());
        }
    }
}
