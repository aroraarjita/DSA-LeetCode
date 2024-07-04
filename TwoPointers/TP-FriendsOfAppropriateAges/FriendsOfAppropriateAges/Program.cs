namespace FriendsOfAppropriateAges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ages = [73, 106, 39, 6, 26, 15, 30, 100, 71, 35, 46, 112, 6, 60, 110];

            int numOfRequests = Program.NumFriendRequests(ages);

            Console.WriteLine(numOfRequests);
            Console.ReadLine();


        }

        public static int NumFriendRequests(int[] ages)
        {

            Array.Sort(ages);

            int numberOfRequests = 0;
            for (int i = ages.Length - 1; i >= 0; i--)
            {
                int duplicates = 0;
                duplicates = ages.Take(i).Count(x => x == ages[i]);
                double cutOff = (Int32)(0.5 * ages[i]) + 7;

                if (duplicates > 0)
                {           
                    if (ages[i] > cutOff)
                    numberOfRequests = numberOfRequests + (duplicates * 2);

                }

                numberOfRequests += ages.Take(i - duplicates).Count(x => x > cutOff);

            }


            return numberOfRequests;

        }

        public static int NumFriendRequestsModified(int[] ages)
        {

            int[] age = new int[121];

            for(int i=0; i<ages.Length; i++)
            {
                age[ages[i]]++;

            }

            int count = 0;
            for(int i=1; i<=120; i++)
            {
                for(int j= (i/2+8); j<=i; j++)
                {
                    count = count + age[i] * (age[j] - (i == j ? 1 : 0));

                }
            }
            return count;

        }

    }
}
