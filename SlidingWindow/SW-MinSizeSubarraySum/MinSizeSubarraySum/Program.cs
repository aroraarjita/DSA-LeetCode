using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinSizeSubarraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int target = 7;
            int[] nums = { 2, 3, 1, 2, 4, 3 };

            int minLength = Program.MinSubArrayLen(target,nums);

        }

        public static int MinSubArrayLen(int target, int[] nums)
        {
            int minLength = int.MaxValue;
            int start = 0;
            int end = 0;
            int sum = 0;

            while (end < nums.Length)
            {

                sum += nums[end];
                end++;


                if (start == end && sum == target)
                {
                      return 1;
                }

                while(sum >= target)
                {
                    minLength = Math.Min(minLength, end - start);
                    sum -= nums[start++];
                }
 
            };

            return minLength == int.MaxValue? 0:minLength;
        }
    }
}
