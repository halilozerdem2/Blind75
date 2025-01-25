/*
Given an integer array nums, return true if any value appears at least twice in the array, 
and return false if every element is distinct.


Example 1:
Input: nums = [1,2,3,1]
Output: true
Explanation:
The element 1 occurs at the indices 0 and 3.

Example 2:
Input: nums = [1,2,3,4]
Output: false
Explanation:
All elements are distinct.

Example 3:
Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true

Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109
*/

public class Solution
{
    public bool ContainsDuplicateBruteForce(int[] nums)//O(n^2)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                    return true;
            }
        }
        return false;
    }
    public bool ContainsDuplicateHash(int[]nums) //O (n)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!map.ContainsKey(nums[i]))
                map.Add(nums[i], i);
            else return true;

        }
        return false;
    }
    public bool ContainsDuplicateManipulation(int[]nums) //O(n log n)
    {
        Array.Sort(nums); 
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1]) 
                return true;
        }
        return false;
    }

    public static void QuickSort(int[] array, int left, int right)
    {
        if (left < right) 
        {
            int pivotIndex = Partition(array, left, right);
            QuickSort(array, left, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, right);
        }
    }

    private static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1; 

        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right);
        return i + 1;
    }

    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

}