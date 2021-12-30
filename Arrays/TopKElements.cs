using System.Collections.Generic;
using System.Linq;

namespace Arrays {
  public class TopKElements {

    public int[] TopKFrequent(int[] nums, int k) {
      Dictionary<int, int> elements = new Dictionary<int, int>();
      for (int i = 0; i < nums.Length; i++) {
        if (elements.ContainsKey(nums[i]))
          elements[nums[i]]++;
        else
          elements.Add(nums[i], 1);
      }

      return elements.OrderByDescending(x => x.Value)
          .Select(x => x.Key).Take(k).ToList<int>().ToArray();
    }

  }

  /*
      var top = new TopKElements();
      top.TopKFrequent(new int[] {1,1,1,2,2,3}, 2);
  */
}