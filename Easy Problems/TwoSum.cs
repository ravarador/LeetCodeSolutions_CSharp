using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions_CSharp.Easy_Problems
{
    //Runtime: 332 ms, faster than 33.95% of C# online submissions for Two Sum.
    //Memory Usage: 32.3 MB, less than 90.16% of C# online submissions for Two Sum.
    public static class TwoSum
    {
        public static int[] GetTwoSum(int[] nums, int target)
        {
            int[] addends = new int[2];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if(target - nums[i] == nums[j])
                    {
                        addends[0] = i;
                        addends[1] = j;
                    }
                }
            }

            return addends;
        }
    }
}

