namespace Heap;

public class WordSearch {

  public bool Exist(char[][] board, string word) {
    int rows = board.Length;
    int cols = board[0].Length;
    bool[][] visited = new bool[rows][];

    for (int i = 0; i < rows; i++) visited[i] = new bool[cols];

    for (int i = 0; i < rows; i++) {
      for (int j = 0; j < cols; j++) {
        if (DFS(board, word, 0, i, j, visited)) return true;
      }
    }

    return false;
  }

  public bool DFS(char[][] board, string word, int index, int i, int j, bool[][] visited) {
    if (index == word.Length) return true;
    if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length
      || board[i][j] != word[index] || visited[i][j]
    ) return false;
    visited[i][j] = true;

    bool res = DFS(board, word, index + 1, i + 1, j, visited) ||
                DFS(board, word, index + 1, i - 1, j, visited) ||
                DFS(board, word, index + 1, i, j + 1, visited) ||
                DFS(board, word, index + 1, i, j - 1, visited);

    visited[i][j] = false;
    return res;
  }

}

/**
  For testing
   var board = new WordSearch();
      char[][] test = {
        new char[] {'A','B','C','E'},
        new char[] {'S','F','C','S'},
        new char[] {'A','D','E','E'}
      };
      bool result = board.Exist(test, "ABCCED");
      System.Console.WriteLine(result);
*/