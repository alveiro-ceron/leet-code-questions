// Given an integer array, find all unique triplets that sum to zero.
// Solution:
// - Sort the array to simplify duplicate handling and two-pointer logic.
// - Iterate through the array, fixing one element at a time.
// - For each fixed element, use two pointers (left and right) to find pairs that sum with the fixed element to zero.
// - Skip duplicate elements to avoid repeated triplets.
// - Add each valid triplet to the output list.


var nums = new int[] {-1,0,1,2,-1,-4};
var output = ThreeSum(nums);

foreach (var triplet in output)
{ 
    Console.WriteLine($"{string.Join(", ",triplet)}");
}

static List<List<int>> ThreeSum(int[] nums)
 {
    Array.Sort(nums);
    var output = new List<List<int>>();
    for (int i = 0; i < nums.Length - 2; i++)
    {
        if (i > 0 && nums[i] == nums[i - 1])
            continue; // skip duplicates

        int left = i + 1;
        int rigth = nums.Length - 1;

        while (left < rigth)
        {
            var result = nums[i] + nums[left] + nums[rigth];
            if (result == 0)
            {
                output.Add([nums[i], nums[left], nums[rigth]]);
                while (left < rigth && nums[left] == nums[left + 1])
                    left++;

                while (left < rigth && nums[rigth] == nums[rigth - 1])
                    rigth--;

                left++;
                rigth--;
            }
            else if (result < 0)
            {
                left++;
            }
            else
            {
                rigth--;
            }
        }
    }
    return output;
 } 


