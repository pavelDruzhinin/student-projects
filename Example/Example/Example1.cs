using System;

namespace Example
{
    class XXX
    {
        static public void Main()
        {
            int x;
            for (x = 0; x < 3; x++)
            {
                const int y = -1;
                Console.WriteLine("y равен {0}", y);
            }

            int iv = 100;
            double dv = 100.0;
            float fv = 100;


            iv = iv / 3;
            dv = dv / 3;
            fv = fv / 3;
            Console.WriteLine("Значение iv = {0}", iv);
            Console.WriteLine("Значение dv = {0}", dv);
            Console.WriteLine("Значение fv = {0}", fv);


            const double radius = 10.0;

            const double area = radius * radius * Math.PI;
            Console.WriteLine();
            Console.WriteLine("Площадь круга = {0}", area);
            Console.WriteLine();

            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine("Текущее значение: {0}", i);
            }
            Console.WriteLine("Все!");

            Console.WriteLine();
            Console.WriteLine("Напоследок вычислим сколько ты получишь денег при вложении");
            Console.WriteLine("Введите первоначальную стоимость\a");
            decimal da = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите норму прибыли\a\a");
            decimal dr = Convert.ToDecimal(Console.ReadLine());
            da = FutVal(da, dr);
            Console.WriteLine("Столько ты заберешь {0}", da);

            Console.ReadLine();
        }
        static public decimal FutVal(decimal amount, decimal rate_of_return)
        {
            int i;
            const int years = 10;
            Console.WriteLine("Первоначальное значение = {0}", amount);
            Console.WriteLine("Норма прибыли составляет: {0}", rate_of_return);
            Console.WriteLine("В течение {0} лет", years);

            for (i = 0; i < years; i++)
            {
                amount += (amount * rate_of_return);
            }
            return amount;
        }
    }
}