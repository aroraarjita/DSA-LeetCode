using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindowMaximim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 3;
            int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };

            int[] maxWindowArray = Program.MaxSlidingWindow(nums, k);

        }

        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            int n = nums.Length;
            int[] maxWindow = new int[n-k+1];
            int resultIndex = 0;

            LinkedList<int> dequeue = new LinkedList<int>();


            for(int i=0; i<n; i++)
            {

                while(dequeue.Count> 0 && dequeue.First.Value < i - k + 1)
                {
                    dequeue.RemoveFirst();
                }



                while(dequeue.Count > 0 && nums[dequeue.Last.Value] < nums[i])
                {
                    dequeue.RemoveLast();
                }


                dequeue.AddLast(i);

                if(i >= k - 1)
                {
                    maxWindow[resultIndex++] = nums[dequeue.First.Value];
                }


            }

           return maxWindow;

        }

    }
}
