namespace Massiv
{
    public class Matr
    {
        public int Rows { get; private set; }

        public int Cols { get; private set; }

        public int Count { get; private set; }

        public Matr()
        {
            Rows = 0;
            Cols = 0;
            Count = 0;
        }

        public Matr(int r, int c)
        {
            Rows = r;
            Cols = c;
            Count = r * c;
        }

        public Matr(int rc)
        {
            Rows = Cols = rc;
            Count = rc * rc;
        }
    }
}
