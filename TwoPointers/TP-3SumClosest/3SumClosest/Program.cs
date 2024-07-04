namespace _3SumClosest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [0, 1, 2];
            int target = 3;

            int resut = Program.ThreeSumClosest(nums, target);
            Console.WriteLine(resut);
            Console.ReadLine();
        }

        public static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);

            int start = 0, end = nums.Length;
            int minDiff = int.MaxValue;
            int minSum = int.MaxValue;


            for(int i = nums.Length-1; i >= 0; i--)
            {
                end = i-1;
                start = 0;

                while (start < end)
                {
                    int sum = nums[start] + nums[i] + nums[end];

                    int diff = sum - target;

                    if (diff < 0)
                        start++;
                    else if (diff > 0)
                        end--;
                    else if(diff == 0)
                    {
                        minSum = sum;
                        return minSum;
                    }

                    if(Math.Abs(diff) < Math.Abs(minDiff))
                    {
                        minDiff = diff;
                        minSum = sum;
                    }
                       
                        
                }
            }            
            return minSum;
        }

    }
}
