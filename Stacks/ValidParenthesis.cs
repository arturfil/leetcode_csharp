using System.Collections.Generic;

namespace Stacks;
  
public class ValidParenthesis {

  public bool IsValid(string s) {
    Stack<char> stk = new Stack<char>();
    foreach (char c in s) {
      if (c == '(') stk.Push(')');
      else if (c == '{') stk.Push('}');
      else if (c == '[') stk.Push(']');
      else if (stk.Count == 0 || c != stk.Pop()) return false;
    }

    return stk.Count == 0;
  }

}
  