using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.Methods_In_CSharp_which_take_lambdas_as_parameters
{
    public static class PersonExtension
    {
        public static void GenerateRandomName(this PersonModel person, Func<PersonModel> action)
        {
            var randomPerson = action();
            person.FirstName = randomPerson.FirstName;
            person.LastName = randomPerson.LastName;
        }

        public static void Mutate(this PersonModel person ,  Func<string,string> action)
        {
            person.FirstName =action(person.FirstName);
            person.LastName =action(person.LastName);
        }
    }
}
