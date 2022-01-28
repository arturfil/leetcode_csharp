using System.Collections.Generic;

namespace Arrays;

public class FirstUniqueCharacter {
    public int FirstUnique(string s) {
        Dictionary<char, int> word = new Dictionary<char, int>();
        foreach(char ch in s) {
            if (word.ContainsKey(ch)) {
                word[ch]++;
            } else {
                word.Add(ch, 0);
            }
        }
        for(int i = 0; i < s.Length; i++) {
            if (word[s[i]] == 0) return i;
        }
        return -1;
    }

}