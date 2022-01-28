using Graphs;
using LinkedLists;
using SearchAndSort;

namespace review_leetcode;

class Program {

    static void Main(string[] args) {
        int[][] meetings = new int[][] {
            new int[] {0, 30},
            new int[] {5, 10},
            new int[] {15, 20}
        };

        var meeting = new MeetingRooms();
        meeting.CanAttendMeetings(meetings);
    }

}

