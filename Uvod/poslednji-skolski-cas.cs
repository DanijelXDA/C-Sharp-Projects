using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        int N;
        int sum = 0;
        int min, hour;

        Console.WriteLine("How many classes do you have?");
        N = int.Parse(Console.ReadLine()); // Input

        for (int i = 2; i < N; i++)
        {
            sum += 5;
        }
        // 20 + 45 = 65; 1h 5 min
        sum += 20; // Number of classes must be greater then 2
        sum += N * 45; // Number of classes

        hour = sum / 60; // 1h = 60 mins
        min = sum - (hour * 60); // Koliko ima minuta

        if (min > 60)
        {
            hour += 1;
            min -= 60;
        }
        // Hour + 8 because 1st school class starts from 8 AM
        Console.WriteLine("{0}" + ":" + "{1}", hour + 8, min);

        Console.ReadKey();
    }
}
