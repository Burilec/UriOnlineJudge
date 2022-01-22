using System;

namespace Uri1865
{
    public static class Uri
    {
        public static void Main()
        {
            var total = int.Parse(Console.ReadLine());

            for (var i = 0; i < total; i++)
                Console.WriteLine(Console.ReadLine().Split(' ')[0] == "Thor" ? "Y" : "N");
        }
    }
}