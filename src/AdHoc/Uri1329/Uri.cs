using System;
using System.Linq;

namespace Uri1329
{
    public static class Uri
    {
        public static void Main()
        {
            while (true)
            {
                if (int.Parse(Console.ReadLine()) == 0)
                    return;

                var convertAll = Console.ReadLine().Split(' ').Where(s => !string.IsNullOrEmpty(s)).Select(int.Parse);

                var mary = 0;
                var john = 0;

                foreach (var i in convertAll)
                    if (i == 0)
                        mary++;
                    else
                        john++;

                Console.WriteLine($"Mary won {mary} times and John won {john} times");
            }
        }
    }
}