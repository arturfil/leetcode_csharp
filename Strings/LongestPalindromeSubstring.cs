using System;

namespace Strings;

  public class LongestPalindromeSubstring {

  public string LongestPalindrome(string s) {
    if (string.IsNullOrEmpty(s)) return string.Empty;

    string res = "";
    int res_len = 0;

    for (int i = 0; i < s.Length; i++) {
      var p1 = ExpandAroundCenter(s, i, i);
      if (p1.Length > res_len) {
        res_len = p1.Length;
        res = p1;
      }

      var p2 = ExpandAroundCenter(s, i, i + 1);
      if (p2.Length > res_len) {
        res_len = p2.Length;
        res = p2;
      }
    }

    return res;
  }


  private string ExpandAroundCenter(string s, int r, int l) {
    while (r >= 0 && l < s.Length && s[r] == s[l]) {
      r--;
      l++;
    }
    return s.Substring(r + 1, l - r - 1);
  }

  //:::::::::::::::::SOLUTION 2::::::::::::::::::::::::::::://

  public string LongestPalindrome2(string s) {

    if (string.IsNullOrEmpty(s)) return string.Empty;

    int start = 0, end = 0;

    for (int i = 0; i < s.Length; i++) {
      int len1 = ExpandAroundCenter2(s, i, i);
      int len2 = ExpandAroundCenter2(s, i, i + 1);
      int len = Math.Max(len1, len2);

      if (len > end - start) {
        start = i - (len - 1) / 2;
        end = i + len / 2;
      }

    }

    return s.Substring(start, end - start + 1);
  }


  private int ExpandAroundCenter2(string s, int left, int right) {
    int L = left, R = right;
    while (L >= 0 && R < s.Length && s[L] == s[R]) {
      R++;
      L--;
    }
    return R - L - 1;
  }
  //:::::::::::::::::::::::::::::::::::::::::::::::::::::::://

}

/*
  // TEST //
  string test = "babad";      
  var lng = new LongestPalindromeSubstring();
  lng.LongestPalindrome(test);
*/

/*
 One way of solving this problem would be by pointing in the middle, middle will always be palindrome
 Yout could see a situation where you have two different middle characters therefore you would increase one left and/or 
 One right to see if the next character is a valid palindrome

 Technique required: sliding window? -> start with index 0, if the next one is the same, then it's a valid palindrome
 iterate to the next character so see if it matches index 0, if so, recurse inwards.

*/