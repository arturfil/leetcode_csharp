using Stacks;
using Strings;
using TwoPointers;

namespace review_leetcode;

class Program {

  static void Main(string[] args) {

    ValidParenthesis val = new ValidParenthesis();
    bool res = val.IsValid("(()){}");
    System.Console.WriteLine(res);
  }

}

