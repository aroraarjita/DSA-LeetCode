namespace CountBinarySubstrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "10101";
            Program obj = new Program();
            int res = obj.CountBinarySubstrings(s);

            Console.WriteLine(res);
            Console.ReadLine();
        }

        public int CountBinarySubstrings(string s)
        {

            int countOfBinaryStrings= 0;
            int prev=1, curr = 1;
            for(int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    curr++;
                }
                else
                {
                    prev = curr;
                    curr = 1;
                }

                if(prev >= curr)
                    countOfBinaryStrings++;

            }

            return countOfBinaryStrings;
        }
    }
}
