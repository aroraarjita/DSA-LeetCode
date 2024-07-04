namespace ReverseAnAray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            //Program.PrintArray(arr);
            //Program.PrintArray(Program.ReverseArray(arr));

            Program.ReverseUsingAStack(arr);


            Console.ReadLine();
        }

        //Reverse an array without using an additional array space
        public static int[] ReverseArray(int[] array)
        {
            int start = 0;
            int end = array.Length-1;
            int temp;

            while (start <= end)
            {
                temp = array[end];
                array[end] = array[start];
                array[start] = temp;

                start++;
                end--;
            }
            return array;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);

            }

            Console.WriteLine();
        }

        public static void ReverseUsingAStack(int[] array)
        {
            Stack<int> stack = new Stack<int>();

            for(int i=0; i < array.Length; i++)
            {
                stack.Push(array[i]);

            }

            
            while (stack.Count > 0)
            {
                int ele = stack.Pop();
                Console.Write(ele);
                


            }

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
