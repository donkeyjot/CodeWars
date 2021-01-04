using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public int DigitalRoot(long n)
        {
            if (n < 10)
            {
                return (int) n;
            }

            List<int> digits = new List<int>();
            foreach (var number in n.ToString())
            {
                digits.Add(Int32.Parse(number.ToString()));
            }
            return DigitalRoot(digits.Sum());

        }
    }
}