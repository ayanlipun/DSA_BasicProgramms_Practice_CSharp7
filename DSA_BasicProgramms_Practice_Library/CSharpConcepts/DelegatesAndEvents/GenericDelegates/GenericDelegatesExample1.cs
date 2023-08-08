using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.DelegatesAndEvents.GenericDelegates
{
    public class GenericDelegatesExample1
    {
        public static void ExecGenericDelegatesExample1()
        {
            Func<int, float, double, double> func = new Func<int, float, double, double>(AddNumber1);
            double result1 = func.Invoke(100, 125.45f, 456.789);
            Console.WriteLine(result1);

            Action<int, float, double> action = new Action<int, float, double>(AddNumber2);
            action.Invoke(100, 125.45f, 456.789);

            Predicate<string> predicate = new Predicate<string>(CheckLength);
            bool status = predicate.Invoke("WinsomeBasket");
            Console.WriteLine(status);
        }

        public static double AddNumber1(int no1, float no2, double no3)
        {
            return no1 + no2 + no3;
        }
        public static void AddNumber2(int no1, float no2, double no3)
        {
            Console.WriteLine(no1 + no2 + no3);
        }
        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }
    }
}
