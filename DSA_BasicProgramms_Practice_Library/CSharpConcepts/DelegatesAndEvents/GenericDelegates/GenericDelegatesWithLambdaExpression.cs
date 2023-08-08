using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.DelegatesAndEvents.GenericDelegates
{
    public class GenericDelegatesWithLambdaExpression
    {
        public static void ExecGenericDelegatesWithLambdaExpression()
        {
            Func<int, float, double, double> func = (x, y, z) =>
            {
                return x + y + z;
            };

            double result = func.Invoke(100, 125.45f, 456.789);
            Console.WriteLine(result);

            Action<int, float, double> action = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            action.Invoke(100, 125.45f, 456.789);

            Predicate<string> predicate = new Predicate<string>(CheckLength);
            bool status = predicate.Invoke("WinsomeBasket");
            Console.WriteLine(status);
        }

        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }
    }
}
