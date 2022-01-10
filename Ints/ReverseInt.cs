namespace Ints;

public class ReverseInt {

  public int Reverse(int x) {
    int rev_int = 0;
    for (int pop = 0, push = 0; x != 0; x/= 10) {
      pop = x % 10;
      push = rev_int * 10 + pop;
      if ((push - pop)/10 != rev_int) return 0;
      rev_int = push;
    }
    return rev_int;
  }
}

