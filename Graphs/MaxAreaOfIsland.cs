namespace Graphs;

public class MaxAreaOfIsland {

  public int MaxArea(int[][] grid) {

    if (grid == null) return 0;
    
    int numIsland = 0;
    int area = 0;

    for(int i = 0; i < grid.Length; ++i) {
      for (int j = 0; j < grid[i].Length; ++j) {
        if (grid[i][j] == 1) numIsland = DFS(grid, i, j);
        
        if (numIsland > area) area = numIsland;
        
      }
    }
    return area;
  }

  private int DFS(int[][] grid, int row, int col) {
    // here we are checking that we are not outside the boundaries
    if(row < 0 || row > grid.Length - 1 || col < 0 || col > grid[row].Length - 1 || grid[row][col] == 0)
      return 0;

    grid[row][col] = 0;

    int val = DFS(grid, row + 1, col) + // return upper val
              DFS(grid, row - 1, col) + // return lower val
              DFS(grid, row, col + 1) + // return right val
              DFS(grid, row, col - 1);  // return left val

    return val + 1;
  }

}

/*
  int[][] grid = new int[][] {
    new int[] {0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
    new int[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
    new int[] {0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
    new int[] {0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0},
    new int[] {0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0},
    new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
    new int[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
    new int[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0}
  };

  var max = new MaxAreaOfIsland();
  max.MaxArea(grid);
*/