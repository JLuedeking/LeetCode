// #412. Fizz Buzz
// Given an integer n, return a string array answer (1-indexed) where:
// answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
// answer[i] == "Fizz" if i is divisible by 3.
// answer[i] == "Buzz" if i is divisible by 5.
// answer[i] == i (as a string) if none of the above conditions are true.

// Example 1:
// Input: n = 3
// Output: ["1","2","Fizz"]

// Example 2:
// Input: n = 5
// Output: ["1","2","Fizz","4","Buzz"]

// Example 3:
// Input: n = 15
// Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]

// Constraints:
// 1 <= n <= 104

// Results:
// Runtime: 155 ms, faster than 90.81% of C# online submissions for Fizz Buzz.
// Memory Usage: 47 MB, less than 76.49% of C# online submissions for Fizz Buzz.
// -------------

public class Solution {
    public IList<string> FizzBuzz(int n) {
        string[] fizzBuzzArray = new string[n];
        
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0) fizzBuzzArray[i-1] += "Fizz";
            
            if (i % 5 == 0) fizzBuzzArray[i-1] += "Buzz";
            
            if (i % 3 != 0 && i % 5 != 0) fizzBuzzArray[i-1] = i.ToString();
        }
        
        return fizzBuzzArray;
    }
}

// Additional Solution:
// I've been told that modulo is a slow opperation, so I wanted to try and use
// conditional statements based on what values would appear more often to see if
// it produced a better result. It ended up being basically the same: 163 ms / 46.9 MB

public class Solution {
    public IList<string> FizzBuzz(int n) {
        string[] fizzBuzzArray = new string[n];
        
        for (int i = 1; i <= n; i++)
        {
            if (i%3 != 0 && i%5 != 0)
            {
                fizzBuzzArray[i-1] = i.ToString();
            }
            else if (i%3 == 0 && i%5 == 0)
            {
                fizzBuzzArray[i-1] = "FizzBuzz";
            }
            else if (i%3 == 0)
            {
                fizzBuzzArray[i-1] = "Fizz";
            }
            else
            {
                fizzBuzzArray[i-1] = "Buzz";
            }
        }
        
        return fizzBuzzArray;
    }
}