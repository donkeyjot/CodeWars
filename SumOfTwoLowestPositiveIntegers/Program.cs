using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfTwoLowestPositiveIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static int SumTwoSmallestNumbers(int[] numbers)
        {
            int[] sorted = numbers;
            Array.Sort(sorted);
            return sorted[0] + sorted[1];
        }

        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            List<int> numbersList = new List<int>();
            foreach (var number in numbers)
            {
                numbersList.Add(number);
            }

            int smallest = numbersList.Min();
            numbersList.Remove(smallest);
            int secondSmallest = numbersList.Min();

            return smallest + secondSmallest;
        }
    }
}
