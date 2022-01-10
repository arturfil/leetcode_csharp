namespace Graphs;

public class NumberOfIslands {

  public int NumOfIslands(char[][] grid) {

    if (grid == null) return 0;

    int numOfIslands = 0;

    for (int i = 0; i < grid.Length; i++) {
      for (int j = 0; j < grid[i].Length; j++) {
        if (grid[i][j] == '1') {
          numOfIslands++;
          DFS(grid, i, j);
        }
      }
    }

    return numOfIslands;
  }

  private void DFS(char[][] grid, int row, int col) {
    if (row < 0 || col < 0 || row == grid.Length ||
    col == grid[0].Length || grid[row][col] == '0') return;

    grid[row][col] = '0';


    DFS(grid, row - 1, col);
    DFS(grid, row + 1, col);
    DFS(grid, row, col + 1);
    DFS(grid, row, col - 1);
  }

}

/*
  char[][] grid = new char[][] {
    new char[] {'1','1','1','1','0'},
    new char[] {'1','1','0','1','0'},
    new char[] {'1','1','0','0','0'},
    new char[] {'0','0','0','0','0'}
  };

  char[][] grid2 = new char[][] {
    new char[] {'1','1','0','0','0'},
    new char[] {'1','1','0','0','0'},
    new char[] {'0','0','1','0','0'},
    new char[] {'0','0','0','1','1'}
  };

  var num = new NumberOfIslands();
  num.NumOfIslands(grid);
*/