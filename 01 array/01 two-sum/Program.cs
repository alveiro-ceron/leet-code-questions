// Given an array of integers and a target value, find the indices of two numbers such that they add up to the target.
// Use a dictionary to store each number's value and index as you iterate.
// For each number, check if the complement (target - current number) exists in the dictionary.
// If found, return the indices of the complement and the current value


var nums = new[] { 4, 7, 11, 6, 9 };
var target = 13;

var result = TwoSum(nums, target);
Console.WriteLine($"indices: {result[0]}, {result[1]}"); // Expected output: indices [1, 3] (7 + 6)

static int[] TwoSum(int[] nums , int target)
{
    var dictionaryValues = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        var complement = target - nums[i];

        if (!dictionaryValues.ContainsKey(complement))
        {
            dictionaryValues.Add(nums[i], i);
        }
        else
        {
            return new int[] { dictionaryValues[complement], i };
        }
    }
    return Array.Empty<int>();
}