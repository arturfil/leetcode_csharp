namespace Graphs;

public class NumberOfLaserBeams {
    public int NumberOfBeams(string[] bank) {
        int total = 0;
        int current = 0;
        for (int i = 0; i < bank.Length; i++) {            // accounts for rows only
            int temp = 0;
            for (int j = 0; j < bank[i].Length; j++) { // accounts for colunmns with single row
                if (bank[i][j] == '1') temp++;
            }
            if (temp > 0) {
                total += current * temp;
                current = temp; // will take in account that first row doesn't add up to anything
            }
        }
        return total;
    }
}

/*
    TESTING
    string[] lasers = new string[] {"011001","000000","010100","001000"}; // 8
    string[] lasers2 = new string[] {"0001","010100","001000"}; // 4

    var beams = new NumberOfLaserBeams();
    beams.NumberOfBeams(lasers);

    EXPLANATION
    - You are trying to add the number or beam rays that connect with each "connector" 
    - follow up the question in leetcode to understand.
    - If one row is empty then you ignore it and go to the next non-empty
    - You want to multiply the number of "connectors" in a row with the consecutive row of connectors.
      i.e. 1st row -> 2 connectors, 2nd row -> 1 connector, 3rd row -> 3 connects ==> total is _(2*1) + (1*3) = 5;
    - so in the code you have to first check the number of '1' connectors on.
      for each row you have to make sure that the total is equal to the product of the two consecutive rows.
    - this will be emulated by prev and temp, current will hold a global (previous row value) and temp the current.
    This should give you the total, as expected
*/

// For printing
// for (int i = 0; i < bank.Length; i++) {            // accounts for rows only
//     for (int j = 0; j < bank[i].Length - 1; j++) {  // accounts for colunmns with single row
//         System.Console.Write(bank[i][j]);
//     }
//     System.Console.WriteLine();
// }