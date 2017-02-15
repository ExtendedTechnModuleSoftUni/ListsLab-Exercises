namespace _06L.Square_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SquareNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    result.Add(numbers[i]);
                }
            }

            result.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
