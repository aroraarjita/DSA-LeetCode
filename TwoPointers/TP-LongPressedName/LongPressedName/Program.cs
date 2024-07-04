namespace LongPressedName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            bool result = obj.IsLongPressedName("kikcxmvzi", "kiikcxxmmvvzz");
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public bool IsLongPressedName(string name, string typed)
        {

            if(name.Length > typed.Length)
                return false;

            int namePos = 0;  
            int typedPos = 0;

            while (namePos < name.Length)
            {
                

                if (!typed.Contains(name[namePos])) { return false; }  
                
                if(typedPos >= typed.Length) { break; }

                else
                {
                    if(name[namePos] == typed[typedPos])
                    {
                        char charPos = name[namePos];
                        int countInName = 0;

                        while (namePos < name.Length &&
                            name[namePos] == charPos)
                        {
                            countInName++;
                            namePos++;
                        }

                        int countInPressedName = 0;
                        while ( typedPos < typed.Length &&
                            typed[typedPos] == charPos)
                        {
                            countInPressedName++;
                            typedPos++;
                        }

                        if (countInName > countInPressedName) { return false; }

                    }
                    else { return false; }
                   
                }

            }


            if(namePos >= name.Length)
            {
                
                while(typedPos < typed.Length)
                {
                    if (typed[typedPos] != name[namePos-1])
                        return false;

                    typedPos++;
                }
                
            }

            if(typedPos >= typed.Length)
            {
                while (namePos < name.Length)
                {
                    if (name[namePos] != typed[typedPos-1])
                        return false;
                    
                    namePos++;

                }
            }
            

            return true;

        }
    }
}
