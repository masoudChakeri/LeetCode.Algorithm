using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsert
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target, int ind = 0)
        {
            var result = -1;

            if (nums.Length == 1)
            {
                if (target > nums[0])
                {
                    return 1;
                }

                if (target < nums[0])
                {
                    return 0;
                }
            }

            if (target > nums[^1])
            {
                return nums.Length;
            }

            if (target < nums[0])
            {
                return 0;
            }

            var n = nums.Length / 2;

            if (nums.Length == 2)
            {
                if (target > nums[0] && nums[1] > target)
                {
                    return 1;
                }
            }
            else
            {
                if (target > nums[n] && nums[n + 1] > target)
                {
                    return ind + n + 1;
                }
            }


            if (nums[n] == target)
            {
                result = n + ind;
                Console.WriteLine(result);
                return result;
            }

            if (target < nums[n])
            {
                return SearchInsert(nums[0..n], target, ind);
            }
            else if (target > nums[n])
            {
                ind += n;
                return SearchInsert(nums[n..nums.Length], target, ind);
            }

            Console.WriteLine(result);
            return result;

        }

    }
}
