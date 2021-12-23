using System;

namespace Arrays {

  public class MaxSubArray {

    public int ReturnMax(int[] arr) {
      int total = arr[0];
      int current = arr[0];

      for(int i = 1; i < arr.Length; i++) {
        current = Math.Max(arr[i], current + arr[i]);
        total = Math.Max(current, total);
      }

      return total;
    }

  }

  /**
    int[] test = {-2,1,-3,4,-1,2,1,-5,4};
    MaxSubArray sub = new MaxSubArray();
    int result = sub.ReturnMax(test);
    System.Console.WriteLine(result);
  */

}