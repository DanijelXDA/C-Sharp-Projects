using System;

namespace Zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            string odgovor;
            int godine;

            do {
                Console.Write("Da li se bavite sportom? ");
                odgovor = Console.ReadLine();
            } while (odgovor != "DA" && odgovor != "NE"); 

            if(odgovor == "NE")
            {
                Console.Write("Koliko imate godina? ");
                godine = int.Parse(Console.ReadLine());

                return;
            }
            else {
                Console.Write("Kojim se sportom bavite? ");
                string sport = Console.ReadLine();

                Console.Write("Koliko sati nedeljno trenirate? ");
                int sati = int.Parse(Console.ReadLine());

                Console.Write("Koliko imate godina? ");
                godine = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
