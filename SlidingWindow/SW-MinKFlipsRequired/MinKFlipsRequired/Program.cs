using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinKFlipsRequired
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNums = new int[] { 0, 0, 0, 1, 0, 1, 1, 0 };
            int k = 3;

            int flipCount = Program.MinKBitFlips(arrayOfNums, k);
            Console.WriteLine(flipCount);
            Console.ReadLine();


        }

        public static int MinKBitFlips(int[] nums, int k)
        {

            if (nums == null || nums.Length == 0)
                throw new ArgumentException("Invalid Input.");

            Queue<int> flipIndexes = new Queue<int>();
            int flips = 0;
            int arraySize = nums.Length;

            for(int i = 0; i<arraySize; i++)
            {

                if(flipIndexes.Count >0 && i > flipIndexes.Peek())
                    flipIndexes.Dequeue();


                if(flipIndexes.Count % 2 == nums[i])
                {
                    if (i + k - 1 >= arraySize)
                        return -1;

                    flipIndexes.Enqueue(i+k-1);
                    flips++;

                }
            }

            return flips;

        }

    }
}
