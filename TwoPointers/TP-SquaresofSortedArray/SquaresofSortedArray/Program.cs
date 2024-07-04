namespace SquaresofSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [-7, -3, 2, 3, 11];

            int[] result = Program.SortedSquares(nums);

            Console.WriteLine(result);
        }


        public static int[] SortedSquares(int[] nums)
        {
            int size = nums.Length;
            int[] outputArray = new int[size];


            int left = 0, right = size - 1, index = size-1;

            while(left <= right)
            {

                if (nums[left] * nums[left] >= nums[right] * nums[right])
                    outputArray[index--] = nums[left] * nums[left++];
                else
                    outputArray[index--] = nums[right] * nums[right--];
             
            }

            return outputArray;

        }
    }
}
