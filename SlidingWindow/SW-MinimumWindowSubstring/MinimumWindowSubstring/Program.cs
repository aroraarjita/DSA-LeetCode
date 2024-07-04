using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumWindowSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string res = Program.MinWindow("ADOBECODEBANC", "ABC");

        }

        public static string MinWindow(string s, string t)
        {
            int[] charCount = new int[128];

            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            {
                return "";
            }

            foreach (char c in t)
            {
                charCount[c]++;
            }


            int start = 0;
            int end = 0;
            int NumberOfcharactersRequired = t.Length;
            int minLength = int.MaxValue;
            int minStart = 0;


            while(end < s.Length)
            {
                if (charCount[s[end++]]-- > 0)
                {
                    NumberOfcharactersRequired--;

                }

                while(NumberOfcharactersRequired == 0)
                {
                    if(end-start < minLength)
                    {
                        minLength = end - start;
                        minStart = start;
                    }

                    if (charCount[s[start++]]++ == 0)
                    {
                        NumberOfcharactersRequired++;
                    }
                }
            }
            return minLength == int.MaxValue ? "" : s.Substring(minStart, minLength);
        }
    }
}
