// Anagram Groups
// Given an array of strings strs, group all anagrams together into sublists. You may return the output in any order.

// An anagram is a string that contains the exact same characters as another string, but the order of the characters can be different.

// Example 1:

// Input: strs = ["act","pots","tops","cat","stop","hat"]

// Output: [["hat"],["act", "cat"],["stop", "pots", "tops"]]
// Example 2:

// Input: strs = ["x"]

// Output: [["x"]]
// Example 3:

// Input: strs = [""]

// Output: [[""]]
// Constraints:

// 1 <= strs.length <= 1000.
// 0 <= strs[i].length <= 100
// strs[i] is made up of lowercase English letters.


public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> stringLog = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            string word = strs[i];
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string sortedChars = new string(chars);
            if (!stringLog.ContainsKey(sortedChars))
            {
                stringLog[sortedChars] = new List<string>();
            }
            stringLog[sortedChars].Add(word);
        }
        return stringLog.Values.ToList<List<string>>();
    }
}