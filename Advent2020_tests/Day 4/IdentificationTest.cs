using Advent2020.Libraries.Day_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Advent2020_tests.Day_4
{
    public class IdentificationTest
    {
        [Fact]
        public void ParseRawRecordsTest()
        {
            string[] rawFile = new string[]
            {
                "ecl:gry pid:860033327 eyr: 2020 hcl:#fffffd",
                "byr: 1937 iyr: 2017 cid: 147 hgt: 183cm",
                "",
                "iyr:2013 ecl: amb cid:350 eyr: 2023 pid: 028048884",
                "hcl:#cfa07d byr:1929"
            };

            string[] rawRecords = new string[]
            {
                "ecl:gry pid:860033327 eyr: 2020 hcl:#fffffd byr: 1937 iyr: 2017 cid: 147 hgt: 183cm",
                "iyr:2013 ecl: amb cid:350 eyr: 2023 pid: 028048884 hcl:#cfa07d byr:1929"
            };

            Assert.Equal(rawRecords, Advent2020.Libraries.Day_4.IdentificationParser.ParseRawRecords(rawFile));

        }

        [Fact]
        public void StrintInvalidTest()
        {
            string[] records = System.IO.File
              .ReadAllLines(@"../../../Day 4/StrictInvalidPassports.txt")
              .ToArray();
            List<Identification> Ids = IdentificationParser.Parse(records);
            int count = Ids.Count(
                entry => entry.IsStrictValid()
                );
            Assert.Equal(0, count);
        }

        [Fact]
        public void StrintValidTest()
        {
            string[] records = System.IO.File
              .ReadAllLines(@"../../../Day 4/StrictValidPassports.txt")
              .ToArray();
            List<Identification> Ids = IdentificationParser.Parse(records);
            int count = Ids.Count(
                entry => entry.IsStrictValid()
                );
            Assert.Equal(4, count);
        }
    }
}
