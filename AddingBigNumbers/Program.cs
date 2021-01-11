using System;
using System.Numerics;

namespace AddingBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static string Add(string a, string b)
        {
            return (BigInteger.Parse(a)+BigInteger.Parse(b)).ToString();
        }
    }
}