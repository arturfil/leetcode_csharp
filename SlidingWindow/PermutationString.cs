using System.Collections.Generic;

namespace SlidingWindow;

public class PermutationString {

  public bool CheckInclusion(string s1, string s2) {

    Dictionary<char, int> chars = new Dictionary<char, int>();

    // for every character we have to check whether 
    // the next character is also withing s1

    // Here we are putting every single...
    // non-repeating character in the dictionary
    for(int i = 0; i < s2.Length; i++) {
      if (!chars.ContainsKey(s2[i])) {
        chars.Add(s2[i], 1);
      }
    }
    
    for(int i = 0; i < s2.Length; i++) {
      if (!chars.ContainsKey(s1[i])) return false;
    }

    return true;
  }

}

