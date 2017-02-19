namespace _03ME.Camel_s_Back
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CamelsBack
    {
        static void Main()
        {
            var buildings = Console.ReadLine().Split(' ').ToList();
            int n = int.Parse(Console.ReadLine());
            int startIndex = 0;
            int len = buildings.Count;
            int rounds = 0;

            for (int i = 0; i < (len - n) / 2; i++)
            {
                buildings.RemoveAt(startIndex);
                buildings.RemoveAt(buildings.Count - 1);
                rounds++;
            }

            if (rounds > 0)
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", buildings)}");
            }
            else
            {
                Console.WriteLine($"already stable: {string.Join(" ", buildings)}");
            }
        }
    }
}
