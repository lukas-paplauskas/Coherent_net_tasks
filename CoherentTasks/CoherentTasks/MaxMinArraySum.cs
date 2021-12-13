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
            Console.Write("Please enter your array with space between numbers (at least two numbers): ");
            int[] inputArray = ConvertStringArrayToIntArray(Console.ReadLine());

            while (inputArray.Length < 2)
            {
                Console.Write("Incorrect input. Please enter at least two numbers: ");
                inputArray = ConvertStringArrayToIntArray(Console.ReadLine());
            }

            int answer = ArrayMaxMinSum(inputArray);

            Console.Write($"This is your array: ");
            PrintArrayNumbers(inputArray);

            Console.WriteLine($"\nThe sum of this array range starting from first highest number until lowest number after is {answer}");
        }

        // Find first max number and first min number going after max number in the array
        private static int ArrayMaxMinSum(int[] array)
        {
            int maxNumberIndex = Array.FindIndex(array, n => n.Equals(array.Max()));

            int minNumberIndex = Array.FindIndex(array, maxNumberIndex, n => n.Equals(array.Where(n => Array.IndexOf(array, n) > maxNumberIndex).Min()));

            int arrayRangeSum = 0;

            for (int i = maxNumberIndex; i <= minNumberIndex; i++)
            {
                arrayRangeSum += array[i];
            }

            return arrayRangeSum;
        }

        private static int[] ConvertStringArrayToIntArray(string array)
        {
            return Array.ConvertAll(array.Split(" ", StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
        }

        private static void PrintArrayNumbers(int[] array)
        {
            foreach (int number in array)
                Console.Write($"{number} ");
        }
    }
}
