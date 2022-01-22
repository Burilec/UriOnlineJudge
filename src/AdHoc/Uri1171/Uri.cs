using System;
using System.Collections.Generic;
using System.Linq;

namespace Uri1171
{
    public static class Uri
    {
        public static void Main()
        {
            var total = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < total; i++)
            {
                var value = int.Parse(Console.ReadLine());

                if (dictionary.ContainsKey(value))
                    dictionary[value]++;
                else
                    dictionary.Add(value, 1);
            }

            foreach (var keyValuePair in dictionary.OrderBy(pair => pair.Key))
                Console.WriteLine($"{keyValuePair.Key} aparece {keyValuePair.Value} vez(es)");
        }
    }
}