namespace _07L.Count_Numbers
{
    using System;
    using System.Linq;

    class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] countExisting = new int[1001];

            foreach (var num in numbers)
            {
                countExisting[num]++;
            }

            for (int i = 0; i < countExisting.Length; i++)
            {
                if (countExisting[i] > 0)
                {
                    Console.WriteLine($"{i} -> {countExisting[i]}");
                }
            }
        }
    }
}
