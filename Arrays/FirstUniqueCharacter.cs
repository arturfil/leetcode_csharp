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

/*
    TESTING
    var first = new FirstUniqueCharacter();
    System.Console.WriteLine( first.FirstUnique("casacbri"));

    EXPLANATION
    - You add all the characters to the dictionary and the number of repetitions
    - If they have '0' repetitions, means they are unique
    - After adding all, run a for loop to see if the current, first character
    has 0 repetitions, if so, return it
*/