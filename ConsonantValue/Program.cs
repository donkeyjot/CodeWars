using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsonantValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Solve("zodiacs"));
        }
        
        public static int Solve(string s)
        {
            Dictionary<char, int> alphabet = new Dictionary<char, int>();
            var alphabetLetters = "abcdefghijklmnopqrstuvwxyz";
            
            for (int i = 1; i < alphabetLetters.Length+1; i++)
            {
                alphabet.Add(alphabetLetters[i-1],i);
            }

            List<string> splitted = new List<string>();

            var part = string.Empty;
            foreach (var letter in s)
            {
                if (letter != 'a' && letter != 'e' && letter != 'i' && letter != 'o' && letter != 'u' )
                {
                    part += letter;
                }
                else
                {
                    splitted.Add(part);
                    part=String.Empty;
                }
            }
            splitted.Add(part);

            int result = 0;
            foreach (var par in splitted)
            {
                int value = 0;
                foreach (var letter in par)
                {
                    value += alphabet[letter];
                }

                if (value >= result) result = value;
            }

            return result;
        }
    }
}