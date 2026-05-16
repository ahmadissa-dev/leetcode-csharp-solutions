
/*
Problem:
Merge two sorted arrays into nums1, which has enough space for m + n elements.
m is the number of valid elements in nums1, and n is the number of elements in nums2.

Approach:
Use three pointers from the end to avoid overwriting values in nums1.
At each step, place the larger current value at the last available position in nums1.
Stop when all values from nums2 are merged.

Time Complexity: O(m + n)
Space Complexity: O(1)
*/


public class Solution
{

    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int nums1Index = m - 1;        // Pointer to the last valid element in nums1
        int nums2Index = n - 1;        // Pointer to the last element in nums2
        int insertIndex = m + n - 1;   // Pointer to the last position in nums1

        while (nums2Index >= 0)
        {

            if (nums1Index >= 0 && nums1[nums1Index] > nums2[nums2Index])
            {
                nums1[insertIndex--] = nums1[nums1Index--];
            }
            else
            {
                nums1[insertIndex--] = nums2[nums2Index--];
            }
        }
    }
}