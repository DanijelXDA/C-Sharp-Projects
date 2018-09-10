using System;

class MainClass 
{
    public static void Main (string[] args) 
    {
        int N;

        N = int.Parse(Console.ReadLine());

        switch(N) 
        {
          case 1 : Console.WriteLine("8:45"); break;
          case 2 : Console.WriteLine("9:35"); break;
          case 3 : Console.WriteLine("10:40"); break;
          case 4 : Console.WriteLine("11:30"); break;
          case 5 : Console.WriteLine("12:20"); break;
          case 6 : Console.WriteLine("13:10"); break;
          case 7 : Console.WriteLine("14:00"); break;
          case 8 : Console.WriteLine("14:50"); break;
          case 9 : Console.WriteLine("15:30"); break;
      }

    }
}
