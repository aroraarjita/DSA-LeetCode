using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "ab", s2 = "eidboaoo";
            bool result = CheckInclusion(s1, s2);
            Console.WriteLine(result);
            Console.ReadLine();

        }


        public static bool CheckInclusion(string s1, string s2)
        {
            
            if(s1.Length > s2.Length)
            {
                return false;
            }

            int start = 0;
            char[] s1CharArray = s1.ToCharArray();
            Array.Sort(s1CharArray);
            string sortedS1String = new string(s1CharArray);

           

            for(int i = 0; i <= s2.Length-s1.Length; i++)
            {

                string s2SubString = s2.Substring(start, s1.Length);
                char[] s2SubStringCharArray = s2SubString.ToCharArray();
                Array.Sort(s2SubStringCharArray);
                string sortedS2Substring = new string(s2SubStringCharArray);


                if (sortedS1String == sortedS2Substring)
                {
                    return true;
                }

                start++;
            }

            return false;
        }
    }
}
