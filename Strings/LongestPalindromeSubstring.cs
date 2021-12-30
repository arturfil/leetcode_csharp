namespace Strings {

  public class LongestPalindromeSubstring {

    // Example : "babad";
    public string LongestPalindrome(string s) {
      // int beg = 0;
      int j = s.Length;
      for(int i = 0; i < s.Length || j > 0; i++, j--) {
        System.Console.WriteLine($"first index: {s[i]}, last index {s[j]}");
      }


      /*
        One way of solving this problem would be by pointing in the middle, middle will always be palindrome
        Yout could see a situation where you have two different middle characters therefore you would increase one left and/or 
        One right to see if the next character is a valid palindrome

        Technique required: sliding window? -> start with index 0, if the next one is the same, then it's a valid palindrome
        iterate to the next character so see if it matches index 0, if so, recurse inwards.

      */

      return "this";
    }

  }

}

/*
  // TEST //
  string test = "babad";      
  var lng = new LongestPalindromeSubstring();
  lng.LongestPalindrome(test);
*/