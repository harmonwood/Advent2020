using System;
using System.Collections.Generic;
using System.Text;
using Advent2020.Libraries.Day_2;

namespace Advent2020.Libraries.Day_4
{
    public static class IdentificationParser
    {
        public static List<Identification> Parse(string[] fileArray)
        {
            List<Identification> dataSet = new List<Identification>();
            string[] rawRecords = ParseRawRecords(fileArray);
            foreach (string record in rawRecords)
            {
                dataSet.Add(StringToId(record));
            }
            return dataSet;
        }

        private static Identification StringToId(string record)
        {
            return new Identification(
                     ToNullableInt(PasswordDataSetParser.ParseRegexFirstGroup(@"byr:(\S*)", record)),
                     ToNullableInt(PasswordDataSetParser.ParseRegexFirstGroup(@"iyr:(\S*)", record)),
                     ToNullableInt(PasswordDataSetParser.ParseRegexFirstGroup(@"eyr:(\S*)", record)),
                     PasswordDataSetParser.ParseRegexFirstGroup(@"hgt:(\S*)", record),
                     PasswordDataSetParser.ParseRegexFirstGroup(@"hcl:(\S*)", record),
                     PasswordDataSetParser.ParseRegexFirstGroup(@"ecl:(\S*)", record),
                     PasswordDataSetParser.ParseRegexFirstGroup(@"pid:(\S*)", record),
                     PasswordDataSetParser.ParseRegexFirstGroup(@"cid:(\S*)", record)
                );
        }

        public static string[] ParseRawRecords(string[] fileArray)
        {
            List<string> dataSet = new List<string>() { };
            int recordCount = 0;
            for (int i = 0; i < fileArray.Length; i++)
            {
                string line = fileArray[i];
                if (line.Trim() == "")
                {
                    recordCount++;
                    continue;
                }
    
                if (recordCount < dataSet.Count)
                {
                    dataSet[recordCount] += " " + line.Trim();
                } else
                {
                    dataSet.Add(line.Trim());
                }
            }
            return dataSet.ToArray();
        }

        public static int? ToNullableInt(this string s)
        {
            int i;
            if (int.TryParse(s, out i)) return i;
            return null;
        }

    }
}
