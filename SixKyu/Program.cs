using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace SixKyu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(SpinWords("Welcome"));
            Console.WriteLine(DuplicateCount("aabcde"));
        }
        
        public static string SpinWords(string sentence)
        {
            if (!sentence.Contains(" "))
            {
                if (sentence.Length>4)
                {
                    return String.Join("", sentence.Reverse());
                }

                return sentence;
            }

            return String.Join(" ", sentence.Split(" ").Select(x=>x.Length>4 ? String.Join("", x.Reverse()) : x).ToList());
        }
        
        public static int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        }
        
        // public static string Decode(string morseCode)
        // {
        //     return String.Join(" ", morseCode.Split("   ").ToList().Select(w=>w = String.Join("", w.Split(" ").Select(c => MorseCode.Get(c))))).Trim();
        // }
        
        public static int Find(int[] integers)
        {
            var odds = integers.Where(x => x % 2 != 0).ToList();
            var evens = integers.Where(x => x % 2 == 0).ToList();
            return odds.Count() > evens.Count() ? evens[0] : odds[0];
        }
        
        // public static string AnySimilarity(List<int> firstList, List<int> secondList, int n)
        // {
        //     // Happy coding
        //     // return "6,7,3 | 32,5,21 | 2,3,7 | 21,43,23"
        //
        //    var intersect = firstList.Intersect(secondList);
        //    foreach (var VARIABLE in COLLECTION)
        //    {
        //        
        //    }
        // }
        
        public static string DuplicateEncode(string word)
        {
            return String.Join("",word.ToLower().Select(c => word.ToLower().Where(x => x.Equals(c)).Count() > 1 ? c = ')' : c = '('));
        }
        
        public static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "even" : "odd";
        }

        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10) return false;
            var startX = 0;
            var startY = 0;

            foreach (var step in walk)
            {
                switch (step)
                {
                    case "n": startX++;
                        break;
                    case "s": startX--;
                        break;
                    case "e": startY++;
                        break;
                    case "w": startY--;
                        break;
                    default: return false;
                }
            }
            return startX == 0 && startY == 0;
        }
        
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            if (b.Length == 0) return a;
            var al = a.ToList();
            var bl = b.ToList();

            foreach (var n in bl)
            {
                if (al.Contains(n))
                {
                    al=al.Where(num => num != n).ToList();
                }
            }

            return al.ToArray();
        }
        
        public static bool IsIsogram(string str)
        {
            if (str.Equals(String.Empty)) return true;
            return String.Join("",str.ToLower().Distinct().OrderBy(c=>c).ToList()) == String.Join("",str.ToLower().OrderBy(c =>c ).ToList());
        }

        public static string AlphabetPosition(string text)
        {
            Dictionary<char, int> alphabetValues = new Dictionary<char, int>();
            var counter = 1;
            foreach (var letter in "abcdefghijklmnopqrstuvwxyz")
            {
                alphabetValues.Add(letter,counter);
                counter++;
            }
            return String.Join(" ",text.ToLower().Where(l => Char.IsLetter(l)).Select(c => alphabetValues.First(pair => pair.Key == c).Value.ToString()));
        }
        
        public static string CreatePhoneNumber(int[] numbers)
        {
            if (numbers.Length != 10) return "incorrect input";
            return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
        }
        
        public static int PositiveSum(int[] arr)
        {
            return arr.Length==0?0: arr.Where(i => i > 0).Sum();


        }
    }