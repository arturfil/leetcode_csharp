using Arrays;
using BinaryTrees;
using Graphs;

namespace review_leetcode;

class Program {

  static void Main(string[] args) {

    string[] lasers = new string[] {"011001","000000","010100","001000"}; // 8
    string[] lasers2 = new string[] {"0001","010100","001000"}; // 4

    var beams = new NumberOfLaserBeams();
    beams.NumberOfBeams(lasers);
  
  }

}

