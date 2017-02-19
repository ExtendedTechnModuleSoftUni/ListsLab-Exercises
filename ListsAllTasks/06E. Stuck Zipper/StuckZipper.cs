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
            int minLenghtOfDigits = int.MaxValue;

            foreach (var num in firstListNumbers)
            {
                int numLenght = num.Length;

                if (numLenght < minLenghtOfDigits)
                {
                    minLenghtOfDigits = numLenght;
                }
            }

        }
    }
}
