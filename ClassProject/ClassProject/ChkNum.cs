namespace ClassProject
{
    class ChkNum
    {
        public bool IsPrime(int x)
        {
            if (x <= 1) return false;
            for (var i = 2; i <= x / i; i++)
            {
                if ((x % i) == 0) return false;
            }
            return true;
        }
        public int LeastComFactor(int a, int b)
        {
            if (IsPrime(a) || IsPrime(b))
                return 1;

            var max = a < b ? a : b;
            for (var i = 2; i <= max / 2; i++)
            {
                if (((a % i) == 0) && ((b % i) == 0))
                    return i;
            }
            return 1;
        }
    }
}