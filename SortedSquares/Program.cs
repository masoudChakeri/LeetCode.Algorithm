
using SortedSquares;

var nums = new int[] { -4, -1, 0, 3, 10 };

var sq = new Solution();

foreach (var el in sq.SortedSquares(nums))
{
    Console.WriteLine(el);
}