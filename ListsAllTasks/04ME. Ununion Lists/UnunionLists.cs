namespace _04ME.Ununion_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class UnunionLists
    {
        static void Main()
        {
            var primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var temporaryList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                primalList = CheckForEqualElements(primalList, temporaryList);

            }

            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }

        private static List<int> CheckForEqualElements(List<int> primalList, List<int> temporaryList)
        {
            var elementsForRemoving = new List<int>();

            for (int i = 0; i < primalList.Count; i++)
            {
                for (int r = 0; r < temporaryList.Count; r++)
                {
                    if (i >= 0 && primalList[i] == temporaryList[r])
                    {
                        primalList.RemoveAt(i);

                        elementsForRemoving.Add(temporaryList[r]);

                        i--;

                        if (i < -1)
                        {
                            i = 0;
                        }
                    }
                }
            }

            for (int q = 0; q < elementsForRemoving.Count; q++)
            {
                if (temporaryList.Contains(elementsForRemoving[q]))
                {
                    temporaryList.Remove(elementsForRemoving[q]);
                    q--;
                }
            }

            primalList = AddingLeftElements(primalList, temporaryList);

            return primalList;
        }

        private static List<int> AddingLeftElements(List<int> primalList, List<int> temporaryList)
        {
            foreach (var num in temporaryList)
            {
                primalList.Add(num);
            }

            return primalList;
        }
    }
}
