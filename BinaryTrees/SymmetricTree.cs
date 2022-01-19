namespace BinaryTrees;

public class SymmetricTree {
  public bool IsSymmetric(TreeNode root) {
    return IsMirror(root, root);
  }

  private bool IsMirror(TreeNode n1, TreeNode n2) {
    if (n1 == null && n2 == null) return true;
    if (n1 == null || n2 == null) return false;
    
    return (n1.val == n2.val) &&
      IsMirror(n1.right, n2.left) &&
      IsMirror(n1.left, n2.right);
  }

}

/*
  TESTING
  TreeNode root = new TreeNode(1);
    TreeNode n2_L = new TreeNode(2);
    TreeNode n3_L = new TreeNode(3);
    TreeNode n4_L = new TreeNode(4);
    
    TreeNode n2_R = new TreeNode(2);
    TreeNode n3_R = new TreeNode(3);
    TreeNode n4_R = new TreeNode(4);

    root.left = n2_L;
    n2_L.left = n3_L;
    n2_L.right = n4_L;

    root.right = n2_R;
    n2_R.left = n4_R;
    n2_R.right = n3_R;

  Tree:    
          1
       /     \
      2        2
    /   \    /   \
  3     4   4     3
    
    
  var sym = new SymmetricTree();
  bool result = sym.IsSymmetric(root);
  System.Console.WriteLine(result);

  EXPLANATION:
  - You are going to make sure that on every level, the node is not null,
    if one node is null BUT not both, it's not symmetric and hence false;
  - IF both are null, means you reach the max level of the tree.
  - You are checking on both left and right at the same time, therefore
    every node is being accounted for.
*/