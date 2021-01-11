using System;
using System.Collections.Generic;
using System.Linq;

namespace PersistentBugger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Persistence(25));
        }
        
        public static int Persistence(long n)
        {
            if (n <= 0)
            {
                return 0;
            }

            int result = 0;
            while (n > 9)
            {
                List<int> numbers = new List<int>();
                foreach (var digit in n.ToString())
                {
                    numbers.Add(Int32.Parse(digit.ToString()));
                }

                n = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    n *= numbers[i];
                }
                
                result += 1;
            }

            return result;
        }
    }
}