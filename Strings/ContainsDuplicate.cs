using System.Collections.Generic;

namespace Strings {

  public class ContainsDuplicate {

    public bool CheckDuplicate(int[] nums) {

      Dictionary<int, int> seen = new Dictionary<int, int>();
      foreach (int num in nums) {
        if (seen.ContainsKey(num)) return true; // means there's a duplicate, return true
        else seen.Add(num, 1); // else add the key and value = 1
      }
      // if "if" statement is never reached means there is no duplicate.
      // no need to sort the array first
      return false;

    }

  }

}

/*
  TESTING -> put this code on the Program.cs file
  int[] nums = {1,2,3,4}
  ContainsDuplicate dup = new ContainsDuplicate();
  dup.CheckDuplicate(nums);
*/