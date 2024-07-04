namespace FindKClosestElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1];
            int k = 1, x = 0;

            Program obj = new Program();

            IList<int> res = new List<int>();
            res =  obj.FindClosestElements(arr, k,x);

            foreach (int i in res)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
            Console.WriteLine("Hello, World!");
        }


        //Space Comlexity- O(1)
        //Time Complexity - O(n)
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            List<int> result = new();

            int start = 0;
            int end = arr.Length-1;

 
            while(end-start >= k)
            {

                if (Math.Abs(arr[end]- x) >= Math.Abs(arr[start] - x))
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }


            for(int i = start; i<=end; i++ )
            {
                result.Add(arr[i]);

            }

            return result;
        }


        //Space Complexity - O(log(n)+k)
        //Time Complexity - O(1)
        public IList<int> FindClosestElementsUpdated(int[] arr, int k, int x)
        {
            List<int> result = new List<int>();
            int mid = FindMidNumByBinarySearch(arr, x);
            int left = Math.Max(0, mid - k);
            int right = Math.Min(arr.Length-1, mid + k);

            while(right - left >= k)
            {
                if (Math.Abs(arr[left] -x) > Math.Abs(arr[right] - x))
                {
                    left++;
                }
                else if (Math.Abs(arr[right] -x) >= Math.Abs(arr[left]-x)) { right--; }
            }



            return arr[left..(right + 1)];


        }
         private int FindMidNumByBinarySearch(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            int mid = 0;

            while (start <= end)
            {
                mid = start + (end - start) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] > target)
                    end = mid - 1;
                else
                    start = mid + 1;


            }

            return mid;
        }
    }
}
