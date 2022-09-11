
// #20. Valid Parentheses
// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

// An input string is valid if:
// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// Every close bracket has a corresponding open bracket of the same type.

// Example 1:
// Input: s = "()"
// Output: true

// Example 2:
// Input: s = "()[]{}"
// Output: true

// Example 3:
// Input: s = "(]"
// Output: false

// Constraints:
// 1 <= s.length <= 104
// s consists of parentheses only '()[]{}'.

// Results:
// Runtime: 100 ms, faster than 67.57% of C# online submissions for Valid Parentheses.
// Memory Usage: 36.4 MB, less than 85.62% of C# online submissions for Valid Parentheses.
// -------------

public class Solution {
    public bool IsValid(string s) {
        List<char> ParenList = new List<char>();
        Dictionary<char,char> bracketList = new Dictionary<char,char>();
        bracketList.Add('(',')');
        bracketList.Add('{','}');
        bracketList.Add('[',']');
        
        // Iterate through string
        for (int i = 0; i < s.Length; i++)
        {
            // See if index of string contains open paren, if so add it to ParenList
            if (bracketList.ContainsKey(s[i]))
            {
                ParenList.Add(s[i]);
            }
            else // It's a closed paren
            {
                // If the paren list is empty, this is an unmatched closed paren
                if (ParenList.Count == 0)
                    return false;
                
                // If a matching open paren is found at the end of the list, remove it
                if (s[i] == bracketList[ParenList[ParenList.Count-1]])
                {
                    ParenList.RemoveAt(ParenList.Count-1);
                }
                else // This closed paren doesn't match the latest open paren
                {
                    return false;
                }
            }
        }
        
        // If anything is left in the list, it's a non-matched open paren
        if (ParenList.Count != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}