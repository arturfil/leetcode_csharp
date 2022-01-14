namespace DynamicProgramming;

public class ClimbStairs {

  public int Climb(int n) {
    if (n <= 2) return n;

    int[] res = new int[n+1];
    res [1] = 1;
    res[2] = 2;
    for(int i = 3; i <= n; i++) 
      res[i] = res[i-1] + res[i -2]; // here we return res[i] = the two previous steps added;

    return res[n];
  }

}

/*
  TESTING
  var stairs = new ClimbStairs();
  System.Console.WriteLine( stairs.Climb(5) );

  EXPLANATION
  - for every n steps the steps will be n = (n-1) + (n-2)
    but if you have n = 1, n = 2; then it will be 1 combinations and 2 combinations 
    for n = 1 and 2 respectively
  - We can use dynamic programming here rather than recursion in order to avoid
    unnecessary computations.
    We can use an array to store results to previous n's and then use them to
    calculate the value for the largest "n".
    i.e. if we want to calculate n = 5 => we know n_1 => 1; n_2 => 2;
    n_3 => 3; n_4 => 3 + 2 => 5; and n_5 = 5 + 3 => 8;
  - If you notice this also follows the fibonacci sequence so you could also
    use an algorithm to emulate this sequence even thought we are technically 
    already taking it in account.
*/