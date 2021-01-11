using System;
using System.Text.RegularExpressions;

namespace DeafRatsOfHamelin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(CountDeafRats("~O~O~O~OP~O~OO~"));
        }
        
        public static int CountDeafRats(string town)
        {
            var townLeft = string.Empty;
            var townRight = String.Empty;
            if (town[0] == 'P')
            {
                townRight = town.Substring(1);
            } 
            else if (town[town.Length - 1] == 'P')
            {
                townLeft = town.Substring(0, town.Length - 1);
            }
            else
            {
                var townsplit = town.Split('P');
                townRight = townsplit[1];
                townLeft = townsplit[0];
            }

            var mice = Regex.Matches(town, "O").Count;
            var deafLeft = Regex.Matches(townLeft, "~O").Count;
            var deafRight = Regex.Matches(townRight, "O~").Count;
            return mice-deafLeft-deafRight;
        }
    }
}