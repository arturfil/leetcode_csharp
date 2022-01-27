using System.Collections.Generic;
using System.Linq;

namespace SearchAndSort;

public class TopKFrequentElements {
  public int[] TopKFrequent(int[] nums, int k) {
    Dictionary<int, int> freq = new Dictionary<int, int>();
    foreach(int num in nums) {
      if (freq.ContainsKey(num)) freq[num]++;
      else freq.Add(num, 1);
    }

    foreach(KeyValuePair<int, int> kvp in freq) {
      System.Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
    }

    return new int[] {1};
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