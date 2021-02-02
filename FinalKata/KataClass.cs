using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalKata
{
    public class KataClass
    {
        public List<List<string>> SubtitleMaker(string text)
        {
            List<List<string>> lists = new List<List<string>>();
            var counter = 0;
            List<string> toAdd = new List<string>();

            foreach (var word in text.Split(" "))
            {
                toAdd.Add(word);
                counter++;
                if (counter > 4 || word.Last() == '.')
                {
                    lists.Add(toAdd);
                    counter = 0;
                    toAdd = new List<string>();
                }
            }
            return lists;
        }
    }
}