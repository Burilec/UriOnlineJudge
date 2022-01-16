using System;

namespace Uri1001
{
    public static class Uri
    {
        public static void Main()
        {
            var readLine = Console.ReadLine();
            var line = Console.ReadLine();
            var a = int.Parse(readLine);
            var b = int.Parse(line);


            Console.WriteLine("X = " + (a + b));
        }
    }
}