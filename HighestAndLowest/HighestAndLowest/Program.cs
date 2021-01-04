using System;
using System.Collections.Generic;
using System.Linq;

namespace HighestAndLowest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static string HighAndLow(string numbers)
        {
            List<string> numbersList = numbers.Split(" ").ToList();
            List<int> numsParsed =new List<int>();
            foreach (var str in numbersList)
            {
                numsParsed.Add(Int32.Parse(str));
            }

            return $"{numsParsed.Max()} {numsParsed.Min()}";
        }
    }
}