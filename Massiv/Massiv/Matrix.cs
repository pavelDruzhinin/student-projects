using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Massiv
{
    public class Matrix
    {
        private List<List<int>> lstMass;
        public List<List<int>> LstMass
        {
            get { return lstMass ?? (lstMass = new List<List<int>>()); }
            set { lstMass = value; }
        }

        public Matrix()
        {
            lstMass = new List<List<int>>();
        }

        public int FindMaxCols()
        {
            var maxCol = 0;
            var diff = 0;
            var i = 0;
            foreach (var item in lstMass)
            {
                var different = item.Max() - item.Min();
                if (diff < different) { diff = different; maxCol = i; }
                i++;
            }
            return maxCol;
        }

        public void ShowMas()
        {
            Console.WriteLine("Выводим массив:");
            foreach (var item in lstMass)
            {
                foreach (var i in item)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------");
        }

        public void ShowMaxCols(int maxCols)
        {
            Console.WriteLine("Строка с максимальной разницей между");
            Console.WriteLine("ее максимальными и минимальными значениями:");
            foreach (var i in lstMass[maxCols])
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------");
        }

        public void ReadFileToMas(string filepath)
        {
            Console.WriteLine("Считываем файл " + filepath);
            var fsRead = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            var stReader = new StreamReader(fsRead);

            FillStreamToMass(stReader);

            Console.WriteLine("Файл успешно загружен:");
            Console.WriteLine("-----------------------");
        }

        protected void FillStreamToMass(StreamReader stReader)
        {
            var lst = new List<int>();
            string All;
            while ((All = stReader.ReadLine()) != null)
            {
                lst.AddRange(from ch in All 
                             where ch != ' ' 
                             select ch.ToString(CultureInfo.InvariantCulture) 
                             into str select Convert.ToInt32(str));

                lstMass.Add(lst);
                lst = new List<int>();
            }
        }

        public void MassToFile(string filepath, int maxCols)
        {
            Console.WriteLine("Запись в файл " + filepath);
            var f_out = new FileStream(filepath, FileMode.Create, FileAccess.Write);

            var strWriter = new StreamWriter(f_out);

            foreach (var i in lstMass[maxCols])
            {
                var str = i + " ";
                strWriter.Write(str);
            }
            strWriter.Close();
            Console.WriteLine("---------------");
        }
    }
}
