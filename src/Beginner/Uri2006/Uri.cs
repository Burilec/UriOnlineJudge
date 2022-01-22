using System;
using System.Linq;

namespace Uri2006
{
    public static class Uri
    {
        public static void Main()
        {
            var target = int.Parse(Console.ReadLine());

            Console.WriteLine(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).Count(i => i == target));
        }
    }
}