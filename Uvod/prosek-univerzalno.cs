using System;

public class MainClass 
{
    public static void Main(string[] args)
    {
        int zbir = 0;
        float prosek;
        const int brPredmeta = 11;
        int ocena;

        Console.WriteLine("Sta imas iz srpskog?");
        ocena = int.Parse(Console.ReadLine());
        zbir += ocena;

        Console.WriteLine("Sta imas iz matematike?");
        ocena = int.Parse(Console.ReadLine());
        zbir += ocena;

        Console.WriteLine("Sta imas iz fizickog?");
        ocena = int.Parse(Console.ReadLine());
        zbir += ocena;

        Console.WriteLine("Sta imas iz engleskog?");
        ocena = int.Parse(Console.ReadLine());
        zbir += ocena;

        Console.WriteLine("Sta imas iz fizike?");
        ocena = int.Parse(Console.ReadLine());
        zbir += ocena;

        Console.WriteLine("Sta imas iz hemije?");
        ocena = int.Parse(Console.ReadLine());
        zbir += ocena;

        Console.WriteLine("Sta imas iz ruskog?");
        ocena = int.Parse(Console.ReadLine());
        zbir += ocena;

        Console.WriteLine("Sta imas iz muzickog?");
        ocena = int.Parse(Console.ReadLine());
        zbir += ocena;

        Console.WriteLine("Sta imas iz likovnog?");
        ocena = int.Parse(Console.ReadLine());
        zbir += ocena;

        Console.WriteLine("Sta imas iz kung-fu-a?");
        ocena = int.Parse(Console.ReadLine());
        zbir += ocena;

        Console.WriteLine("Sta imas iz kibernetike?");
        ocena = int.Parse(Console.ReadLine());
        zbir += ocena;

        prosek = (float)zbir / brPredmeta;
        Console.WriteLine("Tvoj prosek je: " + prosek);
 }
}
