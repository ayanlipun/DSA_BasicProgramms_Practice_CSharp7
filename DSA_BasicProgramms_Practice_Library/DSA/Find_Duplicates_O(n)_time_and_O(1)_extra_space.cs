/*
 Find duplicates in O(n) time and O(1) extra space
Example :
Input : n = 7 and array[] = {1, 2, 3, 6, 3, 6, 1}
Output: 1, 3, 6

Explanation: The numbers 1 , 3 and 6 appears more than once in the array.

Input : n = 5 and array[] = {1, 2, 3, 4 ,3}
Output: 3

Explanation: The number 3 appears more than once in the array. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DSA
{
    public class Find_Duplicates_O_n__time_and_O_1__extra_space
    {
        public static void GetSoultion1()
        {
            int[] numbers = { 0, 4, 3, 2, 7, 8, 2, 3, 1 };


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[numbers[i] % numbers.Length] = numbers[numbers[i] % numbers.Length] + numbers.Length;
            }

            Console.WriteLine("The repeating elements are :");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= numbers.Length * 2)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        public static void GetSoultion2()
        {
            int[] numbers = { 0, 4, 3, 2, 7, 8, 2, 3, 1 };
            int numLength = numbers.Length;

            for (int i = 0; i < numLength; i++)
            {
                int index = numbers[i] % numLength;
                numbers[index] += numLength;
            }

            for (int i = 0; i < numLength; i++)
            {
                if ((numbers[i] / numLength) >= 2)
                {
                    Console.WriteLine(i + " ");
                }

            }

        }

    }
}
