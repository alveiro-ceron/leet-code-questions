
// Given an array representing heights of vertical lines, find the maximum area of water that can be contained.
// Solution:
// - Use two pointers, one at the start and one at the end of the array.
// - Calculate the area between the pointers and update the maximum area found.
// - Move the pointer pointing to the shorter line inward to try and find a larger area.
//

var height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

Console.WriteLine($"The maximum amount of water is {MaxArea(height)}");

static int MaxArea(int[] height)
{
    int area = 0;
    int left = 0;
    int right = height.Length - 1;

    while (left < right)
    {
        area = Math.Max(area, (right - left) * Math.Min(height[left], height[right]));

        // Try to find a larger area by moving the pointer of the shorter line
        if (height[left] < height[right])
            left++;
        else
            right--;
    }
    return area;
}