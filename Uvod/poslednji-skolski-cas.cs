using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        int brojCasova, i, minuti = 0;

        Console.WriteLine("Unesi koliko casova imas danas: ");
        brojCasova = int.Parse(Console.ReadLine());


        minuti += brojCasova * 45;
        for (i = 2; i < brojCasova; ++i)
        {
            minuti += 5;
        }

        // i je lokalnog nivoa!
        if ( i > 2)
             minuti += 20;


        int sati = 8; // 8 ujutru

        sati += minuti / 60;
        minuti -= (sati - 8) * 60; // Pretvaranje u minute

        Console.WriteLine(sati + ":" + minuti); // Ispis

        Console.ReadKey();
    }
}
