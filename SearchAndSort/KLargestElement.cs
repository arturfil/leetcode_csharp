using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchAndSort;

public class KLargestElement {
  public int FindKthLargest(int[] nums, int k) {
    SortedDictionary<int, int> minHeap = new SortedDictionary<int, int>();
    int heapSize = 0;

    foreach(int num in nums) {
      if (minHeap.ContainsKey(num))
        minHeap[num]++;
      else
        minHeap.Add(num, 1);
      heapSize++;

      if (heapSize > k) {
        var min = minHeap.First();
        if (min.Value == 1)
          minHeap.Remove(min.Key);
        else
          minHeap[min.Key]--;
        heapSize--;
      }
    }
    return minHeap.First().Key;
  }
}

/*
  TESTING
  int[] test = new int[] {3,2,1,5,6,4}; 
  int k = 2;
  var largest = new KLargestElement();
  largest.FindKthLargest(test, k);

  EXPLANATION
  - 
*/