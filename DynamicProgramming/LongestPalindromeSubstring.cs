using System;

namespace DynamicProgramming;

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
}

/*
  TEST
  string test = "babad";      
  var lng = new LongestPalindromeSubstring();
  lng.LongestPalindrome(test);

  EXPLANATION
  - One way of solving this problem would be by pointing in the middle, middle will always be palindrome
  - Yout could see a situation where you have two different middle characters therefore you would increase one left and/or 
    One right to see if the next character is a valid palindrome

*/