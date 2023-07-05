using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Methods_In_CSharp_which_take_lambdas_as_parameters
{
    public class MainExecLamdaParameterInMethod
    {
        public static void GetLamdaParameterInMethodToExecute()
        {
            var randPerson = new PersonModel();
            randPerson.GenerateRandomName(() =>
            {
                return new PersonModel()
                {
                    FirstName = "Winsome",
                    LastName = " Basket"
                };
            });

            Console.WriteLine($"{randPerson.FirstName} {randPerson.LastName}");

            randPerson.Mutate(x => x.ToUpper());
            Console.WriteLine($"{randPerson.FirstName} {randPerson.LastName}");
        }
    }
}
