using RotateArray;

var nums = new int[] { -1 };
var k = 2;

var ro = new Solution();    
ro.Rotate(nums, k);

foreach (var num in nums)
{
    Console.WriteLine(num);
}