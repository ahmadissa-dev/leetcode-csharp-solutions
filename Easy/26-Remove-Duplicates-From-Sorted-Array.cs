/*
Problem:
Given an integer array nums sorted in ascending order, 
remove the duplicates in-place so each unique element appears only once.
The relative order of the elements should be kept the same.

Approach:
Use two pointers.
lastUniqueIndex tracks the position of the last unique element.
currentIndex scans the array.
When a new unique value is found, place it after the last unique element.

Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int lastUniqueIndex = 0;
        int currentIndex = 1;

        while (currentIndex < nums.Length)
        {
            if (nums[currentIndex] != nums[lastUniqueIndex])
            {
                nums[++lastUniqueIndex] = nums[currentIndex];
            }

            currentIndex++;
        }

        return lastUniqueIndex + 1;
    }
}