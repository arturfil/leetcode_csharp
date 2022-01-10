using LinkedLists;
using Stacks;

namespace review_leetcode;

class Program {

  static void Main(string[] args) {

    var l1 = new ListNode(1);
    var l1_2 = new ListNode(3);
    var l1_3 = new ListNode(4);
    l1.next = l1_2;
    l1_2.next = l1_3;
    
    var l2 = new ListNode(1);
    var l2_2 = new ListNode(7);
    var l2_3 = new ListNode(9);
    l2.next = l2_2;
    l2_2.next = l2_3;

    var mer = new MergeTwoLists();
    mer.MergeLists(l1, l2);

    l1.printList(l1);
  }

}

