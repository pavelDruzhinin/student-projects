using System;
using System.IO;

namespace FileMadeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iA = { 2, 3, 4 };
            double[] dA = { 2.3, 4.5, 2.1 };
            var iRA = new int[3];
            var dRA = new double[3];

            var fs = new FileStream("Bomb", FileMode.Create, FileAccess.Write);
            var bW = new BinaryWriter(fs);
            foreach (int t in iA)
            {
                bW.Write(t);
            }
            foreach (double t in dA)
            {
                bW.Write(t);
            }
            bW.Close();
            fs.Close();

            if (!File.Exists("Bomb")) 
                return;

            var fs1 = new FileStream("Bomb", FileMode.Open, FileAccess.Read);
                
            Console.WriteLine("Файл содержит следующие данные");
                
            var bR = new BinaryReader(fs1);
               
            Console.WriteLine();                
            Console.WriteLine("1 массив");
            Console.WriteLine();                
                
            for (var i = 0; i < iRA.Length; i++)
            {
                iRA[i] = bR.ReadInt32();
                Console.WriteLine("{0} член равен {1}",i,iRA[i]);
            }
            Console.WriteLine();                
            Console.WriteLine("2 массив");
            Console.WriteLine();                

            for (var i = 0; i < dRA.Length; i++)
            {
                dRA[i] = bR.ReadDouble();
                Console.WriteLine("{0} член равен {1}", i, dRA[i]);

            }
            bR.Close();
            fs1.Close();
              
            Console.WriteLine("Запись прошла успешно");
            Console.WriteLine("Нажмите Enter для продолжения...");
            Console.ReadLine();
        }
    }
}
