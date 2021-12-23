namespace Strings {

  public class NeedleHayStack {
    // think of substing as a type of slice
    public int FindIndex(string haystack, string needle) {
      if (string.IsNullOrEmpty(needle)) return 0;

      int needleLength = needle.Length;
      for (int i = 0; i <= haystack.Length - needleLength; i++) {
        if (haystack.Substring(i, needleLength) == needle) 
          return i;
      }
      return -1;
    }

  }

}