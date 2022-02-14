using System;
using System.Collections.Generic;
using System.Linq;

namespace Uri1110
{
    public static class Uri
    {
        public static void Main()
        {
            while (true)
            {
                var queue = new Queue<int>();

                var discarded = new Queue<int>();

                var total = int.Parse(Console.ReadLine());

                if (total == 0)
                    break;

                for (var i = 1; i <= total; i++)
                    queue.Enqueue(i);

                while (queue.Count != 1)
                {
                    discarded.Enqueue(queue.Dequeue());
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine(discarded.Any()
                    ? $"Discarded cards: {string.Join(", ", discarded)}"
                    : "Discarded cards:");

                Console.WriteLine($"Remaining card: {queue.Dequeue()}");
            }
        }
    }
}