using System;
using System.Collections.Generic;
using System.Linq;

namespace PlusOneArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(UpArray(new int[] {2, 3, 9}).ToString());
        }

        public static int[] UpArray(int[] num)
        {
            if (num is null || num.Where(x=>x<0).ToList().Count > 0)
            {
                return null;
            }
            
            int counter = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != 0) break;
                counter++;
            }
            
            var sum = String.Empty;
            foreach (var number in num)
            {
                sum += number.ToString();
            }

            try
            {
                if (Int64.Parse(sum) > Int32.MaxValue) return null;
            }
            catch
            {
                return null;
            }

            var sumAdd = (Int32.Parse(sum) + 1).ToString();
            var result = new List<int>();
            for (int i = 0; i < counter; i++)
            {
                result.Add(0);
            }
            foreach (var number in sumAdd)
            {
                result.Add(Int32.Parse(number.ToString()));
            }

            return result.ToArray();
        }
    }
}