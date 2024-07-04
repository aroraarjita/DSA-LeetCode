using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithKDistinctChars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = "abaccc";
            int k = 2;

            int lengOfSubstring = Program.LengthOfLongestSubstringKDistinct(s, k);
            Console.WriteLine(lengOfSubstring);
            Console.ReadLine();


        }

        public static int LengthOfLongestSubstringKDistinct(string s, int k)
        {

            LinkedList<char> charactersOfSubstring = new LinkedList<char>();
            List<char> diffCharsArray = new List<char>();

            int maxLength = int.MinValue;

            if (s.Length == 0) { return 0; }


            for (int i = 0; i < s.Length; i++)
            {
                if (charactersOfSubstring.Contains(s[i]))
                    charactersOfSubstring.AddLast(s[i]);

                if (!charactersOfSubstring.Contains(s[i])
                    && diffCharsArray.Count < k)
                {

                    diffCharsArray.Add(s[i]);
                    charactersOfSubstring.AddLast(s[i]);
                }

                else if (!charactersOfSubstring.Contains(s[i]) &&
                    diffCharsArray.Count == k && charactersOfSubstring.Count > 0)
                {
                    while (diffCharsArray.Count == k
                        && charactersOfSubstring.Count > 0)
                    {

                        char removedChar = charactersOfSubstring.First();
                        charactersOfSubstring.RemoveFirst();

                        if (charactersOfSubstring.Count > 0)
                        {
                            if (!charactersOfSubstring.Contains(removedChar))
                            {
                                diffCharsArray.Remove(removedChar);

                            }
                        }

                        else
                        {
                            diffCharsArray.Remove(removedChar);
                        }
                    }

                    charactersOfSubstring.AddLast(s[i]);
                    diffCharsArray.Add(s[i]);
                }

                maxLength = maxLength > charactersOfSubstring.Count ? maxLength : charactersOfSubstring.Count;
            }

            return maxLength;

        }
    }
}
