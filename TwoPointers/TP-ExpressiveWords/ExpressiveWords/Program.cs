namespace ExpressiveWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "heeellooo";                
            string[] words = ["hello", "hi", "helo"];

            
            Console.WriteLine(ExpressiveWords(s, words));
            Console.ReadLine();

        }

        public static int ExpressiveWords(string s, string[] words)
        {
            int res = 0;
            foreach (string word in words)
            {
                if (isStretchy(word, s))
                    res += 1;

            }
            return res;
        }


        private static bool isStretchy(string word, string s)
        {
            int i = 0, j = 0;

            while (i < s.Length && j < word.Length)
            {
                
                if (s[i] != word[j])
                    return false;

                int cInS = 0, cInW = 0;
                char charS = s[i], charW = word[j];

                while(i < s.Length && charS == s[i])
                {
                    i++;
                    cInS++;
                }

                while(j < word.Length && charW == word[j])
                {
                    j++;
                    cInW++;
                }

               if(cInS != cInW && (cInW > cInS || cInS < 3))
                {
                    return false;
                }
            }


            return i == s.Length && j == word.Length;
        }


  
    }
}
