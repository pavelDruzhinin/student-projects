using System;
using System.Linq;

namespace AverageStudentGPA
{
    public class Program
    {
        static void Main()
        {
            //Вводим количество студентов
            Console.Write("Введите количество студентов: ");
            var s = Console.ReadLine();
            var nNumbersOfStudents = Convert.ToInt32(s);

            //Обьявляем массив ссылок
            var students = new Student[nNumbersOfStudents];

            //Заполняем массив
            for (var i = 0; i < students.Length; i++)
            {
                Console.Write("Введите имя студента №" + (i + 1) + ": ");
                var sName = Console.ReadLine();

                //Срений балл
                Console.Write("Введите средний балл студента = ");
                var sAvg = Console.ReadLine();
                var dGPA = Convert.ToDouble(sAvg);

                //Создаем обьект на основе введенной информации
                var thisStudent = new Student { sName = sName, dGPA = dGPA };

                //Добавляем созданный обьект в массив
                students[i] = thisStudent;
            }
            //Считаем сумму
            var dSum = students.Sum(t => t.dGPA);
            var dAverage = dSum / students.Length;
            //Выводим результаты
            Console.WriteLine();
            Console.WriteLine("Средняя успеваемость по " + students.Length + " студентам = " + dAverage);
            Console.WriteLine("Нажмите <Enter> для выхода из программы");
            Console.Read();
        }
    }
}
