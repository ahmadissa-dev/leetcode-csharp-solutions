/*
Problem:
Remove all occurrences of val from nums in-place and return the number of remaining valid elements.

Approach:
Use two pointers.
If the current element equals val, replace it with the last valid element and shrink the valid range.
Otherwise, move forward.
Order does not matter.

Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int currentIndex = 0;
        int lastValidIndex = nums.Length - 1;

        while (currentIndex <= lastValidIndex)
        {
            if (nums[currentIndex] == val)
            {
                nums[currentIndex] = nums[lastValidIndex--];
                continue;
            }

            currentIndex++;
        }

        return lastValidIndex + 1;
    }
}