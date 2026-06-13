/*
Problem:
Given a sorted integer array nums, remove duplicates in-place so each value appears at most twice.

Approach:
Use two pointers.
writeIndex marks the next valid position, while currentIndex scans the array.
A value is written only if it is different from the element two positions before writeIndex.
Math.Min initializes writeIndex safely for arrays with fewer than two elements.

Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int writeIndex = Math.Min(2, nums.Length);

        for (int currentIndex = writeIndex; currentIndex < nums.Length; currentIndex++)
        {
            if (nums[currentIndex] != nums[writeIndex - 2])
            {
                nums[writeIndex++] = nums[currentIndex];
            }
        }

        return writeIndex;
    }
}