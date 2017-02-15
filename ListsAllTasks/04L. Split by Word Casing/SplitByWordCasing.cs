namespace _04L.Split_by_Word_Casing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SplitByWordCasing
    {
        public static void Main()
        {
            char[] separators = new char[]
            {
                ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' '
            };

            var text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            LowerCaseWords(text);
            MixedCaseWords(text);
            UpperCaseWords(text);
        }

        private static void UpperCaseWords(List<string> text)
        {
            List<string> upperCase = new List<string>();
            var symbols = new List<char>();
            int counter = 0;

            for (int i = 0; i < text.Count; i++)
            {
                symbols.AddRange(text[i]);

                for (int r = 0; r < symbols.Count; r++)
                {
                    if (char.IsUpper(symbols[r]))
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter == symbols.Count)
                {
                    upperCase.Add(text[i]);
                }

                symbols.Clear();
                counter = 0;
            }

            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }

        private static void MixedCaseWords(List<string> text)
        {
            List<string> mixedCase = new List<string>();
            var symbols = new List<char>();
            int lowerSymbolCounter = 0;
            int upperCaseCounter = 0;

            for (int i = 0; i < text.Count; i++)
            {
                symbols.AddRange(text[i]);

                for (int r = 0; r < symbols.Count; r++)
                {
                    if (char.IsLower(symbols[r]))
                    {
                        lowerSymbolCounter++;
                    }

                    else if (char.IsUpper(symbols[r]))
                    {
                        upperCaseCounter++;
                    }
                }

                if (lowerSymbolCounter != symbols.Count && upperCaseCounter != symbols.Count)
                {
                    mixedCase.Add(text[i]);
                }

                symbols.Clear();
                lowerSymbolCounter = 0;
                upperCaseCounter = 0;
            }

            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
        }

        private static void LowerCaseWords(List<string> text)
        {
            List<string> lowerCase = new List<string>();
            var symbols = new List<char>();
            int counter = 0;

            for (int i = 0; i < text.Count; i++)
            {
                symbols.AddRange(text[i]);

                for (int r = 0; r < symbols.Count; r++)
                {
                    if (char.IsLower(symbols[r]))
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter == symbols.Count)
                {
                    lowerCase.Add(text[i]);
                }

                symbols.Clear();
                counter = 0;
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
        }
    }
}
