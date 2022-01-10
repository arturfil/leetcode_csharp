using System;
using System.Collections.Generic;

namespace SlidingWindow;

public class LongestSubstring {

  public int LengthOfLongestSubstring(string s) {

    int res = 0; // this is the lenght of the longest substring
    int start = 0; // starting point of valid substring;
    Dictionary<char, int> seen = new Dictionary<char, int>();
    for (int i = 0; i < s.Length; i++) {
      if (seen.ContainsKey(s[i])) {
        // start of string will equal Max of => [start prev val or seen[s[i]] + 1]
        // this is because you could have a character that already appeared previously in the string index = 2;
        // and start could be index 4
        start = Math.Max(start, seen[s[i]] + 1);
      } else {
        seen.Add(s[i], i);
      }
      res = Math.Max(res, i - start + 1);
    }
    return res;
  }

}

  /*
  string test = "abcabcbb";
  var longest = new LongestSubstring();
  longest.LengthOfLongestSubstring(test);
  */

