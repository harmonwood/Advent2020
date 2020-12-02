using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Advent2020_tests.Day_2
{
    public class PasswordValidatorTest
    {
        [Fact]
        public void PasswordValidCharTest()
        {
            string truePassword = "ccccccccc";
            string falsePassword = "cdefg";

            Assert.True(Advent2020.Libraries.Day_2.PasswordValidator.PasswordValidChar(2, 9, 'c', truePassword));
            Assert.False(Advent2020.Libraries.Day_2.PasswordValidator.PasswordValidChar(1, 3, 'b', falsePassword));
        }

        [Fact]
        public void PasswordValidPositionsTest()
        {
            string falsePassword = "ccccccccc";
            string truePassword = "abcde";

            Assert.False(Advent2020.Libraries.Day_2.PasswordValidator.PasswordValidPositions(2, 9, 'c', falsePassword));
            Assert.True(Advent2020.Libraries.Day_2.PasswordValidator.PasswordValidPositions(1, 3, 'a', truePassword));
        }
    }
}
