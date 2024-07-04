namespace SwapAdjacentLRString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string start = "RXXLRXRXL", end = "XRLXXRRLX";
            string start = "X", end = "L";

            bool result = Program.CanTransform(start, end);
            Console.WriteLine(result);
            Console.ReadLine();
        }



        public static bool CanTransform(string start, string end)
        {

            if (start.Length == 1 && start.Equals(end))
                return false;
            else if(start.Equals(end)) 
                return true;


            IList<Tuple<char,int>> startMap = new List<Tuple<char,int>>();
            IList<Tuple<char,int>> endMap = new List<Tuple<char,int>>();


            for(int i=0; i< start.Length; i++)
            {

                if (start[i] != 'X')
                {
                    startMap.Add(new Tuple<char, int>(start[i],i));
                }
                if (end[i] != 'X')
                {
                    endMap.Add(new Tuple<char, int>(end[i],i));
                }
            }

            if (startMap.Count != endMap.Count || startMap.Count == start.Length)
                return false;
            else
            {

                for(int i=0; i<startMap.Count; i++)
                {
                    if (startMap[i].Item1 == 'L' && startMap[i].Item2 < endMap[i].Item2)
                        return false;

                    if (startMap[i].Item1 == 'R' && startMap[i].Item2 > endMap[i].Item2)
                        return false;
                }

            }

            return true;
        }
    }
}
