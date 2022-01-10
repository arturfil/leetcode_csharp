namespace Graphs;

public class FloodFill {

  public int[][] Fill(int[][] image, int sr, int sc, int newColor) {
    int color = image[sr][sc];
    if (color != newColor) DFS(image, sr, sc, color, newColor);
    return image;
  }

  public void DFS(int[][] image, int r, int c, int color, int newColor) {
    if (image[r][c] == color) {
      image[r][c] = newColor;
      if (r >= 1) DFS(image, r - 1, c, color, newColor); 
      // next row is bigger than 1
      if (c >= 1) DFS(image, r, c - 1, color, newColor); 
      // next column is bigger than
      if (r + 1 < image.Length) DFS(image, r + 1, c, color, newColor); 
      // next row is less than image.Length
      if (c + 1 < image[0].Length) DFS(image, r, c + 1, color, newColor); 
      // next colum[0] is less than image.Length
    }
  }

}

  /*
    int[][] image = new int[][] {
      new int[] {0,0,0},
      new int[] {0,0,0}
    };
  */

