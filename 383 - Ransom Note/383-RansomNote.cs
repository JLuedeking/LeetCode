
// #383. Ransom Note
// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
// Each letter in magazine can only be used once in ransomNote.

// Example 1:
// Input: ransomNote = "a", magazine = "b"
// Output: false

// Example 2:
// Input: ransomNote = "aa", magazine = "ab"
// Output: false

// Example 3:
// Input: ransomNote = "aa", magazine = "aab"
// Output: true

// Constraints:
// 1 <= ransomNote.length, magazine.length <= 10^5
// ransomNote and magazine consist of lowercase English letters.

// Results:
// Runtime: 123 ms, faster than 56.66% of C# online submissions for Ransom Note.
// Memory Usage: 40.4 MB, less than 57.16% of C# online submissions for Ransom Note.
// -------------

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
        List<char> magazineLetters = new List<char>(magazine);
        
        // Iterate through the ransomNote
        for (int i = 0; i < ransomNote.Length; i++)
        {
            // If the index letter in the randomNote exists in the magazine, remove it from the magazine
            if (magazineLetters.Contains(ransomNote[i]))
            {
                magazineLetters.Remove(ransomNote[i]);
            }
            else
            {
                // Otherwise, the letter isn't from the magazine, return false
                return false;
            }
        }
        
        // All the letters could have come from the magazine, return true
        return true;
    }
}