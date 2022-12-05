using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSquares
{
    internal class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            var sortedArr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                sortedArr[i] = nums[i] * nums[i];
            }

            Array.Sort(sortedArr);

            return sortedArr;
        }
    }
}
