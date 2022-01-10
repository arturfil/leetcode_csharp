namespace TwoPointers;

public class RotateArray {

  public void Rotate(int[] nums, int k) {
    int[] swapped = new int[nums.Length];
    // number of characters swaped is dicated by k
    int start = nums.Length;
    for(int i = 0; i < nums.Length; i++ ) {
      // using modulus operator allows us to add index plus the place of 
      // the number of charachters rotated i.e i = 0; rotate k = 3 => swapped[3] = nums[0];
      // once we are at or beyond nums.Length, 
      //    (where lenght is 7) i = 5, k = 3; i.e 5 + 3 => 8 % 7 = 1;  => swapped[1] = nums[5]
      // same goes with i = 4 & k = 3; => 7 % 7 = 0 therefore swapped[0] = nums[4];
      swapped[(i+k) % nums.Length] = nums[i]; 
    }
    // here we are just passing back the numbers from one array to the      
    for(int i = 0; i < swapped.Length; i++) {
      nums[i] = swapped[i];
    }
  
  }

}

/*
  TESTING: => put this code in Program.cs
  int[] nums = {1,2,3,4,5,6,7}; // solution with k = 3; => {5,6,7,1,2,3,4};
  var rot = new RotateArray();
  rot.Rotate(nums, 3);
*/