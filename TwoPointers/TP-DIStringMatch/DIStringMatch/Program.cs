namespace DIStringMatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "I";
            int[] res = Program.DiStringMatch(s);

            for(int i = 0;i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadLine();
        
        }

        public static int[] DiStringMatch(string s)
        {

            int length = s.Length;
            int[] result = new int[length+1];
            int highest = s.Length;
            int lowest = 0;

            for(int i = 0; i < length; i++)
            {
                if (s[i] == 'I')
                {
                    result[i] = lowest++;
                }
                else if (s[i] == 'D')
                {
                    result[i] = highest--;
                }

            }
            if (!result.Contains(highest))
            {
                result[length] = highest;
            }
            else
            {
                result[length] = lowest;
            }

            return result;

        }
    }
}
