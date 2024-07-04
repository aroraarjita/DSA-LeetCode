namespace CamelcaseMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            string[] queries = ["FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack"];
            string pattern = "FB";

            IList<bool> results = obj.CamelMatch(queries, pattern);
            Console.WriteLine(results.Count);

            foreach (bool result in results)
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();
            
        }
       

        public IList<bool> CamelMatch(string[] queries, string pattern)
        {
            IList<bool> results = new List<bool>();

            foreach (string query in queries)
            {
                results.Add(ValidateMatchingPattern(query, pattern));
            }


            return results;

 
        }


        private bool ValidateMatchingPattern(string query, string pattern)
        {
            int patternIndex = 0;


            foreach(char currentCharacter in query)
            {

                if(patternIndex < pattern.Length && currentCharacter == pattern[patternIndex])
                {
                    patternIndex++;
                    continue;
                }

                if (char.IsLower(currentCharacter))
                {
                    continue;
                }


                return false;
            }
            return patternIndex == pattern.Length;
        }
    }
}
