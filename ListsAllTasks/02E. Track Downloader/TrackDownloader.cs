namespace _02E.Track_Downloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TrackDownloader
    {
        static void Main()
        {
            var blackList = Console.ReadLine().Split(' ').ToList();
            var result = new List<string>();
            string fileName = Console.ReadLine();
            bool isStringExist = false;

            while (fileName != "end")
            {
                for (int i = 0; i < blackList.Count; i++)
                {
                    if (fileName.Contains(blackList[i]))
                    {
                        isStringExist = true;
                        break;
                    }
                }

                if (!isStringExist)
                {
                    result.Add(fileName);
                }

                isStringExist = false;

                fileName = Console.ReadLine();
            }

            result.Sort();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
