using Arrays;
using BinaryTrees;
using DynamicProgramming;
using Graphs;
using Strings;

namespace review_leetcode;

class Program {

  static void Main(string[] args) {

    int[] stockPrices = new int[] {7,1,5,3,6,4};
    int[] stockPrices2 = new int[] {7,6,4,3,1};
    var bestBuy = new BestTimeToBuySellStock();
    bestBuy.MaxProfit(stockPrices2);
  
  }

}

