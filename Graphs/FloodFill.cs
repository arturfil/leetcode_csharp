namespace Graphs;

public class FloodFill {
    public int[][] Fill(int[][] image, int sr, int sc, int newColor) {
        int color = image[sr][sc]; // current color;
        if (color != newColor) DFS(image, sr, sc, color, newColor);
        return image;
    }

    public void DFS(int[][] image, int r, int c, int color, int newColor) {
        if (image[r][c] == color) {
            image[r][c] = newColor;
            if (r >= 1) DFS(image, r - 1, c, color, newColor);
            if (c >= 1) DFS(image, r, c - 1, color, newColor);
            if (r + 1 < image.Length) DFS(image, r + 1, c, color, newColor);
            if (c + 1 < image[0].Length) DFS(image, r, c + 1, color, newColor);
        }
    }
}

/*
    TEST
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

    EXPLANATION
    - You have an image with certain pixels ("numbers") that you want to change of color
    - There is a pixel what will be the "Flood Source" for that new color.
    - You can only pass on that new color to other pixels IF they match same pixel color
    (same number) AND if they are connected 4 directionaly (up, down, right left) diagonal doesn't count

*/

