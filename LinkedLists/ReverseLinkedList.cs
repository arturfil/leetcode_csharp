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

    EXPLANATION

*/