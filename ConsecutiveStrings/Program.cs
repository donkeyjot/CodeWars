using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsecutiveStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(LongestConsec(
                new String[]
                    {"ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh"}, 1));
        }
        
        public static string LongestConsec(string[] strarr, int k) 
        {
            if (String.IsNullOrEmpty(strarr[0]) || k <= 0 || k > strarr.Length)
            {
                return "";
            }

            var stringsConcat = new List<string>();
            for (int i = 0; i < strarr.Length; i++)
            {
                var concat = String.Empty;
                for (int j = 0; j < k; j++)
                {
                    concat += strarr[i + j];
                }
                stringsConcat.Add(concat);
            }

            stringsConcat = stringsConcat.OrderByDescending(w => w.Length).ToList();
            return stringsConcat[0];
        }
    }
}