namespace Arrays;

public class RemoveDuplicates {

  public int Remove(int[] nums) {
    int k = 0;
    for(int i = 0; i< nums.Length; i++) {
      if(i == 0 || nums[i] != nums[i-1] ) {
        nums[k++] = nums[i];
      } 
    }
    return k;
  }

}

/*
  TESTING
  int[] test = {0,0,1,1,1,2,2,3,3,4}; // 0,1,2,3,4 => 5;
  int[] test2 = {1,1,2}; // 0,1,2,3,4 => 5;
  var dup = new RemoveDuplicates();
  System.Console.WriteLine( dup.Remove(test) );

  EXPLANATION
  - You want to remove AND keep track of how many 
    unique integers are.
  - You could use a HashMap (Dictionary in Python or C#) to 
    keep track of unique characters but the memory is linear
    rather than constant by using an int counter.
  - So you essentialy start in the second element (index 1)
    and check the previous index value, if they match you want to
    assign the NEXT value to the current index value that way,
    you are getting rid of duplicates in linear time.
*/