using Ch2_TypesInCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Programs
{
    public class Interval
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Interval(int start, int end)
        {
            Start = start;
            End = end;
        }
    }
    public class MergeOverLappingIntervals
    {
        //An interval is a range of numbers represented as a pair of integers[start, end].
        //The task is to take a collection of intervals and merge any overlapping intervals into a single interval.

        // for example - [1, 3], [2, 6], [8, 10], [15, 18]

        //The intervals [1, 3] and [2, 6] overlap because they share the numbers 2 and 3. So, they can be merged into a single interval [1, 6].
        //The other two intervals [8, 10] and [15, 18] do not overlap with any other interval, so they remain unchanged.

        //output should be - [1, 6], [8, 10], [15, 18]

        static List<Interval> MergeIntervals(List<Interval> intervals)
        {
            if (intervals == null || intervals.Count <= 1)
                return intervals;

            int ans=5.CompareTo(1); //1
            int ans1=5.CompareTo(5); //0
            int ans2 =5.CompareTo(10); //-1

            // Sort intervals based on their start times
            intervals.Sort((a, b) => a.Start.CompareTo(b.Start));

            List<Interval> mergedIntervals = new List<Interval>();
            mergedIntervals.Add(intervals[0]);

            foreach (Interval interval in intervals)
            {
                // If the current interval overlaps with the last merged interval, merge them
                if (interval.Start <= mergedIntervals[mergedIntervals.Count - 1].End)
                {
                    mergedIntervals[mergedIntervals.Count - 1].End = Math.Max(mergedIntervals[mergedIntervals.Count - 1].End, interval.End);
                }
                else
                {
                    // If not overlapping, add the interval to the merged list
                    mergedIntervals.Add(interval);
                }
            }

            return mergedIntervals;
        }

        static void Main()
        {
            List<Interval> intervals = new List<Interval>
        {
            new Interval(1, 3),
            new Interval(2, 6),
            new Interval(8, 10),
            new Interval(15, 18)
        };

            List<Interval> mergedIntervals = MergeIntervals(intervals);

            Console.WriteLine("Intervals after merging are ");
            foreach (Interval interval in mergedIntervals)
            {
                Console.WriteLine($"[{interval.Start}, {interval.End}]");
            }
        }
    }
}
