using System;

namespace ClassProject
{
    class Program
    {
        static void Main()
        {
            var ob = new ChkNum();
            for (var i = 2; i < 10; i++)
            {
                Console.WriteLine(ob.IsPrime(i) ? "{0} простое число" : "{0} не простое число", i);
            }
            const int a = 7;
            const int b = 77;
            Console.WriteLine("Наименьший общий множитель чисел {0} и {1} равен {2}", a, b, ob.LeastComFactor(a, b));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}