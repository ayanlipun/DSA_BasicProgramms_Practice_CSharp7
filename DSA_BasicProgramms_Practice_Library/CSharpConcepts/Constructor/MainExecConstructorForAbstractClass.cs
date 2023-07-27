/*
 Programm to check constructor in abstract class. 
 */

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Constructor
{
    public class MainExecConstructorForAbstractClass
    {
        public static void ExecutionConstructorForAbstractClass()
        {
            MacBook macBook = new MacBook();
            macBook.SetName();
            Console.ReadLine();
        }
    }

    public abstract class AppleBase
    {
        public AppleBase()
        {
            SetName();
        }

        public abstract void SetName();
    }
    public class MacBook : AppleBase
    {
        public MacBook()
        {
            Console.WriteLine("Mac book Constructor!!");
        }
        public override void SetName()
        {
            Console.WriteLine("Hello Mac!!");
        }
    }
}
