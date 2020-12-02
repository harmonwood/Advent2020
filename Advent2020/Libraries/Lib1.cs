using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advent2020.Libraries
{
    public class Lib1
    {
        static public int TwoTargetSumsOf(int[] data, int target)
        { 
            int[] sums = DoesSum(data, target);
            return sums.Aggregate(1, (a,b) => a * b);
        }
        static public int ThreeTargetSumsOf(int[] data, int target)
        { 
            int[] sums = DoesSumThree(data, target);
            return sums.Aggregate(1, (a,b) => a * b);
        }

        static public int[] DoesSum(int[] data, int target)
        {
            int[] both = new int[] { };
            foreach (int firstNumber in data)
            {
                foreach (int secondNumber in data)
                {
                    if (firstNumber == secondNumber) { continue; }
                    if (firstNumber + secondNumber == target)
                    {
                        both = new int[]{ firstNumber, secondNumber};
                    }
                }
            }

            return both; 
        }
        static public int[] DoesSumThree(int[] data, int target)
        {
            int[] equalNumbers = new int[] { };
            foreach (int firstNumber in data)
            {
                foreach (int secondNumber in data)
                {
                    if (firstNumber == secondNumber) { continue; }
                    foreach (int thirdNumber in data)
                    {
                        if (secondNumber == thirdNumber) { continue; }
                        if (firstNumber + secondNumber + thirdNumber == target)
                        {
                            equalNumbers = new int[] { firstNumber, secondNumber, thirdNumber };
                        }
                    }
                }
            }

            return equalNumbers; 
        }

    }
}
