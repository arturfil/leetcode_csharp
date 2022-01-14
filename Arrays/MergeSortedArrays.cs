using System.Collections.Generic;
using System.Linq;

namespace Arrays;

public class MergeSortedArrays {

  public void Merge(int[] nums1, int m, int[] nums2, int n) {
    int p1 = m-1;
    int p2 = n-1;

    for (int i = m + n - 1; i >= 0; i--) {
      if (p2 < 0) break; // in the case that the last digit is zero
      if (p1 >= 0 && nums1[p1] > nums2[p2]) 
        nums1[i] = nums1[p1--];
      else
        nums1[i] = nums2[p2--];
    }

  }

}

/*
  TESTING
  var merge = new MergeSortedArrays();
  int[] nums1 = new int[] {1,2,3,0,0,0};
  int[] nums2 = new int[] {2,5,6};
  int m = 3;
  int n = 3;
  merge.Merge(nums1, m, nums2, n);

  ASSUMPTIONS
  nums1 already has a space of m+n; 
  i.e.
  nums1 = [1,2,3,0,0,0];
  nums2 = [2,5,6];

  EXPLANATION
  - You create two pointers, pointing to the last index 
    of each array respectively
  - if the the number at  p1 is bigger or equal to zero AND
    bigger than p2 THEN place p1 all the way to the right
  - opposite to this, place p2 all the way to the right.
  - repeat this process and you should get a ordered merged
    array in asc. order.

*/