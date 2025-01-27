/*
Given an integer array nums, find the 
subarray
with the largest sum, and return its sum.

Example 1:
Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: The subarray [4,-1,2,1] has the largest sum 6.

Example 2:
Input: nums = [1]
Output: 1
Explanation: The subarray [1] has the largest sum 1.

Example 3:
Input: nums = [5,4,-1,7,8]
Output: 23
Explanation: The subarray [5,4,-1,7,8] has the largest sum 23.
 

Constraints:
1 <= nums.length <= 105
-104 <= nums[i] <= 104
 
Follow up: If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach,
which is more subtle.
*/

public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = nums[0];
        int currentSum = 0; 

        foreach (int num in nums)
        {
            currentSum += num;       
            maxSum = Math.Max(maxSum, currentSum);
            if (currentSum < 0)
                currentSum = 0; 
        }

        return maxSum;
    }


    static int MaxCrossingSum(int[] nums, int left, int mid, int right)
    {
        int leftSum = int.MinValue, rightSum = int.MinValue;
        int currentSum = 0;

        // Sol taraftaki maksimum toplamı bul
        for (int i = mid; i >= left; i--)
        {
            currentSum += nums[i];
            leftSum = Math.Max(leftSum, currentSum);
        }

        currentSum = 0;
        
        // Sağ taraftaki maksimum toplamı bul
        for (int i = mid + 1; i <= right; i++)
        {
            currentSum += nums[i];
            rightSum = Math.Max(rightSum, currentSum);
        }

        // Sol ve sağ toplamların birleşimi
        return leftSum + rightSum;
    }

    static int MaxSubArrayDivideAndConquer(int[] nums, int left, int right)
    {
        if (left == right)
            return nums[left];

        int mid = (left + right) / 2;

        // Sol, sağ ve çapraz alt dizilerin maksimum toplamlarını bul
        int leftSum = MaxSubArrayDivideAndConquer(nums, left, mid);
        int rightSum = MaxSubArrayDivideAndConquer(nums, mid + 1, right);
        int crossSum = MaxCrossingSum(nums, left, mid, right);

        // En büyük toplamı döndür
        return Math.Max(Math.Max(leftSum, rightSum), crossSum);
    }

    static int MaxSubArray(int[] nums)
    {
        return MaxSubArrayDivideAndConquer(nums, 0, nums.Length - 1);
    }

}