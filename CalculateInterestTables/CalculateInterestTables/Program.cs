using System;

namespace CalculateInterestTables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int nMaximumInterest = 50;
            decimal mPrincipal;
            while (true)
            {
                Console.Write("Введите размер вклада: ");
                string sPrincipal = Console.ReadLine();
                mPrincipal = Convert.ToDecimal(sPrincipal);

                if (mPrincipal >= 0)
                {
                    break;
                }
                //Если вклад отрицателен ....
                Console.WriteLine("Вклад не может быть отрицательным");
                Console.WriteLine("Повторите ввод");
                Console.WriteLine();
            }
            decimal mInterest;
            while (true)
            {
                Console.Write("Введите процентную ставку: ");
                string sInterest = Console.ReadLine();
                mInterest = Convert.ToDecimal(sInterest);
                if (mInterest >= 0 && mInterest <= nMaximumInterest)
                {
                    break;
                }
                Console.WriteLine("Процентная ставка не может быть отрицательным" +
                    "или превышать" + nMaximumInterest);
                Console.WriteLine("Повторите ввод");
                Console.WriteLine();
            }
            Console.Write("Введите количество лет: ");
            string sDuration = Console.ReadLine();
            decimal nDuration = Convert.ToInt32(sDuration);

            //Выводим данные
            Console.WriteLine();
            Console.WriteLine("Вклад = " + mPrincipal);
            Console.WriteLine("Проценты = " + mInterest + "%");
            Console.WriteLine("Срок = " + nDuration + " лет");
            Console.WriteLine();

            //Цикл по указанному количеству лет
            int nYear = 1;
            while (nYear <= nDuration)
            {
                //Вычисление вклада с начисленными процентами
                decimal mInterestPaid = mPrincipal * (mInterest / 100);

                //Вычисляем новое значение вклада
                mPrincipal = mPrincipal + mInterestPaid;

                //Вычисляем величину до копеек
                mPrincipal = decimal.Round(mPrincipal, 2);

                //Выводим результат
                Console.WriteLine(nYear + " - " + mPrincipal);

                //Переходим к следующему году
                nYear = nYear + 1;
            }
            Console.WriteLine("Нажмите <Enter> для завершения программы");
            Console.Read();
        }
    }
}
