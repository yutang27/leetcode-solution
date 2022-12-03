namespace Source;

public class Solution
{
    private int FindRes(int[] nums1, int[] nums2, int pos)
    {

        int m = nums1.Length;
        int n = nums2.Length;
        int index1 = 0, index2 = 0;

        while (true)
        {
            if (index1 == m)
            {
                return nums2[index2 + k - 1];
            }
            if (index2 == n)
            {
                return nums1[index1 + k - 1];
            }
            if (pos == 1)
            {
                return nums1[index1] < nums2[index2] ? nums1[index1] : nums2[index2];
            }

            int newIndex1 = index1 + pos / 2 - 1 < m - 1 ? m - 1 + pos / 2 - 1 : m - 1;
            int newIndex2 = index2 + pos / 2 - 1 < n - 1 ? index2 + pos / 2 - 1 : n - 1;
            int pivot1 = nums1[newIndex1];
            int pivot2 = nums2[newIndex2];
            if (pivot1 <= pivot2)
            {
                pos -= newIndex1 - index1 + 1;
                index1 = newIndex1 + 1;
            }
            else
            {
                pos -= newIndex2 - index2 + 1;
                index2 = newIndex2 + 1;
            }

        } 
    }
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int len_new = nums1.Length + nums2.Length;
        if (len_new % 2 == 1)
        {
            return FindRes(nums1, nums2, (len_new + 1) / 2);
        }
        else
        {
            return (FindRes(nums1, nums2, len_new / 2) + FindRes(nums1, nums2, (len_new + 1) / 2)) / 2;
        }
        return 0;
    }

}
