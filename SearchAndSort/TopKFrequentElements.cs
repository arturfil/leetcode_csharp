using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchAndSort;

public class TopKFrequentElements {
  public int[] TopKFrequent(int[] nums, int k) {
    Dictionary<int, int> freq = new Dictionary<int, int>();
    List<int> result = new List<int>();
    int max = 0;

    for(int i = 0; i < nums.Length; i++) {
      if (!freq.ContainsKey(nums[i])) freq.Add(nums[i], 1);
      else freq[nums[i]]++;
      if (freq[nums[i]] > max) max = freq[nums[i]];
    }

    Dictionary<int, List<int>> buckets = new Dictionary<int, List<int>>(max);
    for (int i = 1; i <= max; i++) {
      buckets.Add(i, new List<int>());
    }

    foreach(int key in freq.Keys) {
      buckets[freq[key]].Add(key);
    }

    int last = max;

    while (k > 0 && last > 0) {
      int current = 0;
      if (buckets[last].Count > 0) {
        current = Math.Min(k, buckets[last].Count);
        for(int i = 0; i < current; i++) {
          result.Add(buckets[last][i]);
        }
      }
      last--;
      k -= current;
    }
    return result.ToArray();
  }
  
}

/*
  TESTING
  var top = new TopKFrequentElements();
  top.TopKFrequent(new int[] {1,1,1,2,3,3,3,3}, 2); // 1 & 3;
  
  EXPLANATION
  - Essentially what you want to do is to get the 'k' numbers with must frequency
  - So if they are asking you for the top 3 elements, you check via the dictionary
    which elements are the most repeated, for that, you sort them in desc order and 
    then just return the first 'k' index
*/