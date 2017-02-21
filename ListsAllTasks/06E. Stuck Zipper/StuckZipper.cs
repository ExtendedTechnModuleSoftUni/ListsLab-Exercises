namespace _06E.Stuck_Zipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StuckZipper
    {
        static void Main()
        {
            var firstListNumbers = Console.ReadLine().Split(' ').ToList();
            var secondListNumbers = Console.ReadLine().Split(' ').ToList();
            int minLengthOfDigits = int.MaxValue;

            minLengthOfDigits = GetMinLengthOfEachDigit(firstListNumbers, secondListNumbers, minLengthOfDigits);
            RemovingLargerLengthDigits(firstListNumbers, secondListNumbers, minLengthOfDigits);
            ZipAndPrintLists(firstListNumbers, secondListNumbers);
        }

        static void ZipAndPrintLists(List<string> firstListNumbers, List<string> secondListNumbers)
        {
            var resultList = new List<string>();
            int max = Math.Max(firstListNumbers.Count, secondListNumbers.Count);

            for (int i = 0; i < max; i++)
            {
                if (i < secondListNumbers.Count)
                {
                    resultList.Add(secondListNumbers[i]);
                }
                if (i < firstListNumbers.Count)
                {
                    for (int r = 0; r < 1; r++)
                    {
                        resultList.Add(firstListNumbers[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }

        static void RemovingLargerLengthDigits(List<string> firstListNumbers, List<string> secondListNumbers, int minLenghtOfDigits)
        {
            for (int i = 0; i < firstListNumbers.Count; i++)
            {
                if (!firstListNumbers[i].Contains("-"))
                {
                    if (firstListNumbers[i].Length > minLenghtOfDigits)
                    {
                        firstListNumbers.Remove(firstListNumbers[i]);
                        i--;
                    }
                }
                else
                {
                    if (firstListNumbers[i].Length - 1 > minLenghtOfDigits)
                    {
                        firstListNumbers.Remove(firstListNumbers[i]);
                        i--;
                    }
                }
            }
            for (int i = 0; i < secondListNumbers.Count; i++)
            {
                if (!secondListNumbers[i].Contains("-"))
                {
                    if (secondListNumbers[i].Length > minLenghtOfDigits)
                    {
                        secondListNumbers.Remove(secondListNumbers[i]);
                        i--;
                    }
                }
                else
                {
                    if (secondListNumbers[i].Length - 1 > minLenghtOfDigits)
                    {
                        secondListNumbers.Remove(secondListNumbers[i]);
                        i--;
                    }
                }
            }
        }

        static int GetMinLengthOfEachDigit(List<string> firstListNumbers, List<string> secondListNumbers, int minLenghtOfDigits)
        {
            foreach (var num in firstListNumbers)
            {
                if (!num.Contains("-"))
                {
                    if (num.Length < minLenghtOfDigits)
                    {
                        minLenghtOfDigits = num.Length;
                    }
                }
                else
                {
                    if (num.Length - 1 < minLenghtOfDigits)
                    {
                        minLenghtOfDigits = num.Length - 1;
                    }
                }
            }

            foreach (var num in secondListNumbers)
            {
                if (!num.Contains("-"))
                {
                    if (num.Length < minLenghtOfDigits)
                    {
                        minLenghtOfDigits = num.Length;
                    }
                }
                else
                {
                    if (num.Length - 1 < minLenghtOfDigits)
                    {
                        minLenghtOfDigits = num.Length - 1;
                    }
                }
            }

            return minLenghtOfDigits;
        }
    }
}
