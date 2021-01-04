using System;
using System.Linq;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Return the number (count) of vowels in the given string.
            //
            // We will consider a, e, i, o, u as vowels for this Kata (but not y).
            //
            //     The input string will only consist of lower case letters and/or spaces.
        }
        
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            string[] vowels = new string[] {"a", "e", "i", "o", "u"};

            foreach (var letter in str)
            {
                foreach (var vowel in vowels)
                {
                    if(letter.ToString() == vowel) vowelCount++;
                }
            }
            return vowelCount;
        }

        public static int GetVowelCount2 (string str)
        {
            return str.Count(v => "aeiou".Contains(v));
        }
    }
}