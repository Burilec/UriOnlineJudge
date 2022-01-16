using System;

namespace Uri1026
{
    public static class Uri
    {
        public static void Main()
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                var strings = line.Split(' ');

                var a = long.Parse(strings[0]);

                var b = long.Parse(strings[1]);

                Console.WriteLine(a ^ b);
            }
        }
    }
}