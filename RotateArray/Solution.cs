using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    internal class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            var rotated = new int[nums.Length];

            Array.Copy(nums, nums.Length - k, rotated, 0, k);
            Array.Copy(nums, 0, rotated, k, nums.Length - k);

            Array.Copy(rotated, nums, nums.Length);
        }
    }
}
