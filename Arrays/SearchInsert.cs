using System;

namespace Arryas {
  /*
  var search = new SearchInsert();
  int res = search.InsertIndex(new int[] {1,3,5,6}, 2); // should return 2 index
  System.Console.WriteLine(res);
  */

  public class SearchInsert {
    // 1, 3, 5, 6 ===> insert 2 (in index 1);
    public int InsertIndex(int[] nums, int target) {
      int beg = 0;
      int end = nums.Length - 1;
      int mid = 0;
      while (beg <= end) {
        mid = (end + beg) / 2;
        if (nums[mid] == target) return mid;
        else if (target > nums[mid]) {
          beg = mid + 1;
        } else {
          end = mid - 1;
        }
      }

      return beg;
    }

  }

}