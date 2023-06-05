/*
 Count frequencies of all elements in array in O(1) extra space and O(n) time

Example:

    Input: arr[] = {2, 3, 3, 2, 5}
    Output: Below are frequencies of all elements
            1 -> 0
            2 -> 2
            3 -> 2
            4 -> 0
            5 -> 1
    Explanation: Frequency of elements 1 is 
    0, 2 is 2, 3 is 2, 4 is 0 and 5 is 1.
 
    Input: arr[] = {4, 4, 4, 4}
    Output: Below are frequencies of all elements
            1 -> 0
            2 -> 0
            3 -> 0
            4 -> 4
    Explanation: Frequency of elements 1 is 
    0, 2 is 0, 3 is 0 and 4 is 4.
  
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DSA
{
    public class Count_frequencies_of_all_elements_in_array_in_O_1__extra_space_and_O_n__time
    {
        public static void GetSoulution1(int[] arr)
        {
            int numLength = arr.Length;

            int[] numCounts = new int[numLength];
            int i = 0;

            while (i<numLength)
            {
                numCounts[arr[i] - 1]++;
                i++;
            }
            Console.WriteLine("Please find the counts");

            for ( i = 0; i < numLength; i++)
            {
                Console.WriteLine((i+1)+ " -->" + numCounts[i]);
            }
        }
    }
}
