using System;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite koeficijent a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Unesite koeficijent b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Unesite koeficijent c: ");
            double c = double.Parse(Console.ReadLine());

            double dis = (b * b) - 4.0 * a * c;

            if (dis > 0)    // Ako je dis > 0
            {               // Resenja su realna i razlicita
                double x1 = (-b + Math.Sqrt(dis)) / (2.0 * a); // X1
                double x2 = (-b - Math.Sqrt(dis)) / (2.0 * a); // X2

                Console.WriteLine(); // NOVI RED
                Console.WriteLine("Resenje su realna i razlicita: ");
                Console.Write("X1 = {0}, X2 = {1}", x1, x2);
            }
            else if (dis == 0) // Ako je dis = 0
            {                   // Resenje je jedinstveno i realno
                double x = -b / (2.0 * a); // X1 = X2 = X

                Console.WriteLine(); // NOVI RED
                Console.WriteLine("Resenje su realna i jednaka: ");
                Console.Write("X1 = X2 = {0}", x);
            }
            else
            {
                Console.WriteLine(); // NOVI RED
                Console.WriteLine("Resenja su konjugovano kompleksna!");
            }

            Console.WriteLine(); // NOVI RED
            Console.ReadKey();
    }
        }
}
