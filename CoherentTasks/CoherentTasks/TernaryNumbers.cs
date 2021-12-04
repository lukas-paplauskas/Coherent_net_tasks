using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoherentTasks
{
    class TernaryNumbers
    {
        public static void Execute()
        {
            Console.Write("Please enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write($"Between number {firstNumber} and number {secondNumber} these numbers have two 2's in their ternary number system: ");
            
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                // if a number has exactly two 2's in it's ternary number system print it, else go next number
                if (HasTwoTwos(i))
                    Console.Write($"{i} ");
                else
                    continue;
            }
        }

        private static bool HasTwoTwos(int i)
        {
            int twosCount = 0;
            int number = i;

            do
            {
                // if number has remainder of 2, increase the count by one, else, continue to divide the number
                if (number % 3 == 2)
                    twosCount++;

                number = number / 3;
            } while (number != 0);

            // if the number has exactly two 2's return true
            if (twosCount == 2)
                return true;
            else
                return false;
        }
    }
}
