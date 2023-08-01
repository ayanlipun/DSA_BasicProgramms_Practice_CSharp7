using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DSA_BasicProgramms_Practice_Library.DesignPatterns.Asynchronous.MultipleTasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Asynchronous
{
    public class Offloading_MultipleTaskByTask_Run
    {
        public static void ExecOffloading_MultipleTaskByTask_Run()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine($"Main Thread Started");
            List<CreditCardNew> CreditCardNews = CreditCardNew.GenerateCreditCardNews(100000);
            Console.WriteLine($"Credit Card Generated : {CreditCardNews.Count}");

            ProcessCreditCardNews(CreditCardNews);

            Console.WriteLine($"Main Thread Completed");
            stopwatch.Start();
            Console.WriteLine($"Main Thread Execution Time {stopwatch.ElapsedMilliseconds / 1000.0} Seconds");
        }

        public static async void ProcessCreditCardNews(List<CreditCardNew> CreditCardNews)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var tasks = new List<Task<string>>();

            await Task.Run(() =>
            {
                foreach (var CreditCardNew in CreditCardNews)
                {
                    var response = ProcessCard(CreditCardNew);
                    tasks.Add(response);
                }
            });

            //It will execute all the tasks concurrently
            await Task.WhenAll(tasks);
            stopwatch.Stop();
            Console.WriteLine($"Processing of {CreditCardNews.Count} Credit Cards Done in {stopwatch.ElapsedMilliseconds / 1000.0} Seconds");
        }
        public static async Task<string> ProcessCard(CreditCardNew CreditCardNew)
        {
            await Task.Delay(1000);
            string message = $"Credit Card Number: {CreditCardNew.CardNumber} Name: {CreditCardNew.Name} Processed";
            return message;
        }
    }

    public class CreditCardNew
    {
        public string CardNumber { get; set; }
        public string Name { get; set; }
        public static List<CreditCardNew> GenerateCreditCardNews(int number)
        {
            List<CreditCardNew> CreditCardNews = new List<CreditCardNew>();
            for (int i = 0; i < number; i++)
            {
                CreditCardNew card = new CreditCardNew()
                {
                    CardNumber = "10000000" + i,
                    Name = "CreditCardNew-" + i
                };
                CreditCardNews.Add(card);
            }
            return CreditCardNews;
        }
    }
}
