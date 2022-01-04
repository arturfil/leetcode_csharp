using Arrays;
using Arryas;
using Graphs;
using Heap;
using SlidingWindow;
using Strings;

namespace review_leetcode {

  class Program {

    static void Main(string[] args) {
      
      TwoSum sum = new TwoSum();
      int[] test = new int[] {1,1,1,1,1,1,1,1,1,1,1,1,1,7,1,1,1,1,1,4};
      int[] result =  sum.Sum(test, 11);
      foreach(int num in result) System.Console.WriteLine(num);
    }

  }

}