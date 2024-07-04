namespace CountUniqueCharactersSubstring2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "LEETCODE";
            int count = Program.UniqueLetterString(s);
            Console.WriteLine(count);
            Console.ReadLine();
        }

        public static int UniqueLetterString(string s)
        {
            Dictionary<char, List<int>> characterIndices = new Dictionary<char, List<int>>();
            int len = s.Length;

            for (int i = 0; i < s.Length; i++)
            {
                if (!characterIndices.ContainsKey(s[i]))
                {
                    characterIndices.Add(s[i], new List<int>());
                }

                characterIndices[s[i]].Add(i);
            }


            int sumOfUniqueLetters = 0;

            foreach (var (c, v) in characterIndices)
            {
                int prev = -1;

                for(int i = 0; i<v.Count-1; i++)
                {
                    sumOfUniqueLetters += (v[i] - prev) * (v[i + 1] - v[i]); 
                    prev = v[i];

                }

                int last = v[v.Count-1];
                sumOfUniqueLetters += (v[v.Count - 1] - prev) * (len - last);               
            }

            return sumOfUniqueLetters;
        }
    }
}
