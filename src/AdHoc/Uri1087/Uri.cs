using System;

namespace Uri1087
{
    public static class Uri
    {
        public static void Main()
        {
            while (true)
            {
                var convertAll = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                if (convertAll[0] == 0)
                    return;

                var queenX = convertAll[0];
                var queenY = convertAll[1];
                var placeX = convertAll[2];
                var placeY = convertAll[3];

                if (queenX == placeX && placeY == queenY)
                    Console.WriteLine(0);
                else if (queenY + queenX == placeY + placeX || Math.Abs(queenX - placeX) == Math.Abs(queenY - placeY) || placeY == queenY || placeX == queenX)
                    Console.WriteLine(1);
                else
                    Console.WriteLine(2);
            }
        }
    }
}