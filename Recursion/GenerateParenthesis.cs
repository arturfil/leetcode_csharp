using System.Collections.Generic;

namespace Recursion;

public class GenerateParenthesis {
    List<string> result = new List<string>();
    int maxLen;
    

    public IList<string> Generate(int n) {
        maxLen = n;
        GenerateAndCheck("", 0, 0);
        return result;
    }

    private void GenerateAndCheck(string str, int open, int close) {
        if (open == close && open == maxLen) {
            result.Add(str);
            return;
        }
        if (open < maxLen)
            GenerateAndCheck(str + "(", open + 1, close);
        if (close < open)
            GenerateAndCheck(str + ")", open, close + 1);
    }
}