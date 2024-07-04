namespace StatisticsFromASample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] count = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 240, 828, 1343, 1901, 2446, 3016, 3784, 4190, 
                4691, 5268, 5897, 6444, 7035, 7520, 7960, 8488, 9167, 9863, 
                10176, 10877, 11382, 12168, 12588, 12975, 13374, 14385, 14676, 
                15250, 15775, 16407, 16909, 17471, 17899, 18785, 19235, 19883, 
                20201, 20828, 21217, 21943, 21952, 21457, 21075, 20910, 20382, 
                19910, 19309, 18784, 18364, 18027, 17489, 17061, 16687, 16207, 
                15703, 15436, 15049, 14603, 14183, 13424, 13115, 12474, 12293, 
                11693, 11264, 10853, 10640, 9810, 9752, 9182, 8770, 8224, 7680, 
                7234, 6851, 6450, 5927, 5698, 5002, 4620, 4206, 3694, 3297, 2871, 
                2435, 1948, 1545, 1114, 650, 211, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

            double[] result = Program.SampleStats(count);

            Console.WriteLine("Min: " + result[0]);
            Console.WriteLine("Max: " + result[1]);
            Console.WriteLine("Mean: " + result[2]);
            Console.WriteLine("Median: " + result[3]);
            Console.WriteLine("Mode: " + result[4]);


            Console.ReadLine();
        }

        public static double[] SampleStats(int[] count)
        {
            double min = -1;
            double max = 0;
            long totalSum = 0;
            int numberOfElements = 0;
            double modeKey = 0;
            double modeValue = 0;
         


            for (int i = 0; i< count.Length; i++)
            {

                if (count[i] != 0)
                {
                    if(min == -1)
                    {
                        min = i;
                    }

                    if (count[i] > modeValue)
                    {
                        modeValue = count[i];
                        modeKey = i;

                    }

                    max = i;
                    totalSum += (long)i * count[i];
                    numberOfElements += count[i];

                }

              
            }

            double mean = totalSum /(double)numberOfElements;

            return new double[] { min, max, mean, getMedian(count, numberOfElements), modeKey };

        }


        private static double getMedian(int[] count, int numberOfElements)
        {

            if(numberOfElements % 2 == 0)
            {
                return getMedianEven(count, numberOfElements);
            }
            else
            {
                return getMedianOdd(count, numberOfElements);
            }


        }

        public static double getMedianOdd(int[] count, int numberOfElements)
        {
            int targetCount = numberOfElements / 2 + 1;
            int median = -1;

            int countSoFar = 0;

            for(int i = 0;i< count.Length;i++)
            {
                countSoFar += count[i];
                if(countSoFar >= targetCount)
                {
                    median = i;
                    break;


                }

            }
            return median;

        }

        public static double getMedianEven(int[] count, int numberOfElements)
        {
            int targetCount = numberOfElements / 2;
            int countSoFar = 0;
            double left = 0, right = 0;

           
            for(int i = 0; i< count.Length;i++)
            {

                countSoFar+= count[i];

                if(countSoFar >= targetCount + 1)
                {
                    left = i;
                    right = i;
                    break;

                }
                else if(countSoFar == targetCount)
                {
                    left = i;

                    for(int j = i+1; j< count.Length; j++)
                    {

                        if (count[j] != 0)
                        {
                            right = j;
                            break;
                        }
                    }
                    break;
                }
            }

            return (left + right) / 2;

        }
    }
}
