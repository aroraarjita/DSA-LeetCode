using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestRepeatingCharacterString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ABBB";
            int k = 2;

            int length = Program.CharacterReplacement(s, k);
            Console.WriteLine(length);
        }

        public static int CharacterReplacement(string s, int k)
        {

            int maxLength = int.MinValue;
            int start = 0, maxCount = 0, maxStart = 0, length = 0;

            int[] charCounts = new int[26];

            for(int end = 0; end < s.Length; end++)
            {
                charCounts[s[end] - 'A']++;
                maxCount = Math.Max(maxCount, charCounts[s[end]-'A']);


                while(end-start+1-maxCount > k)
                {
                    charCounts[s[start] - 'A']--;
                    start++;

                }


                length = end - start + 1;

                if(length > maxLength)
                {
                    maxLength = length;
                    maxStart = start;
                }

            }

            return maxLength;
        }
    }
}
