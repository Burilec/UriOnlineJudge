using System;

namespace Uri1170
{
    public static class Uri
    {
        public static void Main()
        {
            var total = int.Parse(Console.ReadLine());

            for (var i = 0; i < total; i++)
            {
                var value = double.Parse(Console.ReadLine());

                var count = 0;

                while (value > 1)
                {
                    value /= 2;
                    count++;
                }

                Console.WriteLine($"{count} dias");
            }
        }
    }
}