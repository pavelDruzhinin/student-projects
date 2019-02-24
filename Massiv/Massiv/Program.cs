using System;

namespace Massiv
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Программа для вывода строки двумерного массива с максимальной разницей");
            Console.WriteLine("между максимальными и минимальными элементами");

            var ms = new Matrix();
            ms.ReadFileToMas("input.txt");
            ms.ShowMas();
            var maxcols = ms.FindMaxCols();
            ms.ShowMaxCols(maxcols);
            ms.MassToFile("output.txt", maxcols);
        }
    }
}
