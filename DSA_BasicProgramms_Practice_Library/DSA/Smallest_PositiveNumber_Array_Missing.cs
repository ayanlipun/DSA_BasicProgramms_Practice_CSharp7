/*
 Find the smallest positive number missing from an unsorted array 

Examples:
Input:  arr[] = {2, 3, 7, 6, 8, -1, -10, 15}
Output: 1


Input:  arr[] = { 2, 3, -7, 6, 8, 1, -10, 15 }
Output: 4

Input: arr[] = {1, 1, 0, -1, -2}
Output: 2
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DSA
{
    public class Smallest_PositiveNumber_Array_Missing
    {

        public static int GetSolution1(int[] A)
        {
            int maxValue = A.Max();

            if (maxValue < 1)
            {
                return 1;
            }
            if (A.Length == 1)
            {
                if (A[0] == 1)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }

            int i = 0;
            int[] numbers = new int[maxValue];
            for (i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    if (numbers[A[i] - 1] != 1)
                    {
                        numbers[A[i] - 1] = 1;
                    }
                }
            }

            for (i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    return i + 1;
                }
            }

            return i + 2;
        }

        // good solution 
        // Step-1  : Swap the number and make as asc
        // Step 2: Find the missing value in second loop.
        public static int GetSolution2(int[] arr)
        {
            int numLength = arr.Length;

            for (int i = 0; i < numLength; i++)
            {
                while (arr[i] >= 1 && arr[i] <= numLength && arr[i] != arr[arr[i] - 1])
                {
                    int temp = arr[arr[i] - 1];
                    arr[arr[i] - 1] = arr[i];
                    arr[i] = temp;
                }
            }

            for (int i = 0; i < numLength; i++)
            {
                if (arr[i] != i + 1)
                
                {
                    return i + 1;
                }
            }
            return numLength + 1;
        }
    }
}
