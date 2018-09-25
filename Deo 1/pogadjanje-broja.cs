/*
 * C# Program koji generiše broj koji korisnik pogađa
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int zamisljeniBroj = slucajanBroj(1, 101);
            int pokusaji = 1;
            while (true)
            {
                Console.Write("\nUnesite broj u opsegu od 1 do 100 (0 za kraj programa): ");
                int ulaz = int.Parse(Console.ReadLine());
                if (ulaz == 0)
                    return;
                else if (ulaz < zamisljeniBroj)
                {
                    Console.WriteLine("Premali broj, pokušaj ponovo.");
                    ++pokusaji;
                    continue;
                }
                else if (ulaz > zamisljeniBroj)
                {
                    Console.WriteLine("Preveliki broj, pokušaj ponovo.");
                    ++pokusaji;
                    continue;
                }
                else
                {
                    Console.WriteLine("Pogodili ste! Broj koji sam zamislio je {0}!", zamisljeniBroj);
                    Console.WriteLine("Uspeli ste iz {0}. pokušaja.\n", pokusaji);
                    break;
                }
            }
        }

    }
    static int slucajanBroj(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
}
