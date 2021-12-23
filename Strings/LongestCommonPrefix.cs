namespace Strings {

  public class LongestCommonPrefix {

    public string CommonStr(string[] strs) {
      string common = "";
      for (int i = 0; i < strs[0].Length; i++) {
        char current = strs[0][i];
        for (int j = 1; j < strs.Length; j++) {
          if (i > strs[j].Length - 1) return common;
          if (strs[j][i] != current) return common;
        }
        common += current;
      }
      return common;
    }

  }

}