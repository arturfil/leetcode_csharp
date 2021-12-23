namespace Utils {

  public class ArrayUtils {

    public void PrintArray(int[] arr) {

      System.Console.Write("[ ");
      foreach(int i in arr) {
        System.Console.Write($" {i} ");
      }
      System.Console.WriteLine(" ]");

    }

  }

}