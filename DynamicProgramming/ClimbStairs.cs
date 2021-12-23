namespace DynamicProgramming {

  public class ClimbStairs {

    public int Climb(int n) {
      int[] solutions = new int[n + 1];
      return NumbOfComb(0, n, solutions);
    }

    public int NumbOfComb(int i, int n, int[] sol) {
      if (1 > n) return 0;
      if (i == n) return  1;
      if (sol[i] > 0) return sol[i];
      sol[i] = NumbOfComb(i + 1, n, sol) + NumbOfComb(i + 2, n, sol);
      return sol[i];
    }

    public int ClimbIterative(int n) {
      if (n <= 2) return n;

      int[] res = new int[n+1];
      res [1] = 1;
      res[2] = 2;
      for(int i = 3; i <= n; i++) 
        res[i] = res[i-1] + res[i -2]; // here we return res[i] = the two previous steps added;

      return res[n];
    }

  }

}