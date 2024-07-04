namespace BoatsToSavePeople
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] people = { 3, 2, 2, 1 };
            int limit = 3;

            int result  = Program.NumRescueBoats(people, limit);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int NumRescueBoats(int[] people, int limit)
        {

            Array.Sort(people);

            int start = 0, end = people.Length - 1;
            int boats = 0;

            while (start <= end)
            {

                if (people[start] + people[end] <= limit)
                {
                    start++;
                }
                end--;
                boats++;

            }

            return boats;

        }
    }
}
