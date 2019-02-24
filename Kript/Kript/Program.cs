using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Kript
{
    class Program
    {
        static void Main()
        {
            char[] s1 = {'М','а','м','а',' ','м','ы','л','а',' ','р','а','м','у',' '};
            var  s2 = new char[15];

            var fsW = new FileStream("Kript.txt", FileMode.Create, FileAccess.Write);

            var bW = new BinaryWriter(fsW);
            foreach (char t in s1)
            {
                bW.Write(t);
            }
            bW.Close();
            fsW.Close();

            var fsR = new FileStream("Kript.txt", FileMode.Open, FileAccess.Read);

            var Re = new BinaryReader(fsR);
            for (var i = 0; i < s2.Length; i++)
            {
                s2[i] = Re.ReadChar();

            }
            Re.Close();
            fsR.Close();
            const int n = 5;
            const int k1 = 15 / n;
            for (var k = 0; k < k1; k++)
            {
                s2[0 + n * k] = s2[4 + n * k];
                s2[1 + n * k] = s2[3 + n * k];
                s2[2 + n * k] = s2[0 + n * k];
                s2[3 + n * k] = s2[2 + n * k];
                s2[4 + n * k] = s2[1 + n * k];
            }

            Console.WriteLine("Cтрока");
            string str = s2.Aggregate("", (current, t) => current + t.ToString(CultureInfo.InvariantCulture));

            Console.WriteLine(str);
            Console.WriteLine("Нажмите Enter для выхода");
            Console.ReadLine();
            
        }
    }
}
