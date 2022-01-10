namespace Arrays;

public class RemoveDuplicates {

  public int Remove(int[] nums) {
    if (nums.Length == 0) return 0;

    int length = 1; 
    for (int i = 1; i < nums.Length; i++) {
      if (nums[i] != nums[i - 1]) {
        nums[length++] = nums[i]; 
      }
    }

    return length;
  }

}

