namespace DuplicateZeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [0, 0, 0, 0, 0, 0, 0];
            Program obj = new Program();
            obj.DuplicateZeros(arr);

            Console.WriteLine("Hello, World!");
        }

        public void DuplicateZeros(int[] arr)
        {
            int[] output = new int[arr.Length];
            int newArrayindex = 0;
            int oldArrayIndex = 0;

            while(newArrayindex < output.Length)
            {
                if (arr[oldArrayIndex] != 0)
                {
                    output[newArrayindex++] = arr[oldArrayIndex++];
                }
                else
                {
                    output[newArrayindex] = 0;

                    if(newArrayindex+1 < arr.Length)
                    {
                        output[newArrayindex + 1] = 0;
                    }
                    
                    newArrayindex += 2;
                    oldArrayIndex += 1;
                }

            }

            Array.Copy(output, arr, arr.Length);

        }
    }
}
