namespace SortColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [2, 0, 1];

            Program.Sort(nums);

            Console.WriteLine("Hello, World!");
        }

        //Approach-1
        public static void SortColors(int[] nums)
        {

            int min = nums.Min();
            int max = nums.Max();

            int[] occurencesArray = new int[max-min+1];


            for(int i = 0; i < nums.Length; i++)
            {
                occurencesArray[nums[i] - min]++;
            }


            int arrayIndex = 0;
            //Getting back the sorted array
            for(int i = 0; i < occurencesArray.Length;i++)
            {

                while (occurencesArray[i] > 0)
                {
                    nums[arrayIndex++] = i + min;
                    occurencesArray[i]--;
                }


            }

        }


        //Approach-2
        public static void Sort(int[] nums)
        {

            int min = nums.Min();
            int max = nums.Max();

            int[] countArray = new int[max + 1];
            
            for(int i = 0;i < nums.Length;i++) {
                countArray[nums[i] - min]++;
            }

            //Prefix sum array or cumulative sum array
            for(int i=1;i < countArray.Length; i++)
            {
                countArray[i] = countArray[i-1]+ countArray[i];
            }

            int[] outputArray = new int[nums.Length];
            //output Array
            for(int i= 0;i < nums.Length;i++)
            {
                int current = nums[i];

                outputArray[countArray[current-min]-1] = current;
                countArray[current - min]--;

            }

            Array.Copy(outputArray,nums,outputArray.Length);

            //Sorted Array
            for(int i=0;i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();

        }


    }
}
