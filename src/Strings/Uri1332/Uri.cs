using System;

namespace Uri1332
{
    public static class Uri
    {
        public static void Main()
        {
            var total = int.Parse(Console.ReadLine());

            for (var i = 0; i < total; i++)
            {
                var value = Console.ReadLine();

                if (value.Length == 3)
                    Console.WriteLine(CheckOne(value) ? 1 : 2);
                else
                    Console.WriteLine(3);
            }
        }

        private static bool CheckOne(string value)
        {
            var one = 0;

            if (value[0] == 'o') one++;
            if (value[1] == 'n') one++;
            if (one == 2)
                return true;

            if (value[2] == 'e') one++;

            return one == 2;
        }
    }
}