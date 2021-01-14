using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SixKyu2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static char FindMissingLetter(char[] array)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            var index = alphabet.IndexOf(array[0]);

            for (int i = 0; i < array.Length; i++)
            {
                if (String.Join("",array).ToLower()[i] != alphabet[i + index])
                {
                    return Char.IsLower(array[0]) ? alphabet[i+index+1] : alphabet.ToUpper()[i+index+1];
                }
            }
            return ' ';
        }
        
        public static int DontGiveMeFive(int start, int end)
        {
            List<int> numbers = new List<int>();
            for (int i = start; i < end - 1; i++)
            {
                numbers.Add(i);
            }
            
            for (int i = numbers.Count-1; i >= 0; i--)
            {
                var num = numbers[i].ToString();
                var b = false;
                foreach (var digit in num)
                {
                    if (Int32.Parse(digit.ToString()) == 5)
                    {
                        b = true;
                    }
                }

                if (b == true)
                {
                    numbers.Remove(i);
                }

            }

            return numbers.Count();
        }
        
        public static int Digits(ulong n) {
            return n.ToString().Length;
        }

        public static Dictionary<char, int> MostCommon(string filename)
        {
            return File.Exists(filename) ? File.ReadAllText(filename).Replace(" ", "")
                    .GroupBy(c => c)
                    .OrderByDescending(x => x.Count()).Take(2)
                    .ToDictionary(s=>s.Key, s=>s.Count()) :
                throw new Exception("File does not exist!");
        }
        
        public static int OrderBreaker(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                var list = input.ToList();
                var toRemove = list[i];
                list.RemoveAt(i);
               
                var test = input.ToList();
                test.Remove(toRemove);
                test.OrderBy(a=>a).ToList();
                
                if (list.SequenceEqual(test))
                {
                    return toRemove;
                } 
            }

            return 0;
        }
        
        public static string GetStrings(string city)
        { 
            var dis = city.ToLower().Distinct().ToList();
            var groups = city.ToLower().GroupBy(x => x).ToDictionary(s=>s.Key,s=>s.Count());
            Dictionary<char, int> source = new Dictionary<char, int>();
            foreach (var c in dis)
            {
                source.Add(c, groups[c]);
            }

            return String.Join(',', source);
        }
        
        public static int[] DeleteNth(int[] arr, int x)
        {
            Dictionary<int, int> counts = arr.GroupBy(a => a).ToDictionary(s => s.Key, b => b.Count());
            var result = new List<int>();
            foreach (var num in arr)
            {
                if (counts[num] > x) counts[num] = x;
                if (counts[num] > 0)
                {
                    result.Add(num);
                    counts[num]--;
                }
            }

            return result.ToArray();
        }
        
        public static string StringBreakers(int n, string str)
        {
            var noSpaces = str.Replace(" ", "");
            var word=String.Empty;
            var stringList = new List<string>();
            
            for (int i = 0; i < noSpaces.Length; i++)
            {
                word += noSpaces[i];
                
                if ((i + 1) % n == 0)
                {
                    stringList.Add(word);
                    word = String.Empty;
                }
            }

            if (word.Length != n && word.Length != 0)
            {
                stringList.Add(word);
            }

            return String.Join("\n", stringList);
        }
        
        // public static (string color, long position) RedKnight(int knight, long pawn)
        // {
        //     var RedX = false;
        //     var RedY = knight;
        //
        //     var WhiteX =pawn;
        //     var WhiteY = false;
        //
        //     var BlackX = pawn;
        //     var BlackY = true;
        //
        //     while (RedX != WhiteX && RedY != WhiteY || RedX != BlackX && RedY != BlackY)
        //     {
        //         WhiteX++;
        //         BlackX++;
        //
        //         RedX += 2;
        //         RedY = RedY == 0 ? 1 : 0;
        //     }
        //
        //     return RedY == 0 ? ("White", RedX) : ("Black", RedX); 
        
        
        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0 ; j < numbers.Length; j++)
                {
                    if (i != j && numbers[i] + numbers[j] == target)
                    {
                        return new []{i,j};
                    }
                }
            }
            return new []{-1,-1};
        }
               
    }
}