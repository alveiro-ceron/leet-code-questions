// Given an integer array, find the contiguous subarray with the largest product.
// Solution:
// - Track both the maximum and minimum products ending at each position (to handle negative numbers).
// - For each element, compute possible products with previous max/min and the current number.
// - Update the global maximum product found so far.
// - Return the maximum product of any

var nums = new int[] {0,2,-3,4,-5};

Console.WriteLine($" the maximum product is: {MaxProduct(nums)}");

static int MaxProduct(int[] nums)
{
    int maxProd = nums[0];
    int minProd = nums[0];
    int maxGlobal = nums[0];

    for (int i = 1; i < nums.Length; i++)
    {
        var candidate1 = nums[i];
        var candidate2 = maxProd * nums[i];
        var candidate3 = minProd * nums[i];

        maxProd = Math.Max(candidate1, Math.Max(candidate2, candidate3));
        minProd = Math.Min(candidate1, Math.Min(candidate2, candidate3));
        maxGlobal = maxProd > maxGlobal ? maxProd : maxGlobal;
    }
    return maxGlobal;
}