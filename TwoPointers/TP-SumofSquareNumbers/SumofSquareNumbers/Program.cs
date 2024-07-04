namespace SumofSquareNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();

            bool result = obj.JudgeSquareSum(1);
            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("Hello, World!");
        }

        public bool JudgeSquareSum(int c)
        {

            if(c == 0 || c == 1)
            {
                return true;

            }

            long val = (long)Math.Sqrt(c);

            long start = 0;
            long end = val;

            while (start <= end)
            {
                long square = start * start + end * end;

                if (square > c)
                    end--;
                else if (square < c)
                    start++;
                else if (square == c)
                    return true;

            }

            return false;

        }
    }
}
