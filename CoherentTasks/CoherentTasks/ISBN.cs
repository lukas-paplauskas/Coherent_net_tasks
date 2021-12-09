using System;
using System.Linq;

namespace CoherentTasks
{
    class ISBN
    {
        protected static bool _inputCorrect = true;
        public static void Execute()
        {
            Console.Write("Please enter the first 9 digits of ISBN-10 idientifier: ");
            string isbn = Console.ReadLine();

            // if input lengt is not 9 ask to enter digits again and to it until it is correct
            do
            {
                if (isbn.Length != 9 || isbn.Any(char.IsLetter))
                {
                    Console.Write("You have entered wrong number, please enter first 9 digits of ISBN-10 identifier: ");
                    isbn = Console.ReadLine();
                }
                else
                    _inputCorrect = false;

            } while (_inputCorrect);
            
            // output the answer and check if checksum digit is 10, if so return 'X'
            Console.Write($"Your ISBN full number is: {isbn + (CalculateCheckDigit(isbn) == 10 ? "X" : CalculateCheckDigit(isbn))}");
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
