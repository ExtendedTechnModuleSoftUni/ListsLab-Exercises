namespace _05E.Tear_List_in_Half
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TearListInHalf
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int len = numbers.Count;
            var rightDigits = new List<int>();
            var resultList = new List<int>();

            rightDigits = GetRightSeparatedDigits(numbers, len, rightDigits);
            numbers = RemoveRightDigits(numbers, len);
            resultList = InsertDigits(numbers, rightDigits, len);

            Console.WriteLine(string.Join(" ", resultList));
        }

        private static List<int> InsertDigits(List<int> numbers, List<int> rightDigits, int len)
        {
            int start = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                rightDigits.Insert(start, numbers[i]);
                start += 3;
            }

            return rightDigits;
        }

        private static List<int> RemoveRightDigits(List<int> numbers, int len)
        {
            for (int i = 0; i < len / 2; i++)
            {
                numbers.RemoveAt(len / 2);
            }

            return numbers;
        }

        private static List<int> GetRightSeparatedDigits(List<int> numbers, int len, List<int> rightDigits)
        {
            for (int i = 0; i < len / 2; i++)
            {
                rightDigits.Add(numbers[len / 2 + i] / 10);
                rightDigits.Add(numbers[len / 2 + i] % 10);
            }

            return rightDigits;
        }
    }
}
