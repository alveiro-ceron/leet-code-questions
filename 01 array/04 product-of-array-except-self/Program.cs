
// Given an integer array, return an array where each element is the product of all elements except itself.
// Do not use division and achieve O(n) time complexity.
// Solution: 
// - Compute prefix products (left to right) and store in an array.
// - Compute suffix products (right to left) and store in another array.
// - The result at each index is the product of the prefix and suffix



var nums = new int[]{1,2,3,4,5};
var result = ProductArray(nums);
Console.WriteLine(string.Join(", ", result));


static int[] ProductArray(int[] nums)
{
    var leftProduct = 1;
    var leftResult = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        int leftnumber = i > 0 ? nums[i - 1] : 1;
        leftProduct *= leftnumber;
        leftResult[i] = leftProduct;
    }
    
      var rightProduct = 1;
      var rightResult = new int[nums.Length];

    for (int i = nums.Length -1; i >= 0; i--)
    {
        int  rnumber = i == nums.Length-1 ? 1 : nums[i + 1] ;
        rightProduct *= rnumber;
        rightResult[i] = rightProduct;
    }

    var finalResult = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        finalResult[i] = rightResult[i] * leftResult[i];
    }

    return finalResult;
}