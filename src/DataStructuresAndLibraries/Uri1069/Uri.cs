using System;
using System.Linq;

namespace Uri1069
{
    public static class Uri
    {
        public static void Main()
        {
            var total = int.Parse(Console.ReadLine());

            for (var i = 0; i < total; i++)
            {
                var line = Console.ReadLine();

                var enumerable = line.Where(c => c == '<' || c == '>');

                var stack = 0;
                var count = 0;

                foreach (var c in enumerable)
                {
                    if (c == '<')
                        stack++;
                    else
                    {
                        stack--;
                        if (stack != -1)
                            count++;
                    }

                    if (stack == -1)
                        stack = 0;
                }

                Console.WriteLine(count);
            }
        }
    }
}