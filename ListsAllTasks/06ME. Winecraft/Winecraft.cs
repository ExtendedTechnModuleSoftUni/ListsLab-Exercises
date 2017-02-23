namespace _06ME.Winecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Winecraft
    {
        static void Main()
        {
            var grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int growthDays = int.Parse(Console.ReadLine());

            while (grapes.Count > growthDays)
            {
                for (int i = 0; i < growthDays; i++)
                {
                    IncreasingGrapes(grapes);

                    for (int q = 0; q < grapes.Count; q++)
                    {
                        ProcessGrapes(grapes, q);
                    }
                }

                RemoveSmallerGrapes(grapes, growthDays);

            }

            Console.WriteLine(string.Join(" ", grapes));
        }

        private static void RemoveSmallerGrapes(List<int> grapes, int growthDays)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] <= growthDays)
                {
                    grapes.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void ProcessGrapes(List<int> grapes, int q)
        {
            if (q != 0 && q != grapes.Count - 1)
            {
                int left = q - 1;
                int right = q + 1;
                var isGreaterThanLeft = grapes[q] > grapes[left];
                var isGreaterThanRight = grapes[q] > grapes[right];

                if (isGreaterThanLeft && isGreaterThanRight)
                {
                    grapes[q]--;

                    if (grapes[left] > 0)
                    {
                        grapes[q]++;
                        grapes[left] = Math.Max(grapes[left] - 2, 0);
                    }
                    if (grapes[right] > 0)
                    {
                        grapes[q]++;
                        grapes[right] = Math.Max(grapes[right] - 2, 0);
                    }
                }
            }
        }

        private static void IncreasingGrapes(List<int> grapes)
        {
            for (int r = 0; r < grapes.Count; r++)
            {
                grapes[r]++;
            }
        }
    }
}
