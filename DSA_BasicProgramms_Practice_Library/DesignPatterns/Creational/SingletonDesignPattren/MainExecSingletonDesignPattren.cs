using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.SingletonDesignPattren
{
    public class MainExecSingletonDesignPattren
    {
        public static void GetSingletonDesignPattrenExecution()
        {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variable contain same instance");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain same instance");
            }
        }
    }
}
