using System;
using System.Linq;

namespace SearchAndSort;

public class KLargestElement {

  public int FindKthLargest(int[] nums, int k) {
    nums = nums.OrderByDescending(c => c).ToArray();
    foreach(int num in nums) System.Console.Write($"{num},");
    return nums[k-1];
  }

}