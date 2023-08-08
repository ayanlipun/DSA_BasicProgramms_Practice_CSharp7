using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.DelegatesAndEvents
{
    public delegate string GreetingsDelegate(string name);
    public class DelegateUsingAnonymousMethod
    {
        public static void ExecDelegateUsingAnonymousMethod()
        {
            GreetingsDelegate obj = delegate (string name)
            {
                return "Hello @" + name + " welcome to Dotnet Tutorials";
            };
            string GreetingsMessage = obj.Invoke("Pranaya");
            Console.WriteLine(GreetingsMessage);
        }
    }
}
