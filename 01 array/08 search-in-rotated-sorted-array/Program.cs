// Given a rotated sorted array and a target value, find the index of the target.
// Solution:
// - Use binary search to efficiently search for the target.
// - Determine which half of the array is sorted at each step.
// - If the target is within the sorted half, adjust the search range accordingly.
// - Continue until the target is found or the search range is empty.

var nums = new int[] { 30, 40, 50, 5, 10, 15, 20, 25};
var target = 25;
Console.WriteLine($" The target is in the index: {SearchTarget(nums, target)}");

static int SearchTarget(int[] nums, int target)
{
    int left = 0;
    int rigth = nums.Length - 1;

    while (left <= rigth)
    {
        int mid = (left + rigth) / 2;
        if (nums[mid] == target)
            return mid;

        if (nums[left] <= nums[mid])
        {
            if (nums[left] <= target && target < nums[mid])
                rigth = mid - 1;
            else
                left = mid + 1;
        }
        else
        {
            if (nums[mid] < target && target <= nums[rigth])
                left = mid + 1;
            else
                rigth = mid - 1;
        }
    }
    return -1;  
}