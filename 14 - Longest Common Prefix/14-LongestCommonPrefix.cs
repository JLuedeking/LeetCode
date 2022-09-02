
// #14. Longest Common Prefix
// Write a function to find the longest common prefix string amongst an array of strings.
// If there is no common prefix, return an empty string ""

// Example 1:
// Input: strs = ["flower","flow","flight"]
// Output: "fl"

// Example 2:
// Input: strs = ["dog","racecar","car"]
// Output: ""

// Constraints:
// 1 <= strs.length <= 200
// 0 <= strs[i].length <= 200
// strs[i] consists of only lowercase English letters.

// Results:
// Runtime: 113 ms, faster than 82.22% of C# online submissions for Longest Common Prefix.
// Memory Usage: 38.3 MB, less than 83.20% of C# online submissions for Longest Common Prefix.
// -------------

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        List<char> longestPrefixList = new List<char>();
        int shortestString = strs[0].Length; // Setting initial length of first string
        string result;
        
        // Loop through remaining string array to find shortest string
        for (int i = 1; i < strs.Length; i++)
        {
            if (strs[i].Length < shortestString)
            {
                shortestString = strs[i].Length;
            }
        }
        
        // Loop through each letter of first string
        for (int i = 0; i < shortestString; i++)
        {
            // Compare each letter position from each string in the array to make sure they match
            for (int j = 0; j < strs.Length; j++)
            {
                // If they don't, the longest prefix is found, return current longestPrefixList
                if (strs[j][i] != strs[0][i])
                {
                    result = new string(longestPrefixList.ToArray());
                    return result;
                }
            }
            
            // If all letters match for that letter position, add the letter to the longestPrefixList
            longestPrefixList.Add(strs[0][i]);
        }
        
        // Each string uses the same letters up to the shortest string length, horray! Return the longestPrefixList
        result = new string(longestPrefixList.ToArray());
        return result;
    }
}