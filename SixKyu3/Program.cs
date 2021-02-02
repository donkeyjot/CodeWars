using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;

namespace SixKyu3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Maskify("4556364607935616"));
            Console.WriteLine(NbYear(1500, 5, 100, 5000));
            WaveSort(new [] { 1, 2, 34, 4, 5, 5, 5, 65, 6, 65, 5454, 4 });
          
        }

        public double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0) return new double[] { };
            if (signature.Length != 3) return new double[] { };
            var result = signature.ToList();

            for (int i = 0; i < n - 3; i++)
            {
                result.Add(result[i] + result[i + 1] + result[i + 2]);
            }

            return result.Take(n).ToArray();
        }

        public static string Tickets(int[] peopleInLine)
        {
            if (peopleInLine[0] != 25) return "NO";
            var cashier = new List<int>();
            foreach (var person in peopleInLine)
            {
                var toReturn = 0;
                cashier.Add(person);
                if (person != 25)
                {
                    toReturn = person - 25;
                }

                while (toReturn > 0)
                {
                    if (toReturn == 25)
                    {
                        if (!cashier.Contains(25)) return "NO";
                        cashier.Remove(25);
                    }

                    if (!cashier.Contains(25)) return "NO";
                    cashier.Remove(25);
                    if (!cashier.Contains(50) && !cashier.Contains(25)) return "NO";
                    if (cashier.Contains(50)) ;
                    cashier.Remove(50);
                }
            }


            return "YES";

        }

        public static int solve(string s)
        {
            if (s.Length % 2 == 1) return -1;
            var reversals = 0;
            return 0;
        }

        public static String jumbledStringSlowPerformance(String s, long n)
        {
            for (int i = 0; i < n; i++)
            {
                s = String.Join("", s.Where((x, y) => y % 2 == 0)) + String.Join("", s.Where((x, y) => y % 2 != 0));
            }

            return s;
        }

        public static string GoodVsEvil(string good, string evil)
        {
            var goodGuys = good.Split(" ").Select(v => Int32.Parse(v)).ToList();
            var badGuys = evil.Split(" ").Select(e => Int32.Parse(e)).ToList();

            goodGuys[1] *= 2;
            goodGuys[2] *= 3;
            goodGuys[3] *= 3;
            goodGuys[4] *= 4;
            goodGuys[5] *= 10;

            badGuys[1] *= 2;
            badGuys[2] *= 2;
            badGuys[3] *= 2;
            badGuys[4] *= 3;
            badGuys[5] *= 5;
            badGuys[6] *= 10;

            var goodSum = goodGuys.Sum();
            var badSum = badGuys.Sum();

            if (badSum == goodSum) return "Battle Result: No victor on this battle field";
            return badSum > goodSum
                ? "Battle Result: Evil eradicates all trace of Good"
                : "Battle Result: Good triumphs over Evil";
        }

        public static int FindMissing(List<int> list)
        {
            var progression = 0;
            if (list[1] - list[0] == list[2] - list[1])
            {
                progression = list[1] - list[0];
            }
            else
            {
                if (list[1] - list[0] < list[2] - list[1])
                {
                    progression = list[1] - list[0];
                }
                else
                {
                    progression = list[2] - list[1];
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i + 1] != list[i] + progression) return list[i] + progression;
            }

            return 0;
        }

        public static long rowSumOddNumbers(long n)
        {
            var sums = new List<int>() {0};
            var counter = 1;
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    counter += 2;
                }
            }

            for (int i = 0; i < n; i++)
            {
                counter += 2;
                sums.Add(counter);
            }

            return sums.Sum();
        }

        public static long digPow(int n, int p)
        {
            Console.WriteLine(n);
            Console.WriteLine(p);
            var digits = new List<double>();
            foreach (var digit in n.ToString())
            {
                digits.Add(Int32.Parse(digit.ToString()));
            }

            for (int i = 0; i < digits.Count; i++)
            {
                digits[i] = Math.Pow(digits[i], p + i);
            }

            double remain = digits.Sum() / n;

            return n * (int) remain == digits.Sum() ? (long) remain : -1;
        }

        public static bool comp(int[] a, int[] b)
        {
            if (a.Length != b.Length || a.Length == 0
                                     || b.Length == 0) return false;
            var listA = a.ToList();
            var listB = b.ToList();
            var isBbigger = listB.Sum() > listA.Sum();
            if (!isBbigger)
            {
                var temp = listA;
                listA = listB;
                listB = temp;
            }

            foreach (var number in listA)
            {
                if (!listB.Contains((int) Math.Pow(number, 2))) return false;
            }

            return true;
        }

        public static string Maskify(string cc)
        {
            if (cc.Length < 5) return cc;
            return new String('#',cc.Length-4) + cc.Substring(cc.Length - 5, 4);
        }
        
        public static int[] PartsSums(int[] ls)
        {
            int sum = ls.Sum();
            int remove = 0;
            int[] result = new int[ls.Length + 1];
            result[0] = sum;
            for (int i = 0; i < ls.Length; i++)
            {
                remove += ls[i];
                sum -= remove;
                result[i+1] = sum;
            }
            
            return result;
        }
        
        public static List<int> SumConsecutives(List<int> s) 
        {
            for (int i = 0; i < s.Count; i++)
            {
                var consecutive = new List<int>();
                for (int j = 0; j < s.Count; j++)
                {
                  
                }
            }

            return new List<int>();
        }
        
        public static string[] dup(string[] arr)
        {
            var removed = new List<string>();
            
            foreach (var word in arr)
            {
                var letters = word.ToCharArray().ToList();
                var newWord = String.Empty;

                for (int i = letters.Count; i>0 ; i--)
                {
                    if (letters[i] == letters[i-1])
                    {
                        letters.RemoveAt(i);
                    }
                }

                removed.Add(word.Reverse().ToString());
            }

            return removed.ToArray();
        }
        
        public static string CleanString(string s)
        {
            var letters = new List<string>();
            foreach (var c in s)
            {
                if (c != '#')
                {
                    letters.Add(c.ToString());
                }

                if (c == '#' && letters.Count>0)
                {
                    letters.RemoveAt(letters.Count - 1);
                }
            }
            return String.Join("",letters);
        }
        
        public int CrossingSum(int[][] matrix, int a, int b)
        {
            var numbers = new List<int>();
            foreach (var num in matrix[a])
            {
                numbers.Add(num);
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if(j==b) numbers.Add(matrix[i][j]);
                }
            }

            return numbers.Sum() - matrix[a][b];
        }
        
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            double currentPopulation = p0;
            var counter = 0;
            double increment = 1+ percent / 100;

            while (currentPopulation <= p)
            {
                currentPopulation = increment * currentPopulation;
                currentPopulation += aug;
                counter++;
            }

            Console.WriteLine(p);
            Console.WriteLine(currentPopulation);

            return counter;
        }
        public static bool IsTriangle(int a, int b, int c)
        {
            if (a * b * c == 0) return false;
            if (a + b < c || b + c < a || c + a < b) return false;
            return true;
        }
        
        public static void WaveSort(int[] arr)
        {
            var ordered = arr.OrderBy(x => x).ToList();
            var smaller = ordered.Take(ordered.Count / 2).ToList();
            var bigger = ordered.TakeLast(ordered.Count / 2).ToList();

            var constructed = new int[arr.Length];
            for (int i = 0; i < constructed.Length; i++)
            {
                switch (i%2)
                {
                    case 1:
                    {
                        constructed[i] = bigger[0];
                        bigger.RemoveAt(0);
                        break;
                    }
                    case 0:
                    {
                        constructed[i] = smaller[0];
                        smaller.RemoveAt(0);
                        break;
                    }
                }
            }
            arr = constructed;
        }
    }
}