// DUPLICATE INTEGER

// Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.

// Example 1:

// Input: nums = [1, 2, 3, 3]

// Output: true
// Example 2:

// Input: nums = [1, 2, 3, 4]

// Output: false

class Solution
{
    public boolean hasDuplicate(int[] nums)
    {
        HashMap<Integer, Integer> numStore = new HashMap<Integer, Integer>();
        for (int i = 0; i < nums.length; i++)
        {
            if (numStore.containsKey(nums[i]))
            {
                return true;
            }
            else
            {
                numStore.put(nums[i], 1);
            }
        }
        return false;
    }
}
