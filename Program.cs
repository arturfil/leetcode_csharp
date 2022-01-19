using Arrays;
using BinaryTrees;

namespace review_leetcode;

class Program {

  static void Main(string[] args) {


    TreeNode root = new TreeNode(3);
    TreeNode n2_L = new TreeNode(9);
    
    TreeNode n2_R = new TreeNode(20);
    TreeNode n3_R = new TreeNode(15);
    TreeNode n4_R = new TreeNode(7);

    root.left = n2_L;

    root.right = n2_R;
    n2_R.left = n3_R;
    n2_R.right = n4_R;

    /*
                 3
              /     \
             9       20
                    /   \
                   15    7
    */
    
    var tree = new MaximumDepth();
    int result = tree.MaxDepth(root); // should be 3;
    System.Console.WriteLine(result);

  
  }

}

