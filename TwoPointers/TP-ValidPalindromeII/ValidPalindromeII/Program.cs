namespace ValidPalindromeII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "cbbcc" ;

            Program.ValidPalindrome2(s);
            bool result = Program.ValidPalindrome(s);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static bool ValidPalindrome(string s)
        {
            if(s.Length == 0) { return  false; }

            int start = 0;
            int end = s.Length-1;

            while (start < end) { 
            
                if (s[start] != s[end])
                {
                    string temp = s.Remove(start, 1);

                    char[] reversedArray = temp.ToCharArray();
                    Array.Reverse(reversedArray);
                    string reversedString = new string(reversedArray);

                    if (temp != reversedString)
                    {
                        return false;
                    }

                }

                start++;
                end--;
            
            }

            return true;

        }


        public static bool ValidPalindrome2(string s)
        {
            if (s.Length == 0) { return false; }

            int left = 0;
            int right = s.Length - 1;

            if (s[left] == s[right])
            {
                left++;
                right--;
            }
            else
              return  Program.IsPallindrome(s, left + 1, right) || Program.IsPallindrome(s, left, right - 1);



          
            return true;

        }

        public static bool IsPallindrome(string s, int left, int right)
        {

            while(left < right)
            {
                if (s[left] != s[right]) { return false; }
                left++;
                right--;

            }

            return true;

        }
    }
}
