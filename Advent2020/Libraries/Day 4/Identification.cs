using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Advent2020.Libraries.Day_4
{
    public class Identification
    {
        public int? birthYear = null;
        public int? issueYear = null;
        public int? experationYear = null;
        public string height = null;
        public string hairColor = null;
        public string eyeColor = null;
        public string passportId = null;
        public string countryId = null;

        public Identification(int? birthYear, int? issueYear, int? experationYear, string height, string hairColor, string eyeColor, string passportId, string countryId)
        {
            this.birthYear = birthYear;
            this.issueYear = issueYear;
            this.experationYear = experationYear;
            this.height = height;
            this.hairColor = hairColor;
            this.eyeColor = eyeColor;
            this.passportId = passportId;
            this.countryId = countryId;
        }

        public bool IsValid()
        {
            return birthYear != null
                && issueYear != null
                && experationYear != null
                && height != ""
                && hairColor != ""
                && eyeColor != ""
                && passportId != ""
                ;
        }
        public bool IsStrictValid()
        {
            return birthYearValid()
                && issueYearValid()
                && experationYearValid()
                && heightValid()
                && hairColorValid()
                && eyeColorValid()
                && passportIdValid()
                ;
        }

        private bool passportIdValid()
        {
            return passportId.Length == 9;
        }

        private bool eyeColorValid()
        {
            List<string> validColors = new List<string>()
            {
                "amb",
                "blu",
                "brn",
                "gry",
                "grn",
                "hzl",
                "oth"
            };
            return validColors.Contains(eyeColor);
        }

        private bool hairColorValid()
        {
            Regex regex = new Regex(@"#[a-zA-Z0-9]{6}", RegexOptions.IgnoreCase);
            var result = regex.Match(hairColor);
            return hairColor.Length == 7 && result.Success;
        }

        private bool heightValid()
        {
            List<object> data = new List<object>(){ };
            Regex regex = new Regex(@"(\d*)([cm|in]{2})", RegexOptions.IgnoreCase);
            var match = regex.Match(height);
            if (match.Success)
            {
                if(match.Groups[2].Value == "in")
                {
                    return int.Parse(match.Groups[1].Value) >= 59
                        && int.Parse(match.Groups[1].Value) <= 76
                        ;
                }
                else
                {
                    return int.Parse(match.Groups[1].Value) >= 150
                        && int.Parse(match.Groups[1].Value) <= 193
                        ;
                }
            }
            return false;

        }

        private bool experationYearValid()
        {
            return experationYear >= 2020
                && experationYear <= 2030
                ;
        }

        private bool issueYearValid()
        {
            return issueYear >= 2010
                && issueYear <= 2020
                ;
        }

        private bool birthYearValid()
        {
            return birthYear >= 1920
                && birthYear <= 2002
                ;
        }
    }
}
