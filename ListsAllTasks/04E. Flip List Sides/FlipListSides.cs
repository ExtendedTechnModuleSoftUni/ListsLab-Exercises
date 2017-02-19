namespace _04E.Flip_List_Sides
{
    using System;
    using System.Linq;

    class FlipListSides
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < (numbers.Count / 2) - 1; i++)
            {
                string prev = numbers[i + 1];
                numbers[i + 1] = numbers[numbers.Count - 2 - i];
                numbers[numbers.Count - 2 - i] = prev;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
