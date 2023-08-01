using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Asynchronous
{
    public class MultipleTasks
    {
        public static void ExecMultipleTasks()
        {
            Console.WriteLine($"Main Thread Started!");
            List<CreditCard> creditCards = CreditCard.GenerateCreditCards(10);
            Console.WriteLine($"Credit Card Generated : {creditCards.Count}");

            CreditCard.ProcessCreditCards(creditCards);

            Console.WriteLine("Main Thread Completed");

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
                        CardNumber = "100000000" + i,
                        Name = "CreditCard" + i
                    };
                    creditCards.Add(card);
                }
                return creditCards;
            }

            public static async Task<string> ProcessCard(CreditCard creditCard)
            {
                await Task.Delay(1000);
                string message = $"Credit Card Number : {creditCard.CardNumber} Name : {creditCard.Name} processed";
                Console.WriteLine($"Credit Card Number : {creditCard.CardNumber} processed");
                return message;
            }

            public static async void ProcessCreditCards(List<CreditCard> creditCards)
            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();
                var tasks = new List<Task<string>>();

                foreach (var creditCard in creditCards)
                {
                    var response = ProcessCard(creditCard);
                    tasks.Add(response);
                }

                await Task.WhenAll(tasks);
                stopWatch.Stop();
                Console.WriteLine($"Processing of {creditCards.Count} Credit Cards done in {stopWatch.ElapsedMilliseconds / 1000.0} seconds");
            }
        }
    }
}
