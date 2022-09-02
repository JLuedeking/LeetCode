
// #9. Palindrome Number
// Given an integer x, return true if x is palindrome integer.
// An integer is a palindrome when it reads the same backward as forward.
// For example, 121 is a palindrome while 123 is not.

// Example 1:
// Input: x = 121
// Output: true

// Example 2.
// Input: x = -121
// Output: false

// Example 3.
// Input: x = 10
// Output: false

// Constraints:
// -2^31 <= x <= 2^31 - 1

// Results:
// Runtime: 58 ms, faster than 80.59% of C# online submissions for Palindrome Number.
// Memory Usage: 28.2 MB, less than 83.79% of C# online submissions for Palindrome Number.
// -------------

public class Solution {
    public bool IsPalindrome(int x) {

        // Convert int to string for easier comparison
        string intToString = x.ToString();
        
        // Loop that string comparing the index position of the loop relative to the reverse index of the string
        for (int i=0; i < intToString.Length / 2; i++)
        {
            if (intToString[i] != intToString[intToString.Length-i-1])
            {
                // Value mismatch, not a palindrome
                return false;
            }   
        }
        
        // Everything was matched! Valid palindrome
        return true;
    }
}