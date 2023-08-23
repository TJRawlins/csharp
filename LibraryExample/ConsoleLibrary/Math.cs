namespace ConsoleLibrary
{
    public class Math
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        public static int Mult(int x, int y)
        {
            return x * y;
        }
        public static int Div(int x, int y)
        {
            return x / y;
        }
        public static double Inverse(double x)
        {
            if(x == 0) throw new DivideByZeroException("x cannot be zeor");
            return  1 / x;
        }
        public static int Modulo(int x, int y)
        {
            return x - ((x / y) * y);
        }
        public static int Power(int x, int y)
        {
            var pow = 1;
            for (int i = 1; i <= y; i++)
            {
                pow *= x;
            }
            return pow;
        }
    }
}