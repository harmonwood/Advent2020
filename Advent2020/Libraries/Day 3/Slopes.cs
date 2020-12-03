using System;
using System.Collections.Generic;
using System.Text;

namespace Advent2020.Libraries.Day_3
{
    public class Slopes
    {

        public static bool CharIsTree(char location)
        {
            return location == '#';
        }

        public int CountTreesInSlope(string[] slope)
        {
            return CountTreesInSlopeByIncroment(slope, 3, 1);
        }

        public int CountTreesInSlopeByIncroment(string[] slope, int xIncroment, int yIncroment)
        {
            int count = 0;
            int x = 0;

            for (int i = 0; i < slope.Length; i+=yIncroment)
            {
                string row = slope[i];
                char square = row[absoluteX(x, row.Length)];
                _ = CharIsTree(square) ? count++ : count;
                x += xIncroment;
            }
            return count;
        }

        public long MultipySlopes(string[] slope, List<int[]> angles)
        {
            long total = 1;
            foreach (int[] angle in angles)
            {
                int count = CountTreesInSlopeByIncroment(slope, angle[0], angle[1]);
                if (count != 0)
                {
                    total *= count;
                }
            }
            return total;
        }

        public int absoluteX(int x, int length)
        {
            return (x == 0)? x : x % length;
        }
    }
}
