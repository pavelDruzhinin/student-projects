using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Result of first method = {0}", FirstResult());
            Console.WriteLine("Result of second method = {0}", SecondResult());
            Console.WriteLine("Result of third method = {0}", ThirdResult());
            Console.WriteLine("Result of four method = {0}", FourResult());
            Console.WriteLine("Result of five method = {0}", FiveResult());
        }

        //60
        public static int FirstResult()
        {
            var x1 = 6;
            var x2 = 8;

            var y1 = 15;
            var y2 = 25 + x2;

            return (x1 + y2) / x2 * y1;
        }

        //2
        public static int SecondResult()
        {
            var x1 = 46;
            //var x3 = 65+++;
            var x3 = 65;

            var y5 = x1++;
            var y8 = --x3;

            return x1 / y5 + y8 / x1;
        }

        //37
        public static int ThirdResult()
        {
            var xyz = 46;
            //var xyz += xyz + -15;

            xyz += xyz + -15;
            var y = 19;
            var z = y-- - xyz;

            return xyz + y + z;
        }

        //0
        public static decimal FourResult()
        {
            var sum = 18;

            for (var i = 15; i >= 0; i--)
            {
                sum *= i;
            }

            return sum;
        }

        //15
        public static decimal FiveResult()
        {
            var result = 1;
            var x = 4;
            var y = 3;

            //for (var i = 1; i < x; i--; y++)
            for (var i = 1; i < x; i++, y++)
            {
                result = y * i;
            }

            return result;
        }
    }
}
