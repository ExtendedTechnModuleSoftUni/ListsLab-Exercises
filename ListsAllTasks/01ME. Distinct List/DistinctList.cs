namespace _01ME.Distinct_List
{
    using System;
    using System.Linq;

    class DistinctList
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int r = 1 + i; r < numbers.Count; r++)
                {
                    if (numbers[i] == numbers[r])
                    {
                        numbers.RemoveAt(r);
                        r--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
