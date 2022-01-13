namespace Numbers;

public class SquareRoot {

  public int MySqrt(int x) {
    // square root by substraction method;
    int i = 1;
    int rounds = 0;
    // 16
    while(x > 0) {
      x -= i;
      i += 2;
      if (x > 0) rounds++;
    }
    return rounds;
  }

}

/*
  Test
  var sqr = new SquareRoot();
  sqr.MySqrt(8);

  Explanation
  To get the square root you need to make sure that 
  you substract every odd number until it reaches zero 
  or before it becomes negateive
  Example with 16:
  ----------------
  16 - 1 => 15
  15 - 3 => 12
  12 - 5 => 7
  7 - 7 => 0;
  ROUNDS = 4; => 4 is the square root

  Example with 8:
  ----------------
  8 - 1 => 7;
  7 - 3 => 4;
  4 - 5 => x
  ROUNDS = 2, the actual square root is 2.82 
  but the problem doesn't care for the decimals 
  So as long as you account before x becomes negative
  and so ANS => 2;
*/