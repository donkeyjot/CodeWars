using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AlgoLive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(BreakChocolate(5,5));
            Console.WriteLine(Solve("sdasdasfasdfsdgaafghdfherteh"));
        }
        
        public static int BreakChocolate(int n, int m)
        {
            var biggerSide=m;
            var smallerSide = n;

            if (n >= m)
            {
                biggerSide = n;
                smallerSide = m;
            }


            if (n == 0 || m == 0) return 0;
            var counter = 0;
            for (int i = 1; i < biggerSide; i++)
            {
                counter++;
                
                for (int j = 0; j < smallerSide; j++)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int Solve(string str)
        {
            if (str is null) throw new ArgumentNullException();
            return Regex.Split(str, @"[^aeiou]+").ToList().Max(x => x.Length);
        }
    }
}