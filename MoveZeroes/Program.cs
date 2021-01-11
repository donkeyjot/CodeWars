using System;
using System.Collections.Generic;
using System.Linq;

namespace MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> result = new List<int>();
            arr.Where(x=>x!=0).ToList().ForEach(result.Add);
            arr.Where(x=>x==0).ToList().ForEach(result.Add);
            return result.ToArray();
        }
    }
}