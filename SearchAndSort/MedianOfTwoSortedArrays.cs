using System;

namespace SearchAndSort;

public class MedianOfTwoSortedArrays {
    public double FindMedian(int[] nums1, int[] nums2) {
        if (nums2.Length < nums1.Length) {
            var temp = nums1; // essentially swap 1 for 2, making 1 smaller always
            nums1 = nums2;
            nums2 = temp;
        }

        int n = nums1.Length;
        int m = nums2.Length;

        int start = 0;
        int end = n;

        while (start <= end) {
            var blockN = start + (end - start) / 2;
            var blockM = (n + m + 1) / 2 - blockN;

            var block_NMin = blockN == 0 ? int.MinValue : nums1[blockN - 1];
            var block_NMax = blockN == n ? int.MaxValue : nums1[blockN];
            var block_MMin = blockM == 0 ? int.MinValue : nums2[blockM - 1];
            var block_MMax = blockM == m ? int.MaxValue : nums2[blockM];

            if (block_NMin <= block_MMax && block_MMin <= block_NMax) {
                if ((m + n) % 2 == 1) {
                    return Math.Max(block_NMin, block_MMin);
                } else {
                    return  (Math.Max(block_NMin, block_MMin) + Math.Min(block_MMax, block_NMax) / 2.0);
                }

            } else if (block_NMin > block_MMax) {
                end = blockN - 1;
            } else {
                start = blockN + 1;
            }
        }

        throw new Exception();

    }
}