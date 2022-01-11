namespace Strings;

public class ImplementStr {

  public int StrStr(string haystack, string needle) {
    // if haystack & needle == 0 => 0
    if (string.IsNullOrEmpty(needle)) return 0; 
    
    int len = needle.Length;
    //  if you are testing: hays = "hello" and needle = "ll"
    // then you iterate 5 - 2 => i < 3;
    // at some point if the string matches, any index "i" to substring at "len"
    // you return that i
    for(int i = 0; i < haystack.Length - len; i++) {
      if (haystack.Substring(i, len).Equals(needle)) return i;
    }
    return -1;
  }

}

/*
  TESTING
  var im = new ImplementStr();
  string haystack = "hello";
  string needle = "ll";
  System.Console.WriteLine( im.StrStr("", "") );
*/