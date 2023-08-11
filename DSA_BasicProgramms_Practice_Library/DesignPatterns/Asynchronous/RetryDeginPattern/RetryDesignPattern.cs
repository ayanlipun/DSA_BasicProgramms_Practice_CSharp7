using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Asynchronous.RetryDeginPattern
{
    public class RetryDesignPattern
    {
        public static async void RetryMethod()
        {
            try
            {
                await Retry(RetryOperation1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The opearation was failed!");
            }
        }
        public static async Task Retry(Func<Task> fun, int retryTime = 3, int waitTime = 500)
        {
            for (int i = 0; i < retryTime - 1; i++)
            {
                try
                {
                    await fun();
                    Console.WriteLine("Operation successful!");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Retry {i + 1}: Getting exception! {ex.Message}");
                    await Task.Delay(waitTime);
                }
            }
            await fun();
        }

        public static async Task RetryOperation1()
        {
            await Task.Delay(500);
            throw new Exception("Exception occured in RetryOperatio1"); //Throwing Exception so that retry will work
        }
    }
}
