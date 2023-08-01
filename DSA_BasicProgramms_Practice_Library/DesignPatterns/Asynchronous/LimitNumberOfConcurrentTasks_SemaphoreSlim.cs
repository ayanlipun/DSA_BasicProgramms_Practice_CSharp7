using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static DSA_BasicProgramms_Practice_Library.DesignPatterns.Asynchronous.MultipleTasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Asynchronous
{
    public class LimitNumberOfConcurrentTasks_SemaphoreSlim
    {
        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(3);
        public static void ExecLimitNumberOfConcurrentTasks_SemaphoreSlim()
        {
            var stopwatch = new Stopwatch();
            Console.WriteLine($"Main Thread Started");
            //Generating 15 Credit Cards
            List<CreditCard> creditCards = CreditCard.GenerateCreditCards(15);
            Console.WriteLine($"Credit Card Generated : {creditCards.Count}");
            LimitNumberOfConcurrentTasks_SemaphoreSlim.ProcessCreditCards(creditCards);
            Console.WriteLine($"Main Thread Completed");
        }

        public static async void ProcessCreditCards(List<CreditCard> creditCards)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var tasks = new List<Task<string>>();
            //Need to use async lambda expression
            tasks = creditCards.Select(async card =>
            {
                //This will tell if we have more than 4000 tasks are running, 
                //we are going to wait and '
                //we're going to wait until the semaphore gets released.
                await semaphoreSlim.WaitAsync();
                //Need to use await operator here as we are using asynchronous WaitAsync
                try
                {
                    return await ProcessCard(card);
                }
                finally
                {
                    //Release the semaphore
                    semaphoreSlim.Release();
                }

            }).ToList();


            //It will execute a maximum of 3 tasks at a time
            string[] responses = await Task.WhenAll(tasks);

            foreach (var response in responses)
            {
                Console.WriteLine(response);
            }

            stopwatch.Stop();
            Console.WriteLine($"Processing of {creditCards.Count} Credit Cards Done in {stopwatch.ElapsedMilliseconds / 1000.0} Seconds");
        }

        public static async Task<string> ProcessCard(CreditCard creditCard)
        {
            await Task.Delay(1000);
            string message = $"Credit Card Number: {creditCard.CardNumber} Name: {creditCard.Name} Processed";
            Console.WriteLine($"Credit Card Number: {creditCard.CardNumber} Processed");
            return message;
        }

        public class CreditCard
        {
            public string CardNumber { get; set; }
            public string Name { get; set; }
            public static List<CreditCard> GenerateCreditCards(int number)
            {
                List<CreditCard> creditCards = new List<CreditCard>();
                for (int i = 0; i < number; i++)
                {
                    CreditCard card = new CreditCard()
                    {
                        CardNumber = "10000000" + i,
                        Name = "CreditCard-" + i
                    };
                    creditCards.Add(card);
                }
                return creditCards;
            }
        }
    }
}
