
// #13. Roman To Integer
// Given a roman numeral, convert it to an integer.

// Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
// Symbol       Value
// I             1
// V             5
// X             10
// L             50
// C             100
// D             500
// M             1000

// Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
// I can be placed before V (5) and X (10) to make 4 and 9. 
// X can be placed before L (50) and C (100) to make 40 and 90. 
// C can be placed before D (500) and M (1000) to make 400 and 900.
// Given a roman numeral, convert it to an integer.

// Example 1:
// Input: s = "III"
// Output: 3

// Example 2:
// Input: s = "LVIII"
// Output: 58

// Example 3:
// Input: s = "MCMXCIV"
// Output: 1994

// Constraints:
// 1 <= s.length <= 15
// s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
// It is guaranteed that s is a valid roman numeral in the range [1, 3999].

// Results:
// Runtime: 103 ms, faster than 63.06% of C# online submissions for Roman to Integer.
// Memory Usage: 36.8 MB, less than 63.27% of C# online submissions for Roman to Integer.
// -------------

public class Solution {
    public int RomanToInt(string s) {

        int sumOfLetters = 0;
        
        // Create dictionary list of roman letters and their int values
        Dictionary<char,int> LetterValues = new Dictionary<char,int>();
        LetterValues.Add('M',1000);
        LetterValues.Add('D',500);
        LetterValues.Add('C',100);
        LetterValues.Add('L',50);
        LetterValues.Add('X',10);
        LetterValues.Add('V',5);
        LetterValues.Add('I',1);
        
        // Iterate through the string
        for (int i = 0; i < s.Length; i++)
        {
            // If it's the last index of the string, add it to sumOfLetters
            if (i == s.Length-1)
            {
                sumOfLetters += LetterValues[s[i]];
            }
            // If the value of the current index is greater than the next index, add to sumOfLetters
            else if (LetterValues[s[i]] >= LetterValues[s[i+1]])
            {
                sumOfLetters += (int)LetterValues[s[i]];
            }
            // Otherwise, it's less, and should be subtracted from sumOfLetters
            else
            {
                sumOfLetters -= (int)LetterValues[s[i]];
            }
        }
        
        return sumOfLetters;
    }
}