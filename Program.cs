using Arrays;
using BinaryTrees;

namespace review_leetcode;

class Program {

  static void Main(string[] args) {


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

    /*
                 1
              /     \
             2        2
           /   \    /   \
          3     4  4     3
    */
    
    var sym = new SymmetricTree();
    bool result = sym.IsSymmetric(root);
    System.Console.WriteLine(result);
  
  }

}

