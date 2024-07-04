namespace SubarrayProductLessThanK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [10, 5, 2, 6];
            int k = 100;

            int result = NumSubarrayProductLessThanK(nums, k);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (k <= 1) return 0;


            int start = 0, end = 0, count = 0;
            int product = 1;


            while(end < nums.Length)
            {
                product *= nums[end];

                while(product >= k)
                {
                    product /= nums[start];
                    start++;

                }

                count += 1 + (end - start);
                end++;
            }
            return count;

        }
    }
}
