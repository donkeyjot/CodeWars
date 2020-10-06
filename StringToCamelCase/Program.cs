using System;

namespace StringToCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static string ToCamelCase(string str)
        {
            if (str.Contains('-'))
            {
                string[] splittedOne = str.Split('-');
                for (int i = 1; i < splittedOne.Length; i++)
                {
                    string firstLetter = splittedOne[i][0].ToString();
                    splittedOne[i] = firstLetter.ToUpper() + splittedOne[i].Substring(1);
                }
                string joined = String.Join("", splittedOne);

                if (joined.Contains('_'))
                {

                    string[] splittedTwo = joined.Split('_');
                    for (int i = 1; i < splittedTwo.Length; i++)
                    {
                        string firstLetter = splittedTwo[i][0].ToString();
                        splittedTwo[i] = firstLetter.ToUpper() + splittedTwo[i].Substring(1);
                    }
                    return String.Join("", splittedTwo);
                }
                else
                {
                    return String.Join("", splittedOne);
                }
            }
            else if (str.Contains('_'))
            {
                string[] splittedOne = str.Split('_');
                for (int i = 1; i < splittedOne.Length; i++)
                {
                    string firstLetter = splittedOne[i][0].ToString();
                    splittedOne[i] = firstLetter.ToUpper() + splittedOne[i].Substring(1);
                }
                string joined = String.Join("", splittedOne);

                if (joined.Contains('-'))
                {
                    string[] splittedTwo = joined.Split('-');
                    for (int i = 1; i < splittedTwo.Length; i++)
                    {
                        string firstLetter = splittedTwo[i][0].ToString();
                        splittedTwo[i] = firstLetter.ToUpper() + splittedTwo[i].Substring(1);
                    }
                    return String.Join("", splittedTwo);
                }
                else
                {
                    return String.Join("", splittedOne);
                }
            }
            else
            {
                return str;
            }
        }
    }
}