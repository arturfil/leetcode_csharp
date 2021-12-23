using System;
using System.Collections.Generic;
using Utils;

namespace Arrays {

  public class TwoSum {

    public int[] GetSum(int[] nums, int target) {
      int[] res = {0, 0};
      for (int i = 0; i < nums.Length; i++) {
        for (int j = i+1; j < nums.Length; j++) {
          if (nums[i] + nums[j] == target) {
            return new int[] {i, j};
          }
        }
      }
      var u = new ArrayUtils();
      u.PrintArray(res);
      return res;
    }

    public int[] GetSum2(int[] nums, int target) {
      // here I have to create a hash table and make one pass but I don't know 
      // exactly what to do 
      Dictionary<int, int> hashmap = new Dictionary<int, int>();
      for (int i = 0; i < nums.Length; i++) {
        int complement = target - nums[i];
        if (hashmap.ContainsKey(complement))
          return new int[] {hashmap[complement], i};
        hashmap.Add(nums[i], i);
      }
      throw new Exception("Error, such solution doesn't exist");
    }

  }

}