/*
 * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
 * You can return the answer in any order.

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
 

Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?

*/

public class TwoSum
{
    public int[] FindMatchingPair(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
                return new int[] { map[complement], i };
            

            if (!map.ContainsKey(nums[i]))
                map[nums[i]] = i;
        }

        throw new ArgumentException("No solution found");
    }
}


public class Program
{
    public static void Main()
    {
        TwoSum solution = new TwoSum();

        // Test case 1
        int[] nums1 = { 2, 7, 11, 15 };
        int target1 = 9;
        Console.WriteLine(string.Join(", ", solution.FindMatchingPair(nums1, target1))); // Output: [0, 1]

        // Test case 2
        int[] nums2 = { 3, 2, 4 };
        int target2 = 6;
        Console.WriteLine(string.Join(", ", solution.FindMatchingPair(nums2, target2))); // Output: [1, 2]

        // Test case 3
        int[] nums3 = { 3, 3 };
        int target3 = 6;
        Console.WriteLine(string.Join(", ", solution.FindMatchingPair(nums3, target3))); // Output: [0, 1]
    }
}
