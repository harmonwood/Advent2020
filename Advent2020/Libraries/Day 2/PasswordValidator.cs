using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advent2020.Libraries.Day_2
{
    public class PasswordValidator
    {

        public static bool PasswordValidChar(int min, int max, char chars, string password)
        {
            int count = password.Count(c => c == chars);
            return (count >= min && count <= max);
        }

        public static bool PasswordValidPositions(int min, int max, char chars, string password)
        {
            bool first = password[min-1] == chars;
            bool second = password[max-1] == chars;
            return (first ^ second);
        }
    }
}
