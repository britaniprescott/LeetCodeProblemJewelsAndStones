using System;

namespace LeetCodeSplitAStringInBalancedStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = BalancedStringSplit("RLLLLRRRLR");
            Console.WriteLine("The number of \"balanced\" strings within the string is: " + count);
        }
        public static int BalancedStringSplit(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var count = 0;
            var r = 0;
            var l = 0;
            foreach(var ch in s)
            {
                if (ch == 'R')
                {
                    ++r;
                }
                else if (ch == 'L')
                {
                    ++l;
                }

                if (r == l)
                {
                    ++count;
                }
            }
            return count;
        }
    }

}
