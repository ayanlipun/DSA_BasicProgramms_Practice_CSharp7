/*
 Counting frequencies of array elements.

Examples:
Input :  arr[] = {10, 20, 20, 10, 10, 20, 5, 20}
Output : 10 3
         20 4
         5  1

Input : arr[] = {10, 20, 20}
Output : 10 1
         20 2 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DSA
{
    public class Counting_frequencies_of_array_elements
    {
        public static void GetSolution1()
        {
            int[] numbers = { 10, 20, 20, 10, 10, 20, 5, 20 };
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (keyValuePairs.ContainsKey(numbers[i]))
                {
                    int val = keyValuePairs[numbers[i]];
                    keyValuePairs.Remove(numbers[i]);
                    keyValuePairs.Add(numbers[i], val + 1);
                }
                else
                {
                    keyValuePairs.Add(numbers[i], 1);
                }
            }

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine(item.Key + "--> " + item.Value);
            }
        }

        public static void GetSolution2()
        {
            int[] numbers = { 10, 20, 20, 10, 10, 20, 5, 20 };
            int numLength = numbers.Length;

            bool[] visited = new bool[numLength];

            // Traverse through array elements and
            // count frequencies
            for (int i = 0; i < numLength; i++)
            {

                // Skip this element if already processed
                if (visited[i] == true)
                    continue;

                // Count frequency
                int count = 1;
                for (int j = i + 1; j < numLength; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                Console.WriteLine(numbers[i] + " --> " + count);
            }
        }
    }
}
