namespace _01L.Remove_Negatives_and_Reverse
{
    using System;
    using System.Linq;

    class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }

            if (numbers.Count != 0)
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
