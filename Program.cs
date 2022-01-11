using Arrays;


namespace review_leetcode;

class Program {

  static void Main(string[] args) {

    int[] test = {-2,1,-3,4,-1,2,1,-5,4};
    var max = new MaxSubArray();
    System.Console.WriteLine( max.MaxSub(test) );

  }

}

