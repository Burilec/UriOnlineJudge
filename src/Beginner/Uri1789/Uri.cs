using System;
using System.Linq;

namespace Uri1789
{
    public static class Uri
    {
        public static void Main()
        {
            while (Console.ReadLine() != null)
            {
                var max = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).Max();

                if (max >= 20)
                    Console.WriteLine(3);
                else if (max >= 10)
                    Console.WriteLine(2);
                else
                    Console.WriteLine(1);
            }
        }
    }
}