using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poslednji_skolski_cas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int zbir = 0;
            int minut, sat;

            Console.WriteLine("Unesi koliko casova imas danas");
            N = int.Parse(Console.ReadLine()); // Unos

            for (int i = 1; i < N; i++)
            {
                if (i == 2)
                {
                    zbir += 20;
                }
                else
                {
                    zbir += 5;
                }
            }

            zbir += N * 45; // Broj časova

            sat = zbir / 60; // 1 sat ima 60 minuta
            minut = zbir - (sat * 60); // Koliko ima minuta

            if (minut > 60)
            {
                sat += 1;
                minut -= 60;
            }

            Ispis(minut, sat);

            Console.ReadKey();
        }

        private static void Ispis(int minut, int sat) => Console.WriteLine("{0}" + ":" + "{1}", sat + 8, minut);
    }
}
