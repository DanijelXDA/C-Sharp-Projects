using System;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite koeficijent a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Unesite koeficijent b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Unesite koeficijent c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(); // NOVI RED

            if ( diskriminanta(a, b, c) < 0)
                Console.WriteLine("Resenja su konjugovano kompleksna!");
            else if (diskriminanta(a, b, c) == 0)
                Console.WriteLine("Resenja su realna i jednaka: X = {0}", X(a, b, c));
            else
                Console.WriteLine("Resenja su realna i razlicita: X1 = {0}, X2 = {1}", X1(a, b, c), X2(a, b, c));

            Console.ReadKey();
        }

        public static double diskriminanta(double a, double b, double c)
        {
            return ((b * b) - 4 * a * c);
        }

        public static double X(double a, double b, double c)
        {
            return (-b / (2.00 * a));
        }

        public static double X1(double a, double b, double c)
        {
            return ( (-b + Math.Sqrt(diskriminanta(a, b, c))) / (2.00 * a) );
        }

        public static double X2(double a, double b, double c)
        {
            return ((-b - Math.Sqrt(diskriminanta(a, b, c))) / (2.00 * a));
        }
    }
}
