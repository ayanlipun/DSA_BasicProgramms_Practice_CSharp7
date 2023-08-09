using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.DelegatesAndEvents
{
    public delegate void WorkPerformedHandlerData(int hours, WorkType workType);
    public class CustomEventsExample
    {
        public static void ExecCustomEventsExample()
        {

        }
    }

    public class WorkerClass
    {
        public event WorkPerformedHandlerData WorkPerformed;

        public event EventHandler WorkCompleted;
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
            //Raising Events only if Listeners are attached
            //Approach1
            //if(WorkPerformed != null)
            //{
            //    WorkPerformed(8, WorkType.GenerateReports);
            //}
            //Approach2
            //WorkPerformed?.Invoke(8, WorkType.GenerateReports);
            //Approach3
            //WorkPerformedHandler del1 = WorkPerformed as WorkPerformedHandler;
            //if(del1 != null)
            //{
            //    del1(8, WorkType.GenerateReports);
            //}
            //Approach4
            if (WorkPerformed is WorkPerformedHandlerData del2)
            {
                del2(8, WorkType.GenerateReports);
            }
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
            if (WorkCompleted is EventHandler del)
            {
                del(this, EventArgs.Empty);
            }
            //Note: You can also use other two Approached
        }
    }
    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }
}




