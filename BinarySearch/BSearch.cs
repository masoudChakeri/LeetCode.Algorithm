using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class BSearch
    {
        public int Search(int[] nums, int target, int ind = 0)
        {
            var result = -1;

            if (nums.Length == 1)
            {
                if (nums[0] == target)
                {
                    result = ind;
                    Console.WriteLine(result);
                    return result;
                }

                Console.WriteLine(result);
                return result;
            }


            var n = nums.Length / 2;

            if (nums[n] == target)
            {
                result = n + ind;
                Console.WriteLine(result);
                return result;
            }

            if (target < nums[n])
            {
                return Search(nums[0..n], target, ind);
            }
            else if (target > nums[n])
            {
                ind += n;
                return Search(nums[n..nums.Length], target, ind);
            }

            Console.WriteLine(result);
            return result;
        }
    }
}
