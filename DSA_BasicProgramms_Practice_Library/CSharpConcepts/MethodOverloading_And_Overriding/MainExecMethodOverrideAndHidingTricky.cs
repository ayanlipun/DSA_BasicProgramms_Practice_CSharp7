/*
 Programm to New and Ovverride tricky way.
 */

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.MethodOverloading_And_Overriding
{
    public class MainExecMethodOverrideAndHidingTricky
    {
        public static void ExecMethodOverrideAndHidingTricky()
        {
            MacBook macBook = new MacBook();
            macBook.SetName();
            macBook.GetName();
            Console.WriteLine(".................");
            AppleBase appleBase = new MacBook();
            appleBase.SetName();
            appleBase.GetName();
            Console.WriteLine(".................");
            AppleBase appleBase1 = new AppleBase();
            appleBase1.SetName();
            appleBase1.GetName();
            Console.ReadLine();
        }
    }

    public class AppleBase
    {
        public AppleBase()
        {
            Console.WriteLine("Apple Base Constructor!!");
            SetName();
            GetName();
        }

        public virtual void SetName()
        {
            Console.WriteLine("Set Name Base");
        }

        public virtual void GetName()
        {
            Console.WriteLine("Get Name Base");
        }
    }
    public class MacBook : AppleBase
    {
        public MacBook()
        {
            Console.WriteLine("Mac book Constructor!!");
            SetName();
            GetName();
        }
        public override void SetName()
        {
            Console.WriteLine("Set Name Child");
        }

        public new void GetName()
        {
            Console.WriteLine("Get Name Child");
        }
    }
}
