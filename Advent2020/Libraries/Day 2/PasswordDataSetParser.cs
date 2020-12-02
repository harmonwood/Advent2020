using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Advent2020.Libraries.Day_2
{
    public class PasswordDataSetParser
    {
        public static int GetLowIterationFromString(string record)
        {
            string pattern = @"^(\d*)";
            return int.Parse(ParseRegexFirstGroup(pattern, record));
        }

        public static int GetHighIterationFromString(string record)
        {
            string pattern = @"^\d*-(\d*)";
            return int.Parse(ParseRegexFirstGroup(pattern, record));
        }
        public static string GetRepetCharFromString(string record)
        {
            string pattern = @"^\d*-\d*\s*(\w*)";
            return ParseRegexFirstGroup(pattern, record);
        }
        public static string GetPasswordFromString(string record)
        {
            string pattern = @"^\d*-\d*\s*\w*\s*:\s*(.*)$";
            return ParseRegexFirstGroup(pattern, record);
        }

        public static string ParseRegexFirstGroup(string pattern, string record)
        {
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.Match(record).Groups[1].Value;

        }
    }
}
