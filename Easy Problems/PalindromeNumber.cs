using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions_CSharp.Easy_Problems
{
    public static class PalindromeNumber
    {
        //Runtime: 76 ms, faster than 30.08% of C# online submissions for Palindrome Number.
        //Memory Usage: 17.7 MB, less than 31.47% of C# online submissions for Palindrome Number.
        public static bool IsPalindrome(int x)
        {
            var arr = x.ToString().ToCharArray();

            for(int i = 0; i < arr.Length - 1; i++)
            {
                if(arr[i] != arr[arr.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
