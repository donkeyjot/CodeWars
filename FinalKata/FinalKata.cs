using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalKata
{
    public class FinalKata
    {
        public static bool NoneIsMissing(int[] array)
        {
            var sorted = array.OrderBy(x => x).ToList();
            var firstNumber = sorted[0];

            for (int i = 1; i < sorted.Count; i++)
            {
                if (sorted[i] != firstNumber + 1)
                {
                    return false;
                }
                firstNumber++;
            }
            return true;
        }
        
        public static int[] InvertValues(int[] input)
        {
            return input.Select(n => n > 0 ? 0 - n : Math.Abs(n)).ToArray();
        }
        
        // public int IsSolved(int[,] board)
        // {
        //     for (int i = 0; i < board.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < board.GetLength(1); j++)
        //         {
        //             if (board[i, j] == 0)
        //             {
        //                 return -1;
        //             }
        //
        //             if (board[i,j]==)
        //             {
        //                 
        //             }
        //         }
        //     }
        //     
        // }
        
        public static string StripComments(string text, string[] commentSymbols)
        {
            var lines = text.Split("\n");
            var result = String.Empty;
            List<string> stripped = new List<string>();
            
            foreach (var symbol in commentSymbols)
            {
                foreach (var line in lines)
                {
                    stripped.Add(text.Split(symbol, StringSplitOptions.RemoveEmptyEntries)[0]);
                }
            }
            return text;
        }

        public static List<int[]> TwoMakesTarget(int[] array, int target)
        {
            array.GroupBy(n => n).OrderBy(m => m.Key).Select(g => g.Key).ToArray();
            int a;
            List<int[]> result = new List<int[]>();
            
            for (int i = 0; i < array.Length/2; i++)
            {
                a = array[i];
                for (int j = 0+i; j < array.Length; j++)
                {
                    if (a + array[j] == target)
                    {
                        result.Add(new int[]{a,array[j]});
                    }
                }
            }

            return result;
        }
    }
}