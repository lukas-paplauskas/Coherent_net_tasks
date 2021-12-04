using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoherentTasks
{
    class MaxMinArraySum
    {
        public static void Execute()
        {
            Console.Write("Please enter your array with space between numbers: ");
            string inputArray = Console.ReadLine();

            int answer = ArrayMaxMinSum(inputArray);

            Console.WriteLine($"This is your array: {inputArray}");
            Console.WriteLine($"The sum of this array range starting from first highest number until lowest number after is {answer}");
        }

        private static int ArrayMaxMinSum(string array)
        {
            int[] userArray = ConvertStringArrayToIntArray(array);

            int maxNumberIndex = Array.FindIndex(userArray, n => n.Equals(userArray.Max()));
            int minNumberIndex = Array.FindLastIndex(userArray, n => n.Equals(userArray.Min()));

            int arrayRangeSum = 0;

            for (int i = maxNumberIndex; i <= minNumberIndex; i++)
            {
                arrayRangeSum += userArray[i];
            }

            return arrayRangeSum;
        }

        private static int[] ConvertStringArrayToIntArray(string array)
        {
            return Array.ConvertAll(array.Split(" ", StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
        }
    }
}
