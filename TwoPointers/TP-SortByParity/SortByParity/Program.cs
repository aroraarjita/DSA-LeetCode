using System.Reflection.Metadata.Ecma335;

namespace SortByParity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            int[] nums = [2, 3];

            int[] results = obj.SortArrayByParityII(nums);

            foreach (int i in results)
            {
                Console.WriteLine(i);

            }
            Console.ReadLine();
        }

        public int[] SortArrayByParityII(int[] nums)
        {
            int[] odds = new int[nums.Length/2];
            int[] evens = new int[nums.Length/2];


            int oddIdx = 0;
            int evenIdx = 0;
            foreach(int num in nums)
            {
                if(num % 2 == 0)
                {
                    evens[evenIdx] = num;
                    evenIdx++;
                }
                else
                {
                    odds[oddIdx] = num;
                    oddIdx++;
                }
            }

            int[] results = new int[nums.Length];

            evenIdx = 0;
            oddIdx = 0;
            for(int i= 0; i< nums.Length; i++)
            {

                if(i %2 == 0)
                {
                    results[i] = evens[evenIdx];
                    evenIdx++;
                }
                else
                {
                    results[i] = odds[oddIdx];
                    oddIdx++;
                }

            }


            return results;

        }
    }
}
