using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Advent2020_tests.Day3
{
    public class SlopeTest
    {
        [Fact]
        public void CharIsTreeTest()
        {
            char tree = '#';
            char notTree = '.';

            Assert.True(Advent2020.Libraries.Day_3.Slopes.CharIsTree(tree));
            Assert.False(Advent2020.Libraries.Day_3.Slopes.CharIsTree(notTree));
        }

        [Fact]
        public void CountTreesInSlopeTest()
        {

            string[] slope = new string[] {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#"
            };
            Advent2020.Libraries.Day_3.Slopes slopes = new Advent2020.Libraries.Day_3.Slopes();

            Assert.Equal(7, slopes.CountTreesInSlope(slope));
        }

        [Fact]
        public void CountTreesByIncromentTest()
        {

            string[] slope = new string[] {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".##.#...#.#"
            };

            Advent2020.Libraries.Day_3.Slopes slopes = new Advent2020.Libraries.Day_3.Slopes();

            Assert.Equal(7, slopes.CountTreesInSlopeByIncroment(slope, 3, 1));
            Assert.Equal(1, slopes.CountTreesInSlopeByIncroment(slope, 1, 5));
        }

        [Fact]
        public void MultiplySlopesTest()
        {

            string[] slope = new string[] {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#"
            };

            List<int[]> angles = new List<int[]>() { 
                new int[]{ 1, 1},
                new int[]{ 3, 1},
                new int[]{ 5, 1},
                new int[]{ 7, 1},
                new int[]{ 1, 2}
            };
            Advent2020.Libraries.Day_3.Slopes slopes = new Advent2020.Libraries.Day_3.Slopes();

            Assert.Equal(336, slopes.MultipySlopes(slope, angles));
        }

    }
}
