// Given an integer array, find the contiguous subarray with the largest sum (Kadane's Algorithm).
// Solution:
// - Initialize two variables: one to track the current subarray sum, and one for the maximum found so far.
// - Iterate through the array, updating the current sum as the maximum of the current number or current sum plus the number.
// - Update the maximum if the current sum is greater.
// - Return the maximum subarray sum found.

var nums = new int[] {-2,1,-3,4,-1,2,1,-5,4 };

Console.WriteLine($" the maximum sub array sum is: {MaxSubArray(nums)}");

static int MaxSubArray(int[] nums)
{
    int maxGlobal = nums[0];
    int maxActual = nums[0];

    for (int i = 1; i < nums.Length; i++)
    {
        maxActual = Math.Max(nums[i], maxActual + nums[i]);
        maxGlobal = Math.Max(maxActual, maxGlobal);
    }
    return maxGlobal;
}