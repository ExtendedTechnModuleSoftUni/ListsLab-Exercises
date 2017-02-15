namespace _02L.Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AppendLists
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Trim().Split('|').ToList();
            var result = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                result.AddRange(numbers[numbers.Count - 1 - i].Split(' '));
            }

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == "")
                {
                    result.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
