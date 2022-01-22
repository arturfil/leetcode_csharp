using System;

namespace BinaryTrees;

// 2, 3, 6, 8, 10, 12
public class ArrayToBinaryTree {
  int[] nums;
  Random rand = new Random();

  public TreeNode SortedArrayToBST(int[] nums) {
    this.nums = nums;
    return Helper(0, nums.Length -1);
  }

  public TreeNode Helper(int left, int right) {
    if (left > right) return null;
    int p = (left + right) / 2;
    if ((left + right) % 2 == 1) p += rand.Next(2);

    TreeNode root = new TreeNode(nums[p]);
    root.left = Helper(left, p - 1);
    root.right = Helper(p + 1, right);
    return root;
  }
}

/*
  TESTING
  int[] treeArray = new int[] {-10, -3, 0, 5, 8};
  var binTree = new ArrayToBinaryTree();
  binTree.SortedArrayToBST(treeArray);

  EXPLANATION
  - You start assigning the middle or "root" node
  and from there you assign new values using a recursive
  function where that assigns the next value to the new nodes
*/