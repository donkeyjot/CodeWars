using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncryptThis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EncryptThis("Hello World!"));
        }
        
        public static string EncryptThis(string input)
        {
            if (input == "") return "";
            List<string> words = input.Split(" ").ToList();
            for (int i = 0; i < words.Count; i++)
            {
                var thisWord = words[i];
                char firstLetter = thisWord[0];
                var firstLetterASC = (int) firstLetter;
                thisWord=firstLetterASC.ToString();

                if (words[i].Length > 1)
                {
                    var secondHalf = words[i].Substring(1).ToCharArray();
                    var c = secondHalf[0];
                    secondHalf[0] = secondHalf[secondHalf.Length - 1];
                    secondHalf[secondHalf.Length - 1] = c;
                    thisWord += String.Join("", secondHalf);
                }

                words[i] = thisWord;
            }

            return String.Join(" ", words);
        }
    }
    
}