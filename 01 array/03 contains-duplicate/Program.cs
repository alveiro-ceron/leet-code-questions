// Given an integer array, determine if any value appears at least twice.
// Use a HashSet to track seen numbers. If a number is already in the set, return true (duplicate found).
// Otherwise, return false if


var nums = new int[] { 1, 2, 3, 1 };
var result = ContainsDuplicates(nums);
var message = result == true ? "The array contains dupplicates":"The array does not contains duplicates";
Console.WriteLine(message);

static bool ContainsDuplicates(int[] nums)
{
    var visitedNums = new HashSet<int>();

    foreach (int num in nums)
    {
        if (!visitedNums.Contains(num))
            visitedNums.Add(num);
        else
            return true;
    }

    return false;
}