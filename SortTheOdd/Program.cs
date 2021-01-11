using System;
using System.Collections.Generic;

namespace SortTheOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static int[] SortArray(int[] array)
        {
            List<int> oddIndices = new List<int>();
            List<int> oddValues = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddIndices.Add(i);
                    oddValues.Add(array[i]);
                }
            }
           
            oddValues.Sort();
            Dictionary<int, int> values = new Dictionary<int, int>();
            for (int i = 0; i < oddValues.Count; i++)
            {
                values.Add(oddIndices[i],oddValues[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (values.ContainsKey(i))
                {
                    array[i] = values[i];
                }
            }
            
            return array;
        }
    }
}