using System.Text;

namespace ReverseOnlyLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "a-bC-dEf-ghIj";
            string res = ReverseOnlyLetters(s);
            Console.WriteLine(res);

            Console.ReadLine();
        }
        public static string ReverseOnlyLetters(string s)
        {
            int startPos = 0;
            int endPos = s.Length-1;
            StringBuilder sUpdated = new StringBuilder(s.Length);
            sUpdated.Append(s);

            while(startPos <= endPos)
            {

                if ((s[startPos] >= 65 && s[startPos] <= 90 ||
                    s[startPos] >= 97 && s[startPos] <= 122)
                    && (s[endPos] >= 65 && s[endPos] <= 90 ||
                    s[endPos] >= 97 && s[endPos] <= 122))
                {
                    sUpdated[startPos] = s[endPos];
                    sUpdated[endPos] = s[startPos];

                    startPos++;
                    endPos--;
                }
                else if ((s[startPos] <65 || s[startPos] > 90 ||
                   s[startPos] <97 || s[startPos] > 122)
                   && (s[endPos]  >= 65 && s[endPos] <= 90 ||
                   s[endPos]>= 97 && s[endPos] <= 122))
                {
                    sUpdated[startPos] = s[startPos];
                    startPos++;
                    
                }
                else if ((s[endPos] < 65 || s[endPos] > 90 ||
                   s[endPos] < 97 || s[endPos] > 122) &&
                   (s[startPos] >= 65 && s[startPos] <= 90 ||
                   s[startPos] >= 97 && s[endPos] <= 122))
                {
                    sUpdated[endPos] = s[endPos];   
                    endPos--;
                }
                else
                {
                    sUpdated[startPos] = s[startPos];
                    sUpdated[endPos] = s[endPos];
                    startPos++;
                    endPos--;
                }
            }



            return sUpdated.ToString();
        }
    }
}
