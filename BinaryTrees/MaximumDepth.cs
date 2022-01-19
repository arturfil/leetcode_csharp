namespace BinaryTrees;

public class MaximumDepth {  
  public int MaxDepth(TreeNode root) {
    if (root == null) return 0;
    int leftMax = 1 + MaxDepth(root.left);
    int rightMax = 1 + MaxDepth(root.right);
    return rightMax > leftMax ? rightMax : leftMax;
  }
}

/*
  TESTING
  TreeNode root = new TreeNode(3);
  TreeNode n2_L = new TreeNode(9);
  
  TreeNode n2_R = new TreeNode(20);
  TreeNode n3_R = new TreeNode(15);
  TreeNode n4_R = new TreeNode(7);

  root.left = n2_L;

  root.right = n2_R;
  n2_R.left = n3_R;
  n2_R.right = n4_R;
    
       3
    /     \
   9       20
          /   \
         15    7
    
  var tree = new MaximumDepth();
  int result = tree.MaxDepth(root); // should be 3;
  System.Console.WriteLine(result);

  EXPLANATION
  - You are recursing on depth of both sides. 
  - Even though you see that I'm only "going right" or "going left"
    what is actually happenging is that every "left node" or "right node"
    is being traversed BOTH right AND left therefore EVERY subtree is being 
    accounted for
  - In Essence maxLeft = subMaxLeft + subMaxRight; and same for maxRight;
    where all subtrees are being accounted for.
*/
