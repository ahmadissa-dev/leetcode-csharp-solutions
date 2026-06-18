/*
Problem:
Given an integer array nums, rotate it to the right by k steps.

Approach:
Reverse the entire array.
Then reverse the first k elements and the remaining elements separately.
This places the last k elements at the beginning while preserving their correct order.
Reduce k using modulo to handle values larger than the array length.

Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int length = nums.Length;
        k %= length; // Reduce k to the appropriate number of rotations

        ReverseRange(nums, 0, length - 1);
        ReverseRange(nums, 0, k - 1);
        ReverseRange(nums, k, length - 1);
    }

    private static void ReverseRange(int[] nums, int leftIndex, int rightIndex)
    {
        while (leftIndex < rightIndex)
        {
            int temporaryValue = nums[leftIndex];
            nums[leftIndex] = nums[rightIndex];
            nums[rightIndex] = temporaryValue;

            leftIndex++;
            rightIndex--;
        }
    }
}