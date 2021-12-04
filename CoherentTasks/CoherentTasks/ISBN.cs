using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoherentTasks
{
    class ISBN
    {
        public static void Execute()
        {
            Console.Write("Please enter the first 9 digits of ISBN-10 idientifier: ");
            string isbn = Console.ReadLine();

            Console.Write($"Your ISBN last number is: {CalculateCheckDigit(isbn)}");
        }

        private static int CalculateCheckDigit(string isbn)
        {
            int multiplier = 10;
            int checksum = 0;

            // Calculate chekcum of ISBN10 first 9 digits
            foreach (var number in isbn)
            {
                checksum += multiplier * int.Parse(number.ToString());

                multiplier--;
            }

            // If checksum is multiple of 11 check digit is 0, otherwise subtract remainder from 11
            return checksum % 11 == 0 ? 0 : (11 - (checksum % 11));
        }
    }
}
