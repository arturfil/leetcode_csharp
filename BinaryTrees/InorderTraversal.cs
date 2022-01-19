using System.Collections.Generic;

namespace BinaryTrees;

public class InOrderTraversal {

  public IList<int> InOrder(TreeNode root) {
    IList<int> tree = new List<int>();
    Stack<TreeNode> stack = new Stack<TreeNode>();
    TreeNode curr = root;
    while(curr != null || stack.Count != 0) {
      while (curr != null) {
        stack.Push(curr);
        curr = curr.left;
      }
      curr = stack.Pop();
      tree.Add(curr.val);
      curr = curr.right;
    }
    return tree;
  }

}

/*
  TESTING
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

  EXPLANATION
  - You want to go all the way to the left and push all nodes along the way.
  - Using a stack will allow you to see the previous node InOrder traversal
  - once you reach all possible left you exit the inner loop and go a root and then
    a right which is at the end, a in-order traversal of the binary tree
*/