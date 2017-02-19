namespace _01E.RemoveOddPositions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RemoveOddPositions
    {
        static void Main()
        {
            List<string> textLine = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < textLine.Count; i += 2)
            {
                textLine.RemoveAt(i);
                i--;
            }

            Console.WriteLine(string.Join("", textLine));
        }
    }
}
