namespace CountingBits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int[] CountBits(int n)
        {
            int[] numberOfOnes = new int[n+1];

            numberOfOnes[0] = 0;

            for(int i = 1; i <= n; i++)
            {

                numberOfOnes[i] = (numberOfOnes[i >> 1]) + (i & 1);

            }

            return numberOfOnes;

        }
    }
}
