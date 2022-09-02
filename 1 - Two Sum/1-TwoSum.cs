
// #1. Two Sum
// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.

// Example 1:
// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]

// Example 2:
// Input: nums = [3,2,4], target = 6
// Output: [1,2]

// Example 3:
// Input: nums = [3,3], target = 6
// Output: [0,1]

//Constraints:
// 2 <= nums.length <= 10^4
// -10^9 <= nums[i] <= 10^9
// -10^9 <= target <= 10^9
// Only one valid answer exists.

// Results:
// Runtime: 207 ms, faster than 72.31% of C# online submissions for Two Sum.
// Memory Usage: 42.9 MB, less than 62.26% of C# online submissions for Two Sum
// -------------

public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        // Iterate through array of nums
        for (int i=0; i<nums.Length; i++)
        {
            // Check the sum of that index against all subsequate indexes
            for (int j=i+1; j<nums.Length; j++)
            {
                // If any two indexes have a sum of the target, return the index positions
                if (nums[i] + nums[j] == target)
                {
                    return new int[]{i,j};;
                }
            }
        }
        
        // Otherwise, none of the indexes equal the target, return null
        return null;
    }
}