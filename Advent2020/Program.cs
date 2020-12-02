using System;
using System.Linq;

namespace Advent2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1();
            Day2a();
            Day2b();

        }


        static void Day1()
        {
            int[] data = System.IO.File
                .ReadAllLines(@"../../../data/Day1.txt")
                .Select(x => int.Parse(x))
                .ToArray();
            int target = 2020;
            Console.WriteLine(Libraries.Lib1.ThreeTargetSumsOf(data, target));
        }
        static void Day2a()
        {
            string[] records = System.IO.File
                .ReadAllLines(@"../../../data/Day2.txt")
                .ToArray();
            int count = records.Count(
                entry => Libraries.Day_2.PasswordValidator.PasswordValidChar(
                    Libraries.Day_2.PasswordDataSetParser.GetLowIterationFromString(entry),
                    Libraries.Day_2.PasswordDataSetParser.GetHighIterationFromString(entry),
                    Libraries.Day_2.PasswordDataSetParser.GetRepetCharFromString(entry)[0],
                    Libraries.Day_2.PasswordDataSetParser.GetPasswordFromString(entry)
                    )
                );
            Console.WriteLine("Day 2a: The number of correct passwords is {0}", count);
        }

        static void Day2b()
        {
            string[] records = System.IO.File
                .ReadAllLines(@"../../../data/Day2.txt")
                .ToArray();
            int count = records.Count(
                entry => Libraries.Day_2.PasswordValidator.PasswordValidPositions(
                    Libraries.Day_2.PasswordDataSetParser.GetLowIterationFromString(entry),
                    Libraries.Day_2.PasswordDataSetParser.GetHighIterationFromString(entry),
                    Libraries.Day_2.PasswordDataSetParser.GetRepetCharFromString(entry)[0],
                    Libraries.Day_2.PasswordDataSetParser.GetPasswordFromString(entry)
                    )
                );
            Console.WriteLine("Day 2a: The number of correct passwords with the correct possitions are {0}", count);
        }

    }
}
