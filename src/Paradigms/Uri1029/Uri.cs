using System;

namespace Uri1029
{
    public static class Uri
    {
        public static void Main()
        {
            var total = int.Parse(Console.ReadLine());

            for (var i = 0; i < total; i++)
            {
                var value = int.Parse(Console.ReadLine());

                (var result, var count) = Fib(value);

                Console.WriteLine($"fib({value}) = {count - 1} calls = {result}");
            }
        }

        private static (int result, int count) Fib(int value)
        {
            switch (value)
            {
                case 0:
                    return (0, 1);
                case 1:
                    return (1, 1);
            }

            (var result1, var count1) = Fib(value - 1);
            (var result2, var count2) = Fib(value - 2);
            return (result1 + result2, count1 + count2 + 1);
        }
    }
}