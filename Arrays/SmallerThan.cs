using System;
using System.Collections.Generic;
using Utils;

namespace Arrays {

  public class SmallerThan {

    public int[] GetSmaller(int[] nums) {
      int[] res = new int[nums.Length];
      // int[] sorted = nums;
      int[] sorted = (int[]) nums.Clone();
      Array.Sort(sorted);
      Dictionary<int, int> tab = new Dictionary<int, int>();

      for(int i = 0; i < sorted.Length; i++) {
        if(!tab.ContainsKey(sorted[i]))
          tab.Add(sorted[i], i);
      }

      for(int i = 0; i < nums.Length; i++) {
        res[i] = tab[nums[i]];
      }

      var arrPrinter = new ArrayUtils();
      arrPrinter.PrintArray(nums);
      arrPrinter.PrintArray(sorted);
      arrPrinter.PrintArray(res);

      return res;
    }

    public int[] GetSmaller2(int[] nums) {
      int[] sorted = (int[]) nums.Clone();
      
      for(int i = 0; i < nums.Length; i++) 
        nums[i] = Array.IndexOf(sorted, nums[i]);

      return nums;
    }

  }

}