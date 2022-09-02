
// #3. Longest Substring Without Repeating Characters
// Given a string s, find the length of the longest substring without repeating characters.

// Example 1:
// Input: s = "abcabcbb"
// Output: 3

// Example 2:
// Input: s = "bbbbb"
// Output: 1

// Example 3:
// Input: s = "pwwkew"
// Output: 3

// Constraints:
// 0 <= s.length <= 5 * 10^4
// s consists of English letters, digits, symbols and spaces.

// Results:
// Runtime: 70 ms, faster than 96.44% of C# online submissions for Longest Substring Without Repeating Characters.
// Memory Usage: 36.8 MB, less than 82.19% of C# online submissions for Longest Substring Without Repeating Characters.
// -------------

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<char> longestSubstring = new List<char>();
        List<char> testSubstring = new List<char>();
        
        // Iterate through string
        for (int i = 0; i < s.Length; i++)
        {
            // If testSubstring doesn't contain the index letter, add it
            if (!testSubstring.Contains(s[i]))
            {
                testSubstring.Add(s[i]);
            }
            else
            {
                // If it does, then check if testSubstring is longer than the current longestSubstring
                if (testSubstring.Count > longestSubstring.Count)
                {
                    // set new longestSubstring since the testSubstring is longer
                    longestSubstring = new List<char>(testSubstring);
                }
                
                // Add newest char to list
                testSubstring.Add(s[i]);
                
                // Delete letters in the testSubstring at and before the index of the first duplicate letter
                for (int j = testSubstring.FindIndex(a => a == s[i]); j>=0; j--)
                {
                    testSubstring.Remove(testSubstring[j]);
                }
            }         
        }
        
        // Return the list that contains the longest substring
        if (testSubstring.Count > longestSubstring.Count)
        {
            return testSubstring.Count;
        }
        else
        {
            return longestSubstring.Count;
        }
    }
}