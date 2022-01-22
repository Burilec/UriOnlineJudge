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

                Console.WriteLine(long.Parse(strings[0]) ^ long.Parse(strings[1]));
            }
        }
    }
}