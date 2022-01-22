using System;
using System.Linq;

namespace Uri1933
{
    public static class Uri
    {
        public static void Main()
            => Console.WriteLine(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).Max());
    }
}
