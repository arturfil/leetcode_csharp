using LinkedLists;

namespace review_leetcode;

class Program {

    static void Main(string[] args) {
        
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

    }

}

