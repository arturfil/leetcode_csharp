namespace LinkedLists;

public class MergeTwoSortedLists {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null) return list2;
        if (list2 == null) return list1;        
        
        if (list1.val < list2.val) {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        } else {
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
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

    var mer = new MergeTwoSortedLists();
    mer.MergeTwoLists(l1, l2);

    l1.printList(l1);

    EXPLANATION
    1 -> 3 -> 4
    1 -> 7 -> 9
    Merged: 1 -> 1 -> 3 -> 4 -> 7 -> 9

    This algorithm is easily done with a recursion
    You want to assign l1.next or l2.next equal to the function
    and the function should return a node.
*/