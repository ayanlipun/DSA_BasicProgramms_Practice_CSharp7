using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Asynchronous
{
    public class LimitNumberOfConcurrentTasks_SemaphoreSlim_RealTime
    {
        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(3);
        public static void ExecLimitNumberOfConcurrentTasks_SemaphoreSlim_RealTime()
        {
            var stopwatch = new Stopwatch();
            Console.WriteLine($"Main Thread Started");
            //Generating 15 Credit Cards
            List<CreditCard> creditCards = CreditCard.GenerateCreditCards(15);
            Console.WriteLine($"Credit Card Generated : {creditCards.Count}");
            ProcessCreditCards(creditCards);
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
                await semaphoreSlim.WaitAsync();
                try
                {
                    return await ProcessCard(card);
                }
                finally
                {
                    semaphoreSlim.Release();
                }
            }).ToList();

           
            var Responses = await Task.WhenAll(tasks);
            //Creating a collection to hold the responses
            List<CreditCardResponse> creditCardResponses = new List<CreditCardResponse>();
            //Looping through the string array
            foreach (var response in Responses)
            {
                CreditCardResponse creditCardResponse = JsonConvert.DeserializeObject<CreditCardResponse>(response);
                //Adding the .NET Object into the resposne collection
                creditCardResponses.Add(creditCardResponse);
            }
            //Printing all the approved credit cards using a foreach loop
            Console.WriteLine("\nApproved Credit Cards");
            foreach (var item in creditCardResponses.Where(card => card.IsProcessed == true))
            {
                Console.WriteLine($"Card Number: {item.CardNumber}, Name: {item.Name}");
            }
            //Printing all the rejected credit cards using a foreach loop
            Console.WriteLine("\nRejected Credit Cards");
            foreach (var item in creditCardResponses.Where(card => card.IsProcessed == false))
            {
                Console.WriteLine($"Card Number: {item.CardNumber}, Name: {item.Name}");
            }
        }

        public static async Task<string> ProcessCard(CreditCard creditCard)
        {
            await Task.Delay(1000);

            var creditCardResponse = new CreditCardResponse
            {
                CardNumber = creditCard.CardNumber,
                Name = creditCard.Name,               
                IsProcessed = creditCard.CardNumber % 2 == 0 ? true : false
            };
            //Converting the .NET Object to JSON string
            string jsonString = JsonConvert.SerializeObject(creditCardResponse);
            //Return the JSON String
            return jsonString;
        }
    }

    public class CreditCard
    {
        public long CardNumber { get; set; }
        public string Name { get; set; }
        public static List<CreditCard> GenerateCreditCards(int number)
        {
            List<CreditCard> creditCards = new List<CreditCard>();
            for (int i = 0; i < number; i++)
            {
                CreditCard card = new CreditCard()
                {
                    CardNumber = 10000000 + i,
                    Name = "CreditCard-" + i
                };
                creditCards.Add(card);
            }
            return creditCards;
        }
    }
    //This class will hold the response after processing the Credit card
    public class CreditCardResponse
    {
        public long CardNumber { get; set; }
        public string Name { get; set; }
        public bool IsProcessed { get; set; }
    }
}
