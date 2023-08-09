using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.DelegatesAndEvents
{
    public class CustomEventArgsExample
    {
        public static void ExecCustomEventArgsExample()
        {
            WorkerCycle worker = new WorkerCycle();
            //Attaching Worker_WorkPerformed with WorkPerformed Event
            worker.workPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_WorkPerformed);
            //Attaching Worker_WorkCompleted with WorkCompleted Event
            worker.workCompleted += new EventHandler(Worker_WorkCompleted);
            worker.DoWork(4, WorkType.GenerateReports);
        }

        private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"Worker work {e.Hours} Hours compelted for {e.WorkType}");
        }

        //Event Handler Method or Event Listener Method
        private static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine($"Worker Work Completed");
        }
    }

    public class WorkPerformedEventArgs : EventArgs
    {
        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
    }

    public class WorkerCycle
    {
        public event EventHandler<WorkPerformedEventArgs> workPerformed;
        public event EventHandler workCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            //Do Work here and notify the consumer that work has been performed
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, workType);
                Thread.Sleep(3000);
            }
            //Notify the consumer that work has been completed
            OnWorkCompleted();
        }


        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            //Approach 1
            if (workPerformed != null)
            {
                WorkPerformedEventArgs e = new WorkPerformedEventArgs()
                {
                    Hours = hours,
                    WorkType = workType
                };
                workPerformed(this, e);
            }

            //Approach2
            //EventHandler<WorkPerformedEventArgs> del1 = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            //if (del1 != null)
            //{
            //    WorkPerformedEventArgs e = new WorkPerformedEventArgs()
            //    {
            //        Hours = hours,
            //        WorkType = workType
            //    };
            //    del1(this, e);
            //}

            //Approach3
            //if (WorkPerformed is EventHandler<WorkPerformedEventArgs> del2)
            //{
            //    WorkPerformedEventArgs e = new WorkPerformedEventArgs()
            //    {
            //        Hours = hours,
            //        WorkType = workType
            //    };
            //    del2(this, e);
            //}
        }

        protected virtual void OnWorkCompleted()
        {
            //Raising the Event
            //Approach1
            //EventHandler delegate takes two parameters i.e. object sender, EventArgs e
            //Sender is the current class i.e. this keyword and we do not need to pass any data
            //So, we need to pass Empty EventArgs
            //WorkCompleted?.Invoke(this, EventArgs.Empty);

            //Approach2
            if (workCompleted is EventHandler del)
            {
                del(this, EventArgs.Empty);
            }
        }
    }
}
