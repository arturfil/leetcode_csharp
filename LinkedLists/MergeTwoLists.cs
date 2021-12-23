namespace LinkedLists {

  public class MergeTwoLists {
    
    public ListNode MergeLists(ListNode l1, ListNode l2) {      
      if (l1 == null)  return l2;
      else if (l2 == null) return l1;
      else if (l1.val < l2.val) {
        l1.next = MergeLists(l1.next, l2);
        return l1;
      } else {
        l2.next = MergeLists(l1, l2.next);
        return l2;
      }
    }

  }
}