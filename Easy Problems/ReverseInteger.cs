using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions_CSharp.Easy_Problems
{
    //Runtime: 73 ms, faster than 5.18% of C# online submissions for Reverse Integer.
    //Memory Usage: 15.5 MB, less than 45.58% of C# online submissions for Reverse Integer.
    public static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            try
            {
                bool isNegative = x < 0;
                int sortedNumber;

                x = isNegative ? x * -1 : x;

                char[] stringFormat = x.ToString().ToCharArray();
                int length = stringFormat.Length;
                char[] sortedNumberArray = new char[length + 1];


                foreach (char c in stringFormat)
                {
                    sortedNumberArray[--length] = c;
                }

                sortedNumber = isNegative ? int.Parse(sortedNumberArray) * -1 : int.Parse(sortedNumberArray);

                return sortedNumber;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
