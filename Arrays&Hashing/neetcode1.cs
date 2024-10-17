// DUPLICATE INTEGER

// Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.

// Example 1:

// Input: nums = [1, 2, 3, 3]

// Output: true
// Example 2:

// Input: nums = [1, 2, 3, 4]

// Output: false

public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        Dictionary<int, int> numStore = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (numStore.ContainsKey(nums[i]))
            {
                return true;
            }
            else
            {
                numStore[nums[i]] = 1;
            }
        }
        return false;
    }
}
