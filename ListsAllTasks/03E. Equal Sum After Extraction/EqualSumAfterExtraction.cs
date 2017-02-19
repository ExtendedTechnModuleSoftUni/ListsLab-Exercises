namespace _03E.Equal_Sum_After_Extraction
{
    using System;
    using System.Linq;

    class EqualSumAfterExtraction
    {
        static void Main()
        {
            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < secondList.Count; i++)
            {
                for (int r = 0; r < firstList.Count; r++)
                {
                    if (secondList[i] == firstList[r])
                    {
                        secondList.Remove(secondList[i]);
                        i--;
                        break;
                    }
                }
            }

            if (firstList.Sum() == secondList.Sum())
            {
                Console.WriteLine($"Yes. Sum: {firstList.Sum()}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(firstList.Sum() - secondList.Sum())}");
            }
        }
    }
}
