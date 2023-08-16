/*
    Named Parameters 
 */

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Optional_Paramaters
{
    public class MainExecOptionalParamaters4
    {
        public static void ExecMainExecOptionalParamaters4()
        {
            Test(1, 2); //a = 1 and b = 2 and c = 20 by default value
            Test(1, c: 2); //a = 1 and b = 10 by default and c = 2
            //Order is not Important with Named Parameter
            Test(b: 1, c: 2, a: 10);
        }

        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine($"a = {a}, b = {b}, c= {c}");
        }
    }
}
