using System;
using System.Collections.Generic;
using System.Linq;
/*
  Company -  Danske IT
  Name - Programm for Thread, Task, Async, Await and Non Async Test methods    
 */

using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.Threading.ThreadProgramTestByDanskeIT
{
    public class MainExecThreadTaskProgram
    {
        public static void ExecThreadingAndTaskProgram()
        {
            Console.WriteLine("Method1 started");
            Method1();
            Console.WriteLine("Method2 started");
            Method2();
            Console.WriteLine("Method3 started");
            Method3();
            Console.ReadLine();

        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 25; i++)
                {
                    // Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(1000).Wait();
                }
            });
            Console.WriteLine("Method1 completed");
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                // Console.WriteLine(" Method 2");
                // Do something
                Task.Delay(300).Wait();
            }
            Console.WriteLine("Method2 completed");
        }

        public static async void Method3()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 25; i++)
                {
                    // Console.WriteLine(" Method 2");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });

            Console.WriteLine("Method3 completed");

        }
    }
}
