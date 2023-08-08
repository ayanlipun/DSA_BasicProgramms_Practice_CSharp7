using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.DelegatesAndEvents
{
    public delegate void WorkPerformedHandler(int hours, string workType);
    public delegate void WorkCompletedHandler(string workTyp);
    public class DelegateRealTimeExample1
    {
        public static void ExecDelegateRealTimeExample1()
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(Worker_WorkPerformed);
            WorkCompletedHandler del2 = new WorkCompletedHandler(Worker_WorkCompleted);
            Worker worker = new Worker();
            worker.DoWork(5, "Generating Report", del1, del2);
            Console.ReadKey();
        }
        //Delegate Signature must match with the method signature
        public static void Worker_WorkPerformed(int hours, string workType)
        {
            Console.WriteLine($"{hours} Hours compelted for {workType}");
        }
        public static void Worker_WorkCompleted(string workType)
        {
            Console.WriteLine($"{workType} work compelted");
        }
    }

    public class Worker
    {
        public void DoWork(int hours, string workType, WorkPerformedHandler del1, WorkCompletedHandler del2)
        {
            for (int i = 0; i < hours; i++)
            {
                Thread.Sleep(1000);
                del1(i + 1, workType);
            }
            del2(workType);
        }
    }
}
