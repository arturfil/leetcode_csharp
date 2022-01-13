namespace Arrays;

public class PlusOne {

  public int[] Plus(int[] digits) {
    for(int i = digits.Length-1; i >= 0; i--) {
      // if the current digit is 9, by adding one, you have to make current 0
      // and the next one has to be digits[i+1];
      if (digits[i] == 9) 
        digits[i] = 0;
      else {
        digits[i] += 1;
        return digits;
      }
    }
    // - this line will never reach if the number is 
    //   not compromised by all 9's
    // - this is just taking in account that all
    //   digits are 9 i.e. 9999 => 1, 0, 0, 0, 0;
    int[] added = new int[digits.Length+1];
    added[0] = 1;
    return added;
  }

}

/*
  TESTING
  var plus = new PlusOne();
  plus.Plus(new int[] {4,3,2,1});

  EXPLANATION
  - Here you could do some loops to manipulate the array into an int
  add one and convert it back into an array but it's easier if you just
  manipulate the individual numbers;
  - If you have 234, then you would only run the loop once and return [2,3,5]
  - BUT if you have 2,3,9, you would do [2,4,0] by running the loop twice and 
    setting the 9 to zero and the 3 to 4.
  - In the rare case that you have 99, you would set all the 9's to zeros [0,0]
    and then you would create a new array of length three = [0,0,0] and set new[0] = 1;
    hence returning [1,0,0] which would be the correct solution
*/