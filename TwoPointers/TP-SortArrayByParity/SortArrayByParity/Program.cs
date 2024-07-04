namespace SortArrayByParity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            int[] nums = [3, 1, 2, 4];
            int[] res = obj.SortArrayByParity(nums);

            Console.WriteLine("Hello, World!");
        }

        public int[] SortArrayByParity(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            int index = 0;
            int[] outputArray = new int[nums.Length];
            
            while (start <= end)
            {
                if (nums[index] % 2 ==0)
                {
                    outputArray[start] = nums[index];
                    start++;
                }
                else
                {
                    outputArray[end] = nums[index];
                    end--;
                }
                index++;

            }

            return outputArray;
        }
    }
}
