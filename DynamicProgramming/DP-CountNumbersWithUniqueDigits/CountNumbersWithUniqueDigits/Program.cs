namespace CountNumbersWithUniqueDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 20;

            int result  = NumberCount(a, b);

            Console.WriteLine(result);
            Console.ReadLine();

           
        }

        public static int NumberCount(int a, int b)
        {
            int count = 0;

            for(int i = a; i < b; i++)
            {
                if (isUnique(i))
                    count++;

            }

            return count;


        }

        public static bool isUnique(int number)
        {
            HashSet<int> set = new HashSet<int>();
            var numString = number.ToString();  
            int len = numString.Length;

            for(int i = 0; i < len; i++)
            {
                set.Add(i);

            }
            return len == 1 || set.Count == len;
        }
    }
}
