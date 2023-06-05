namespace DSA_BasicProgramms_Practice_Library
{
    public class RandomProgram
    {
        /* 
     * Programm for Thread, Task
     * Async, Await and Non Async Test methods

     * Solution :
    Console.WriteLine("Method1 started");
    Method1();
    Console.WriteLine("Method2 started");
    Method2();
    Console.WriteLine("Method3 started");
    Method3();
    Console.ReadLine();

    static async Task Method1()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 25; i++)
            {
                // Console.WriteLine(" Method 1");
                // Do something
                Task.Delay(100).Wait();
            }
        });
        Console.WriteLine("Method1 completed");
    }
    static void Method2()
    {
        for (int i = 0; i < 25; i++)
        {
            // Console.WriteLine(" Method 2");
            // Do something
            Task.Delay(300).Wait();
        }
        Console.WriteLine("Method2 completed");
    }

    static async void Method3()
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
    */

        /*============================================================================================*/

        /* 
         * Programm to get the count of occurance in an Array

         * Solution :
        int[] arr = { 87, 55, 23, 87, 45, 23, 98 };
        var dict = new Dictionary<int, int>();
        foreach (var count in arr)
        {
            if (dict.ContainsKey(count))
                dict[count]++;
            else
                dict[count] = 1;
        }
        foreach (var val in dict)
            Console.WriteLine("{0} occurred {1} times", val.Key, val.Value);
        Console.ReadLine();  
        */

        /*============================================================================================*/

        /* 
         * Programm to check constructor in abstract class. 
         * Solution :
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

        public class Program
        {
            static void Main(string[] args)
            {
                MacBook macBook = new MacBook(); 
                macBook.SetName();
                Console.ReadLine();
            }
        }
        */

        /* 
         * Programm to tricky parent child relation and constructor call
         * Solution :
        public class AppleBase
        {
            public AppleBase()
            {
                Console.WriteLine("Apple Base Constructor!!");
                SetName();
            }

            public void SetName()
            {
                Console.WriteLine("Set Name Base");
            }
        }
        public class MacBook : AppleBase
        {
            public MacBook()
            {
                Console.WriteLine("Mac book Constructor!!");
            }
            public void SetName()
            {
                Console.WriteLine("Set Name Child");
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                MacBook macBook = new MacBook();
                macBook.SetName();

                AppleBase appleBase = new MacBook();
                appleBase.SetName();

                AppleBase appleBase1 = new AppleBase();
                appleBase1.SetName();
                Console.ReadLine();
            }
        }
         */


        /* 
         * Programm to New and Ovverride tricky way.
         * Solution :
        public class AppleBase
        {
            public AppleBase()
            {
                Console.WriteLine("Apple Base Constructor!!");
                SetName();
                GetName();
            }

            public virtual void SetName()
            {
                Console.WriteLine("Set Name Base");
            }

            public virtual void GetName()
            {
                Console.WriteLine("Get Name Base");
            }
        }
        public class MacBook : AppleBase
        {
            public MacBook()
            {
                Console.WriteLine("Mac book Constructor!!");
                SetName();
                GetName();
            }
            public override void SetName()
            {
                Console.WriteLine("Set Name Child");
            }

            public new void GetName()
            {
                Console.WriteLine("Get Name Child");
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                MacBook macBook = new MacBook();
                macBook.SetName();
                macBook.GetName();
                Console.WriteLine(".................");
                AppleBase appleBase = new MacBook();
                appleBase.SetName();
                appleBase.GetName();
                Console.WriteLine(".................");
                AppleBase appleBase1 = new AppleBase();
                appleBase1.SetName();
                appleBase1.GetName();
                Console.ReadLine();
            }
        }
         */

        /* 
         * Programm to New and Ovverride tricky way.
         * Solution :
        class Solution
        {

            static void Main(String[] args)
            {
                int t = Convert.ToInt32(Console.ReadLine());

                int result = 0;
                for (int a0 = 0; a0 < t; a0++)
                {
                    if (a0 % 3 == 0 || a0 % 5 == 0)
                    {
                        result = result + a0;
                    }
                }
                Console.WriteLine(result);
                Console.ReadKey();

                t = Convert.ToInt32(Console.ReadLine());
            }
        }
        */

        /* 
         * Programm make Fluent API
         * Solution :

        public class Employee
        {
            public string FullName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Department { get; set; }
            public string Address { get; set; }
        }

        public class FluentEmployee
        {
            private Employee employee = new Employee();

            public FluentEmployee NameOfTheEmployee(string FullName)
            {
                employee.FullName = FullName;
                return this;
            }
            public FluentEmployee Born(string DateOfBirth)
            {
                employee.DateOfBirth = Convert.ToDateTime(DateOfBirth);
                return this;
            }

            public FluentEmployee WorkingOn(string Department)
            {
                employee.Department = Department;
                return this;
            }

            public FluentEmployee StaysAt(string Address)
            {
                employee.Address = Address; 
                return this;
            }
        }

        public class Programm
        {
            static void Main(string[] args)
            {
                FluentEmployee fluentEmployee = new FluentEmployee();
                fluentEmployee.NameOfTheEmployee("Ayan").Born("10/20/2015").WorkingOn("IT").StaysAt("Bengaluru");
                Console.ReadLine();
            }
        }
        */

        /* 
         * Programm make Fluent API
         * Solution :
        */
    }
}