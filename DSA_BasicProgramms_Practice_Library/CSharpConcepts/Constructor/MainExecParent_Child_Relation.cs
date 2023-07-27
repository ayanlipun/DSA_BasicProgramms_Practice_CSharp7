using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Constructor
{
    public class MainExecParent_Child_Relation
    {
        public static void ExecParentChildRelationInConstructor()
        {
            MacBook1 macBook = new MacBook1();
            macBook.SetName();
            Console.WriteLine();

            AppleBase1 appleBase = new MacBook1();
            appleBase.SetName();
            Console.WriteLine();

            AppleBase1 appleBase1 = new AppleBase1();
            appleBase1.SetName();
        }
    }

    public class AppleBase1
    {
        public AppleBase1()
        {
            Console.WriteLine("Apple Base Constructor!!");
            SetName();
        }

        public void SetName()
        {
            Console.WriteLine("Set Name Base");
        }
    }
    public class MacBook1 : AppleBase1
    {
        public MacBook1()
        {
            Console.WriteLine("Mac book Constructor!!");
        }
        public void SetName()
        {
            Console.WriteLine("Set Name Child");
        }
    }
}
