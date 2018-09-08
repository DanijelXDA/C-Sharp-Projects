using System;

public class MainClass 
{
    public static void Main(string[] args)
    {
      double prosek;
      int brPredmeta = 11;
      int srpski = 4;
      int matematika = 5;
      int fizicko = 5;
      int engleski = 5;
      int fizika = 5;
      int hemija = 4;
      int ruski = 5;
      int muzicko = 5;
      int likovno = 5;
      int kung_fu = 5;
      int kibernetika = 5;

      double zbir = srpski + matematika + fizicko + engleski + fizika +
          hemija + ruski + muzicko + likovno + kung_fu + kibernetika;

      prosek = zbir / brPredmeta;

      Console.WriteLine("Tvoj prosek je: " + prosek);
 }
}
