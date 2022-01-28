namespace LinkedLists;

public class ReverseLinkedList {
    public ListNode ReverseList(ListNode head) {
        ListNode current = head;
        ListNode previous = null;
        
        while(current != null) {
            ListNode nextTemp = current.next;
            current.next = previous;
            previous = current;
            current = nextTemp;
        }

        return previous;
    }
}

/*
    TEST
    var l1 = new ListNode(1);
    var l1_2 = new ListNode(3);
    var l1_3 = new ListNode(4);
    var l1_4 = new ListNode(5);
    var l1_5 = new ListNode(7);
    var l1_6 = new ListNode(8);
    l1.next = l1_2;
    l1_2.next = l1_3;
    l1_3.next = l1_4;
    l1_4.next = l1_5;
    l1_5.next = l1_6;

    var reverse = new ReverseLinkedList();
    reverse.ReverseList(l1);
    l1.printList(l1_6);

    EXPLANATION
    - In order to reverse the linked list you are going to have to be 
    pointig to three nodes at the same time. 
    - You need the middle one (current), the previous and the next.
    - This is needed because now the initial previous points to nothing,
    - the current.next points to previous and the next.next points to current;
    - Essentially you are changing the direction of the pointers.

*/