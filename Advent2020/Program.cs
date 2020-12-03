using System;
using System.Collections.Generic;
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
            Day3a();
            Day3b();
        }


        static void Day1()
        {
            int[] data = System.IO.File
                .ReadAllLines(@"../../../data/Day1.txt")
                .Select(x => int.Parse(x))
                .ToArray();
            int target = 2020;
            Console.WriteLine("Day 1a: Number of sum of two numbers that equal 2020 are {0}", Libraries.Day1.TwoTargetSumsOf(data, target));
            Console.WriteLine("Day 1b: Number of sum of Three numbers that equal 2020 are {0}", Libraries.Day1.ThreeTargetSumsOf(data, target));
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
            Console.WriteLine("Day 2b: The number of correct passwords with the correct possitions are {0}", count);
        }

        static void Day3a()
        {
            string[] records = System.IO.File
                .ReadAllLines(@"../../../data/Day3.txt")
                .ToArray();
            var slope = new Libraries.Day_3.Slopes();
            Console.WriteLine("Day 3a: The number of trees on Slope are {0}", slope.CountTreesInSlope(records));
        }
        static void Day3b()
        {
            string[] records = System.IO.File
                .ReadAllLines(@"../../../data/Day3.txt")
                .ToArray();
            var slope = new Libraries.Day_3.Slopes();

            List<int[]> angles = new List<int[]>() { 
                new int[]{ 1, 1},
                new int[]{ 3, 1},
                new int[]{ 5, 1},
                new int[]{ 7, 1},
                new int[]{ 1, 2}
            };

            Console.WriteLine("Day 3b: The number of multiplied trees on each Slope are {0}", slope.MultipySlopes(records, angles));
        }

    }
}
