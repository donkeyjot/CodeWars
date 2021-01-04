using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace FindTheOddInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static int Find_it(int[] seq) 
        {
            for (int i = 0; i < seq.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < seq.Length; j++)
                {
                    if (seq[i] == seq[j]) counter++;
                }
                if (counter % 2 != 0) return seq[i];
            }
            return -1;
        }

        public static int Find_it2(int[] seq)
        {
            return seq.GroupBy(x => x).Where(g => g.Count() % 2 != 0).First().First();
        }
    }
}