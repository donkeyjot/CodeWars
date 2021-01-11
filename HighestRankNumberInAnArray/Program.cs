using System;
using System.Linq;

namespace HighestRankNumberInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(HighestRank(new[] {12, 10, 8, 8, 8, 8, 10, 12, 7, 6, 4, 10, 10, 12}));
        }

        public static int HighestRank(int[] arr)
        {
            var s = arr.ToList().GroupBy(x => x).Max(x => x.Count());
            var ar = arr.ToList().GroupBy(x => x).Where(x => x.Count() == s).Max(x => x.Key);
            return ar;
        }
    }
}