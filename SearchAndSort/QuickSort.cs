namespace SearchAndSort;

public class QuickSort {
  // methods to make the pivot partions
  public int Partition(int[] arr, int left, int right) {
    int pivot;
    pivot = arr[left];
    while (true) {
      while(arr[left] < pivot) {
        left++;
      }
      while (arr[right] > pivot) {
        right--;
      }
      if (left < right) {
        // here is where the swapping happens
        int temp = arr[right];
        arr[right] = arr[left];
        arr[left] = temp;
      } else {
        return right;
      }
    }
  }


  public void Sort(int[] arr, int left, int right) {
    int pivot;
    if (left < right) {
      pivot = Partition(arr, left, right);
      if (pivot > 1) {
        Sort(arr, left, pivot - 1);
      }
      if (pivot + 1 < right) {
        Sort(arr, pivot + 1, right);
      }
    }
  }
  
}