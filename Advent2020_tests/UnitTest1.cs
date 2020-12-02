using System;
using Xunit;

namespace Advent2020_tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] data = new int[] {
                1721,
                979,
                366,
                299,
                675,
                1456
            };

            int target = 2020;

            Assert.Equal(514579, actual: Advent2020.Libraries.Lib1.TwoTargetSumsOf(data, target));
        }

        [Fact]
        public void Test2k()
        {
            int[] data = new int[] {
                1721,
                979,
                366,
                299,
                675,
                1456
            };

            int target = 2020;

            Assert.Equal(241861950, actual: Advent2020.Libraries.Lib1.ThreeTargetSumsOf(data, target));
        }
    }

}
