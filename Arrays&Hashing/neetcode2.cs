// Is Anagram
// Given two strings s and t, return true if the two strings are anagrams of each other, otherwise return false.

// An anagram is a string that contains the exact same characters as another string, but the order of the characters can be different.

// Example 1:

// Input: s = "racecar", t = "carrace"

// Output: true
// Example 2:

// Input: s = "jar", t = "jam"

// Output: false
// Constraints:

// s and t consist of lowercase English letters.

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> sLog = new Dictionary<char, int>();
        Dictionary<char, int> tLog = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (sLog.ContainsKey(s[i]))
            {
                sLog[s[i]]++;
            }
            else
            {
                sLog[s[i]] = 1;
            }
        }
        for (int j = 0; j < t.Length; j++)
        {
            if (tLog.ContainsKey(t[j]))
            {
                tLog[t[j]]++;
            }
            else
            {
                tLog[t[j]] = 1;
            }
        }

        foreach (char key in sLog.Keys)
        {
            if (!tLog.ContainsKey(key))
            {
                return false;
            }
            if (tLog[key] != sLog[key])
            {
                return false;
            }
        }
        return true;
    }
}
