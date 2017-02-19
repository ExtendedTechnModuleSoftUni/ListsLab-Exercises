namespace _02ME.Integer_Insertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class IntegerInsertion
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            int digit = 0;

            while (command != "end")
            {
                int num = int.Parse(command);

                digit = GetFirstDigit(num);
                numbers = InserDigitInList(numbers, digit, num);

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static int GetFirstDigit(int num)
        {
            int digit = 0;

            while (num > 0)
            {
                int prev = num % 10;
                digit = prev;
                num /= 10;
            }

            return digit;
        }

        private static List<int> InserDigitInList(List<int> numbers, int digit, int num)
        {
            numbers.Insert(digit, num);

            return numbers;
        }
    }
}
