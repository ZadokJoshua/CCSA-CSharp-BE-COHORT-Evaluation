using System;

namespace MinAndMaxRecusion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get user input
            Console.Write("Enter the length of the Array: ");
            int arrLen = Convert.ToInt32(Console.ReadLine());

            // Create array
            int[] userArray = new int[arrLen];

            Console.WriteLine("Enter the values of the Array: ");

            // For loop
            for(int i = 0; i < arrLen; i++)
            {
                Console.Write($"Element[{i}] = ");
                userArray[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("------------------------");
            Console.WriteLine("Maximum value = " + MaxValue(userArray, arrLen));
            Console.WriteLine("Minimum value = " + MinValue(userArray, arrLen));
            Console.WriteLine("------------------------");
            Console.WriteLine($"Sum = {MaxValue(userArray, arrLen) + MinValue(userArray, arrLen)}");
        }

        public static int MinValue(int[] numsArr, int arraylength)
        {
            if(arraylength == 1)
            {
                return numsArr[0];
            }
            else
            {
                return Math.Min(numsArr[arraylength - 1], MinValue(numsArr, arraylength - 1));
            }
        }

        public static int MaxValue(int[] numsArr, int arraylength)
        {
            if (arraylength == 1)
            {
                return numsArr[0];
            }
            else
            {
                return Math.Max(numsArr[arraylength - 1], MaxValue(numsArr, arraylength - 1));
            }
        }

    }
}
