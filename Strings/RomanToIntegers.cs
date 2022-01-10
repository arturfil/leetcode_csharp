using System.Collections.Generic;

namespace Strings;

public class RomanToIntegers {

  Dictionary<char, int> romans = new Dictionary<char, int>() {
    {'I', 1},
    {'V', 5},
    {'X', 10},
    {'L', 50},
    {'C', 100},
    {'D', 500},
    {'M', 1000},
  };

  public int RomanToInt(string s) {
    int total = 0;
    int previous = 0;
    // IX => 9;
    for(int i = s.Length-1; i >= 0; i--) {
      int current = romans.GetValueOrDefault(s[i]);
      total += previous > current ? -current : current;
      previous = current;
    }
    System.Console.WriteLine(total);
    return total;
  }

}

/*
  TESTING
  var rome = new RomanToIntegers();
  rome.RomanToInt("IV"); // this is meant to be a 4;

  EXPLANATION:
  - ROMAN NUMBERS from 1 to 1000 have those avaialable symbols.
  - IF you go from left to right, you know that a 4 is IV even though that's a 5 symbol 
    & a 1 symbol, because normally every number from left to right has to be smaller i.e. 58 LVIII
  - IF for some reason a number to the right is BIGGER, means the current is substracted 
    i.e 24 => XXIV where I is substracted form 5
  - In this algorithm I did exactly that but instead of going from left to right I went right to left
    that way I  would avoid looping problems, I did it initially from left to right but is more 
    code and less conscise;
*/
