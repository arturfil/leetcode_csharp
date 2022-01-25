using Arrays;
using BinaryTrees;
using DynamicProgramming;
using Graphs;
using SearchAndSort;
using Strings;

namespace review_leetcode;

class Program {

  static void Main(string[] args) {

    int[] test = new int[] {3,2,1,5,6,4}; 
    int k = 2;
    var largest = new KLargestElement();
    largest.FindKthLargest(test, k);
  
  }

}

