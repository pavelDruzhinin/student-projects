using System;

namespace Dispersia
{
    class MyClass
    {
        static public double ArrAver(double[,] ar)
        {
            double Sum = 0;
            Console.WriteLine("Вычисляем сумму");
            for (var i = 0; i < ar.GetLength(0); i++)
            {
                Console.WriteLine();
                for (var j = 0; j < ar.GetLength(1); j++)
                {
                    Sum = Sum + ar[i, j];
                    Console.Write(" ");
                    Console.Write(Sum);
                }
            }
            return Sum / (ar.Length);
        }
        static public double ArrDisp(double[,] ar)
        {
            double dSum = 0;
            var Aver = ArrAver(ar);
            Console.WriteLine("Вычисляем дисперсию");
            for (var i = 0; i < ar.GetLength(0); i++)
            {
                Console.WriteLine();
                for (var j = 0; j < ar.GetLength(1); j++)
                {
                    dSum = dSum + (ar[i, j] - Aver) * (ar[i, j] - Aver);
                    Console.Write(" ");
                    Console.Write(dSum);
                }
            }
            return Math.Sqrt(dSum / (ar.Length));

        }
    }
}
