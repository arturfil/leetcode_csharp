namespace LinkedLists;

public class MergeTwoLists {
  
  public ListNode MergeLists(ListNode l1, ListNode l2) {
    if (l1 == null) return l2;
    if (l2 == null) return l1;
    
    else if (l1.val < l2.val) {
      l1.next = MergeLists(l1.next, l2);
      return l1;
    } else {
      l2.next = MergeLists(l1, l2.next);
      return l2;
    }

  }

}

/*
  TESTING
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

  EXPLANATION
  This algorithm is easily done with a recursion
  You want to assign l1.next or l2.next equal to the function
  and the function should return a node.
*/