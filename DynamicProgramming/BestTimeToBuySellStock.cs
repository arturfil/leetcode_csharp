namespace DynamicProgramming;

public class BestTimeToBuySellStock {
  public int MaxProfit(int[] prices) {
    if (prices.Length == 0 || prices == null) return 0;
    
    int min = prices[0];
    int max = 0;
    
    for (int i = 0; i < prices.Length; i++) {
      if (prices[i] < min)
        min = prices[i];
      else if (prices[i] - min > max)
        max = prices[i] - min;
    }
    return max;
  }
}

/*
  TESTING
  int[] stockPrices = new int[] {7,1,5,3,6,4};
  var bestBuy = new BestTimeToBuySellStock();
  bestBuy.MaxProfit(stockPrices);

  EXPLANATION
  - This is a Greedy Algorithm. Greedy algorithms are another form 
  of dynamic programming. The principle of these algorithms is to 
  get the most value out of a possible outcome per process/iteration
  compared to overall efficiency.
  - In this case you want to get the most out of a single buy and sell
  rather than buy, wait an later sell (Hence if you go to the leetcode problem)
  it specifies you can only buy/sell within consecutive days.
  - And hence, min is easy, you go through every index and that the value is the lowest.
  - The tricky part is the max value where you want to check that if the value,
  when you substrack min to the current index value AND is larger than "max", 
  then and only then you reasign max to that new max value (also means is positive)
    
*/