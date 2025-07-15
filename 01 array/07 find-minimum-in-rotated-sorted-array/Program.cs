// Given a rotated sorted array, find the minimum element.
// Solution:
// - Use binary search to efficiently find the minimum.
// - Compare the middle element with the rightmost element to decide which half to search next.
// - If nums[mid] > nums[right], the minimum is in the right half; otherwise, it's in the left half (including mid).
// - Continue until left == right, then return nums[left] as


var nums = new int[] {4,5,6,7,0,1,2};
Console.WriteLine($" the minimum element of the array is: {FindMin(nums)}");


static int FindMin(int[] nums)
{
    int left = 0;
    int rigth = nums.Length - 1;

    while (left < rigth)
    {
        int mid = (left + rigth) / 2;
        if (nums[mid] > nums[rigth])
            left = mid + 1;
        else
            rigth = mid;
    }
    return nums[left];
}