using Arrays;
using BinaryTrees;

namespace review_leetcode;

class Program {

  static void Main(string[] args) {

    var inOrder = new InOrderTraversal();

    TreeNode root = new TreeNode(5);
    TreeNode n1_L = new TreeNode(4);
    TreeNode n2_L = new TreeNode(3);
    TreeNode n3_L = new TreeNode(2);
    TreeNode n1_R = new TreeNode(6);
    TreeNode n2_R = new TreeNode(7);
    TreeNode n3_R = new TreeNode(8);

    root.left = n1_L;
    root.right = n1_R;
    
    n1_L.left = n2_L;
    n2_L.left = n3_L;

    n1_L.right = n2_R;
    n2_R.right = n3_R;

    inOrder.InOrder(root);
  
  }

}

