namespace ShortestDistancetoCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            int[] output = obj.ShortestToChar("aaba", 'b');
            Console.WriteLine("Hello, World!");
        }

        public int[] ShortestToChar(string s, char c)
        {

            int start = 0, prev = int.MaxValue, curr = 0;
            int[] output= new int[s.Length];
            int index = 0;

            while(index < s.Length)
            {
                if (s[index] != c) {
                    index++;
                }
                else
                {
                    curr = index;
                    while(start <= index)
                    {
                        output[start] = Math.Abs(curr- start) <= Math.Abs(prev-start) ? Math.Abs(curr - start) : Math.Abs(prev - start);
                        start++;
                        
                    }

                    prev = curr;
                    index++;
                }

            }

            while(start < output.Length)
            {
                output[start] = Math.Abs(curr - start) <= Math.Abs(prev - start) ? Math.Abs(curr - start) : Math.Abs(prev - start);
                start++;
            }



            return output;
        }
    }
}
