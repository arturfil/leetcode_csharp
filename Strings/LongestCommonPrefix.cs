using System.Collections.Generic;

namespace Strings;

public class LongestCommonPrefix {

  public string CommonStr(string[] strs) {
    string common = "";
    for (int i = 0; i < strs[0].Length; i++) { // for each word
      char current = strs[0][i]; // current char
      for (int j = 1; j < strs.Length; j++) { // for each char in the word
        if (i > strs[j].Length - 1) return common; // if there is a shorter word
        if (strs[j][i] != current) return common; // if all characters across all words don't match
      }
      common += current; // add the current character to the common prefix string
    }
    return common;
  }

}



/*
  string[] words = {"flower", "flow", "flight"};
  var lg = new LongestCommonPrefix();
  lg.CommonStr(words);
*/