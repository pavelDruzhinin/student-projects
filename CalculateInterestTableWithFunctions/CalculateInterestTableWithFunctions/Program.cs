using System;

namespace CalculateInterestTableWithFunctions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Раздел 1 - ввод данных, необходимых для создания таблицы
            decimal mPrincipal = 0;
            decimal mInterest = 0;
            decimal mDuration = 0;
            InputInterestData(ref mPrincipal, ref mInterest, ref mDuration);

            //Раздел 2 - проверка введенных данных путем
            //вывода их на экран
            Console.WriteLine();
            Console.WriteLine("Вклад = " + mPrincipal);
            Console.WriteLine("Процентная ставка =" + mInterest + "%");
            Console.WriteLine("Срок = " + mDuration + " лет");
            Console.WriteLine();

            //Раздел 3 - вывод таблицы вкладов по годам
            OutputInterestTable(mPrincipal, mInterest, mDuration);

            //Выход из программы
            Console.WriteLine("Нажмите <Enter> для выхода из программы");
            Console.Read();
        }
        //InputInterestData
        //клавиатурный ввод вклада, процентной ставки, срока для расчета таблицы
        //Эта функция реализует раздел 1, разбивая его на 3 части
        public static void InputInterestData(ref decimal mPrincipal, ref decimal mInterest, ref decimal mDuration)
        {
            //Получение вклада
            mPrincipal = InputPositiveDecimal("вклад");

            // Получение процентной ставки
            mInterest = InputPositiveDecimal("процентная ставка");

            //Получение срока
            mDuration = InputPositiveDecimal("срок");
        }
        //InputPositiveDecimal
        //возвращает положительное число типа decimal с клавиатуры
        public static decimal InputPositiveDecimal(string sPromt)
        {
            while (true)
            {
                //Приглашение для ввода
                Console.Write("Введите " + sPromt + " : ");

                //Получение значения типа decimal с клавиатуры
                string sInput = Console.ReadLine();
                decimal mValue = Convert.ToDecimal(sInput);

                //Выход из цикла при вводе корректного значения
                if (mValue >= 0)
                {
                    //Возврат введенного значения
                    return mValue;
                }
                Console.WriteLine(sPromt + " не может быть отрицательным");
                Console.WriteLine("Попробуйте еще раз");
                Console.WriteLine();
            }
        }
        //OutputInterestTable
        //выводит таблицу роста вклада
        //Реализация раздела 3 основной программы
        public static void OutputInterestTable(decimal mPrincipal, decimal mInterest, decimal mDuration)
        {
            for (int nYear = 0; nYear < mDuration; nYear++)
            {
                //Вычисление начисленных процениов
                decimal mInterestPaid = mPrincipal * (mInterest / 100);

                //Вычисление значения нового вклада добавляя к
                //основному начисленные проценты
                mPrincipal = mPrincipal + mInterestPaid;

                //Округление вклада до копеек
                mPrincipal = decimal.Round(mPrincipal, 2);

                //Вывод результата
                Console.WriteLine((nYear + 1) + " - " + mPrincipal);
            }
        }
    }
}
