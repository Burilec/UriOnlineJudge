using System;
using System.Collections.Generic;

namespace Uri2060
{
    public static class Uri
    {
        public static void Main()
        {
            var _ = Console.ReadLine();

            var dictionary = new Dictionary<int, int>()
            {
                {2, 0},
                {3, 0},
                {4, 0},
                {5, 0},
            };

            var convertAll = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            foreach (var i in convertAll)
            {
                if (i % 2 == 0)
                    dictionary[2]++;
                if (i % 3 == 0)
                    dictionary[3]++;
                if (i % 4 == 0)
                    dictionary[4]++;
                if (i % 5 == 0)
                    dictionary[5]++;
            }

            foreach (var i in dictionary)
                Console.WriteLine($"{i.Value} Multiplo(s) de {i.Key}");
        }
    }
}