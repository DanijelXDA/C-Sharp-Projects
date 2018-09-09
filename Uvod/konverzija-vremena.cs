using System;

class MainClass 
  {
    public static void Main (string[] args) 
      {
        int sekunde = int.Parse(Console.ReadLine());

        int hh, mm, ss;

        hh = sekunde / 3600;
        mm = ( sekunde - (hh * 3600) ) / 60;
        ss = sekunde - ( ( mm * 60 ) + ( hh * 3600 ));

        if( hh > 24 ) // Provera da li smo premašili opseg sati
          hh -= 24; 

        if( mm > 60)
         {
           hh++;
           mm -= 60;
         }

        if( ss > 60 )
        {
          mm++;
          ss -= 60;
        }

        Console.WriteLine("{0}:{1}:{2}", hh, mm, ss);
        
      }
}
