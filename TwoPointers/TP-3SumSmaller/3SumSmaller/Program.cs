namespace _3SumSmaller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [3, 1, 0, -2];
            int target = 4;

            int result = Program.ThreeSumSmaller(nums, target);
            Console.WriteLine(result);
            Console.ReadLine();

        }


        public static int ThreeSumSmaller(int[] nums, int target)
        {
            if(nums.Length == 0)
            {
                return 0;
            }

            Array.Sort(nums);
            int countTriplets= 0;
            for(int i=0; i<nums.Length; i++)
            {
                int start = i+1;
                int end = nums.Length - 1;

                while(start < end)
                {
                    int sum = nums[i] + nums[start] + nums[end];

                    if (sum < target)
                    {
                        countTriplets += end - start;
                        start++;

                    }
                    else
                        end--;          
                }

            }

            return countTriplets;
        }
    }
}
