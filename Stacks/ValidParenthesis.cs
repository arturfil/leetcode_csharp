using System.Collections.Generic;

namespace Stacks;
  

public class ValidParenthesis {

  // example ()[]{} => valid
  public bool IsValid(string s) {
  Stack<char> seen = new Stack<char>();
    for(int i = 0; i < s.Length; i++) {
      if (s[i] == '(') seen.Push(')');
      if (s[i] == '{') seen.Push('}');
      if (s[i] == '[') seen.Push(']');
      else if (seen.Count == 0 || s[i] != seen.Pop()) return false;
    }
    return seen.Count == 0;
  }

}
  
/*
  TESTING
  ValidParenthesis val = new ValidParenthesis();
  bool res = val.IsValid("(()){}");
  System.Console.WriteLine(res);

  EXPLAINING
  - What this does is that it will never push a oppening character i.e. (, {, [
  - If we encounter those we insert the coutner parts ), }, ]
  - that way if we se repeated } means there was an already { accounter for and hence we pop it
  - and in the else if we account for scenarios where either we pop because they are equal or 
    if we are receiving a closing char, then it wont be a valid string or parenthesis insertion
*/