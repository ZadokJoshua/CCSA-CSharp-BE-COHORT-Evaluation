using System;

namespace FindNumbersInAString
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Get user input
            Console.Write("Enter the String: ");
            string theString = Console.ReadLine();

            // Call method
            Console.WriteLine(NumberFinder(theString));
        }

        // Method
        public static string NumberFinder(string thisString)
        {
            char[] characters = thisString.ToCharArray();
            int letters = 0;
            int numbers = 0;

            for (int i = 0; i < characters.Length; i ++)
            {
                if (Char.IsDigit(characters[i]))
                {
                    numbers++;
                }
                else
                {
                    letters++;
                }
            }

            return $"Text characters: {letters}\nNumeric characters: {numbers}";
        }
    }
}
