using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        int brojCasova, minuti = 0;

        Console.WriteLine("Unesi koliko casova imas danas: ");
        brojCasova = int.Parse(Console.ReadLine());


        minuti += brojCasova * 45;
        for (int i  = 1; i < brojCasova; ++i)
        {
            if (i == 2)
            {
                minuti += 20; // Veliki odmor
                continue;
            }

            minuti += 5;
        }


        int sati = 8; // 8 ujutru

        // Problematičan deo!!! //
        sati += (minuti / 60);
        minuti -= (sati - 8) * 60; // Pretvaranje u minute

        Console.WriteLine(sati + ":" + minuti); // Ispis

        Console.ReadKey();
    }
}
