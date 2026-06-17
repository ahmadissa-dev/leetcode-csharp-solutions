/*
Problem:
Given an integer array nums, return the element that appears more than n / 2 times.
A majority element is guaranteed to exist.

Approach:
Use the Boyer-Moore Voting Algorithm.
Track a candidate and a count.
Matching values increase the count, while different values decrease it.
When the count reaches zero, select the current element as the new candidate.
Since the majority element appears more than all other elements combined, it remains the final candidate.

Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int candidate = nums[0];
        int count = 1;

        for (int currentIndex = 1; currentIndex < nums.Length; currentIndex++)
        {
            if (count == 0)
            {
                candidate = nums[currentIndex];
            }

            count += candidate == nums[currentIndex] ? 1 : -1;
        }

        return candidate;
    }
}
