using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace SevenKyu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Disemvowel("Hello World!"));
            Console.WriteLine(DescendingOrder(0));
            Console.WriteLine(DescendingOrder(32523));
            Console.WriteLine(FindShort("bitcoin take over the world maybe who knows perhaps"));
            foreach (var VARIABLE in GetIntegersFromList(new List<object>(){1,2,"a","b"}))
            {
                Console.WriteLine(VARIABLE);
            }
            Console.WriteLine();
        }
        
        public int MissingValues(int[] arr)
        {
            var x = arr.GroupBy(x => x).First(x=>x.Count() ==1).Key;
            var y= arr.GroupBy(x => x).First(x=>x.Count() ==2).Key;
            return x * x * y;

        }
        
        public static string GetMiddle(string s)
        {
            return (s.Length % 2 != 0) ? s[(s.Length / 2)-1].ToString() : $"{s[(s.Length - 2) / 2]}{s[(s.Length) / 2]}";
        }
        
        public static int SquareDigits(int n)
        {
            string output = String.Empty;
            foreach (var digit in n.ToString())
            {
                output += Math.Pow(Int32.Parse(digit.ToString()),2).ToString();
            }
            return Int32.Parse(output);
        }
        
        public static string Disemvowel(string str)
        {
            return new Regex(@"[aeiouAEIOU]").Replace(str,"");
        }
        
        public static int DescendingOrder(int num)
        {
            if (num <= 0) return 0;
            List<int> numbers = new List<int>();
            foreach (var number in num.ToString())
            {
                numbers.Add(Int32.Parse(number.ToString()));
            }

            return Int32.Parse(String.Join("",numbers.OrderByDescending(x=>x)));
        }
        
        public static int FindShort(string s)
        {
            List<string> words = s.Split(" ").ToList().OrderBy(x=>x.Length).ToList();
            return words[0].Length;
        }
        
        public static bool IsSquare(int n)
        {
            if (n == 0) return true;
            return n % Math.Sqrt(n) == 0;
        }
        
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.Where(x =>x is int).Select(x=>(int) x).ToList();
        }
        
        public static bool XO (string input)
        {
            return input.ToLower().Where(c => c == 'x').Count() == input.ToLower().Where(c => c == 'o').Count();
        }
        
        public static string MakeComplement(string dna)
        {
            string result = String.Empty;
            foreach (var letter in dna)
            {
                switch (letter)
                {
                    case 'A':
                    {
                        result += 'T';
                        break;
                    }
                    case 'T':
                    {
                        result += 'A';
                        break;
                    }
                    case 'C':
                    {
                        result += 'G';
                        break;
                    }
                    case 'G':
                    {
                        result += 'C';
                        break;
                    } 
                }
            }

            return result;
        }
    }
}