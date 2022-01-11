using System;

namespace Arrays;

public class MaxSubArray {
  public int MaxSub(int[] nums) {
    int total = nums[0];
    int current = nums[0];

    for(int i = 1; i < nums.Length; i++) {
      current = Math.Max(nums[i], current + nums[i]);
      total = Math.Max(current, total);
    }
    return total;
  }   
  
}

/*
  TESTING
  int[] test = {-2,1,-3,4,-1,2,1,-5,4};
  var max = new MaxSubArray();
  System.Console.WriteLine( max.MaxSub(test) );

  EXPLANATION
  - If you are trying to find the Max sub array you have to
    account for current running total sum of a range.
  - For the "current" variable in the for loop will be larger
    either by previous index value or previous value plus 
    current value.
  - For the total either the accumulated value is larger, 
    OR the current one is larger, therefore you would take current as total.
  - This can be seen as total = 5; current[i] = 7 => total = Max(5,7); 
    // which takes 7 now disregaring all previous values
*/

