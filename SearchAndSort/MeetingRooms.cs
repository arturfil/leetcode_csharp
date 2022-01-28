using System;

namespace SearchAndSort;

public class MeetingRooms {
    public bool CanAttendMeetings(int[][] intervals) {
        // intervals = [[5,10], [15,20], [0,30]];
        var n = intervals.Length;
        if (n == 0) return true;
        Array.Sort(intervals, (a, b) => a[0] - b[0]); // sort intervals by start, end;
        for (int i = 1; i < n; i++) {
            if (intervals[i - 1][1] > intervals[i][0]) { // check that there are no overlaps between end and start
            // is there IS an overlapp return false
                return false;
            }
        }
        // otherwise return true;
        return true;
    }
}

/*
    TESTING
    int[][] meetings = new int[][] {
        new int[] {0, 30},
        new int[] {5, 10}, 
        new int[] {15, 20}
    };

    EXPLANATION
    - We are gong to try to track the starting and end time. 
    - For this we need to sort the meetings by starting time.
    - If one meeting has an endtime time that overlaps with the prevous
    we return false
    - otherwise we return true;
*/