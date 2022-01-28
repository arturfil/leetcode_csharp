using Graphs;
using LinkedLists;

namespace review_leetcode;

class Program {

    static void Main(string[] args) {
        
        int[][] image1 = new int[][] {
            new int[] {1,1,1},
            new int[] {1,1,0},
            new int[] {1,0,1}
        };
        var flood = new FloodFill();
        flood.Fill(image1,1,1,2);
        for(int i = 0; i < image1[0].Length; i++) {
            System.Console.Write("{ ");
            for (int j = 0; j < image1[i].Length; j++) {
                System.Console.Write($"{image1[i][j]}, ");
            }
            System.Console.WriteLine("}");
        }
    }

}

