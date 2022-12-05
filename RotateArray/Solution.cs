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
            if (k > nums.Length)
            {
                for (int i = nums.Length - 1; i < k; i++)
                {
                    nums.SetValue(0, i);
                }
            }

            var rotated = new int[nums.Length];

            Array.Copy(nums, nums.Length - k, rotated, 0, k);
            Array.Copy(nums, 0, rotated, k, nums.Length - k);

            Array.Copy(rotated, nums, nums.Length);
        }
    }
}
