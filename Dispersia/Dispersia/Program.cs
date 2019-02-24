using System;

namespace Dispersia
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var twodarr = new double[2, 3];
            for (var i = 0; i < twodarr.GetLength(0); i++)
            {
                for (var j = 0; j < twodarr.GetLength(1); j++)
                {
                    twodarr[i, j] = rand.NextDouble();
                }
            }
            var disp = MyClass.ArrDisp(twodarr);
            Console.WriteLine("Disp = {0}", disp);
            Console.ReadLine();
        }
    }
}
