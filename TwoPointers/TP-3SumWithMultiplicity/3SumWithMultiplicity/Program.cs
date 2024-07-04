using System.Reflection;

namespace _3SumWithMultiplicity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [0, 2, 0];
            int res = Program.ThreeSumMulti(arr, 2);

            Console.WriteLine(res);
            Console.ReadLine();

        }


        public static int ThreeSumMulti(int[] arr, int target)
        {

            Dictionary<int, int> counts = arr.GroupBy(x => x).ToDictionary(g => g.Key,
                g => g.Count());
             int[] uniqueValues = counts.Keys.OrderBy(x => x).ToArray();

            long numOfSums = 0;
            const long Modulo = 1_000_000_007;

            for (int i=0; i < uniqueValues.Length; i++)
            {

               for (int j = i; j < uniqueValues.Length; j++)
                 {
                        int val = target - (uniqueValues[i] + uniqueValues[j]);

                    if (uniqueValues.Contains(val))
                    {
                       
                        if (val < uniqueValues[j])
                            break;

                        if (counts.ContainsKey(val))
                        {
                            if (uniqueValues[i] == uniqueValues[j] && 
                                uniqueValues[j] == val)
                            {
                                numOfSums += (long)((((long)counts[uniqueValues[i]] * ((long)counts[uniqueValues[i]] - 1)
                                    * ((long)counts[uniqueValues[i]] - 2)) / 6) % Modulo);
                            }

                            else if (uniqueValues[i] == uniqueValues[j])
                            {
                                numOfSums += (long)((((((long)counts[uniqueValues[j]] - 1) * 
                                    ((long)counts[uniqueValues[j]])) / 2) *
                                   (long)counts[val]) % Modulo);
                            }
                            else if (uniqueValues[j] == val)
                            {
                                numOfSums += (long)(((long)counts[uniqueValues[i]] * ((long)(counts[uniqueValues[j]]) *
                                ((long)counts[uniqueValues[j]] - 1)) / 2) % Modulo);

                            }
                            else
                            {
                                numOfSums += (long)(((long)counts[uniqueValues[i]] * (long)counts[uniqueValues[j]] *
                                    (long)counts[val]) % Modulo);

                                
                            }

                        }
                    
                      }
                      
                    }
            }

            return (int)numOfSums;

        }

    }
}
