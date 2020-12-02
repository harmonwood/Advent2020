using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Advent2020_tests.Day_2
{
    public class PasswordDataSetParserTest
    {
        [Fact]
        public void GetLowIterationFromStringTest()
        {
            string record = "155-3 a: abcde";
            Assert.Equal(155, actual: Advent2020.Libraries.Day_2.PasswordDataSetParser.GetLowIterationFromString(record));
        }

        [Fact]
        public void GetHighIterationFromStringTest()
        {
            string record = "1-333 a: abcde";
            Assert.Equal(333, actual: Advent2020.Libraries.Day_2.PasswordDataSetParser.GetHighIterationFromString(record));
        }

        [Fact]
        public void GetRepetCharFromStringTest()
        {
            string record = "1-3 aaaa: abcde";
            Assert.Equal("aaaa", actual: Advent2020.Libraries.Day_2.PasswordDataSetParser.GetRepetCharFromString(record));
        }

        [Fact]
        public void GetPasswordFromStringTest()
        {
            string record = "1-3 aaaa: abcde";
            Assert.Equal("abcde", actual: Advent2020.Libraries.Day_2.PasswordDataSetParser.GetPasswordFromString(record));
        }
    }
}
