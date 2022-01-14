using Arrays;

namespace review_leetcode;

class Program {

  static void Main(string[] args) {

    var merge = new MergeSortedArrays();
    int[] nums1 = new int[] {1,2,3,0,0,0};
    int[] nums2 = new int[] {2,5,6};
    int m = 3;
    int n = 3;
    merge.Merge(nums1, m, nums2, n);
  
  }

}

