// Top K Frequent Elements
// Given an integer array nums and an integer k, return the k most frequent elements within the array.

// The test cases are generated such that the answer is always unique.

// You may return the output in any order.

// Example 1:

// Input: nums = [1,2,2,3,3,3], k = 2

// Output: [2,3]
// Example 2:

// Input: nums = [7,7], k = 1

// Output: [7]
// Constraints:

// 1 <= nums.length <= 10^4.
// -1000 <= nums[i] <= 1000
// 1 <= k <= number of distinct elements in nums.
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> numStore = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (!numStore.ContainsKey(num))
            {
                numStore[num] = 0;
            }
            numStore[num]++;
        }

        List<List<int>> bucketList = new List<List<int>>();

        foreach (int numKey in numStore.Keys)
        {
            int numFrequency = numStore[numKey];

            while (bucketList.Count <= numFrequency)
            {
                bucketList.Add(new List<int>());
            }

            bucketList[numFrequency].Add(numKey);
        }

        List<int> outputList = new List<int>();

        for (int i = bucketList.Count - 1; i > 0 && outputList.Count < k; i--)
        {
            if (bucketList[i] != null && bucketList[i].Count > 0)
            {
                outputList.AddRange(bucketList[i]);
            }
        }
        return outputList.ToArray();
    }
}
