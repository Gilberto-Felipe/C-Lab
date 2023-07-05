namespace DemoUnitTestLibrary
{
    public static class Calculus
    {
        public static double Sumar(double a, double b)
        {
           return a + b;
        }

        public static double Restar(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public static double Dividir(double a, double b)
        {
            double output = 0;

            if (b != 0)
            {
                output = a / b;
            }

            return output;
        }
    }
}
