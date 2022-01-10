using System;
using System.Collections.Generic;
using Utils;

namespace Arrays;

public class TwoSum {

  public int[] Sum(int[] nums, int target) {
    Dictionary<int, int> seen = new Dictionary<int, int>();
    for(int i = 0; i < nums.Length; i++) {
      // if there is a such target where we have seen it's opposite we know where the opposites index is at.
      if (seen.ContainsKey(nums[i])) {
        return new int[] { seen.GetValueOrDefault(nums[i]), i };
      }
      // we add the opposite number and the index of the current
      seen.TryAdd(target - nums[i], i);
    }
    return new int[] { 0, 0 };
  }

}

/*
  TESTING
  TwoSum sum = new TwoSum();
  int[] test = new int[] {1,1,1,1,1,1,1,1,1,1,1,1,1,7,1,1,1,1,1,4};
  int[] result =  sum.Sum(test, 11);
  foreach(int num in result) System.Console.WriteLine(num);
*/