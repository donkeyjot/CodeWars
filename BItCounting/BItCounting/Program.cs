using System;

namespace BItCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var i = 1234;
            Console.WriteLine(CountBits(i));
            
        }

        public static int CountBits(int i)
        {
            int counter = 0;
            foreach (var number in ToBinary(i))
            {
                if (number == '1')
                {
                    counter++;
                }
            }

            return counter;
        }

        public static string ToBinary(int i)
        {
            return Convert.ToString(i, 2);
        }
    }
}
