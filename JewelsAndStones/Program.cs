using System;

namespace LeetCodeJewelsAndStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int countJewels = NumJewelsInStones("aA", "aAAbbbb");
            Console.WriteLine("The number of stones that are jewels is: " + countJewels);
        }

        public static int NumJewelsInStones(string J, string S)
        {
            int count = 0;
            foreach(var chS in S)
            {
                foreach(var chJ in J)
                {
                    if (chS == chJ)
                    {
                        ++count;
                        break;
                    }
                }
            }
            return count;
        }
    }
}
