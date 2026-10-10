using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("wellcome to CalcCsharp\nby JonHon studios\nprototype 2");
        Console.WriteLine("this can currently add/subtract");
        Console.Write("\ntype your starting num here> ");
        Double calc = Convert.ToInt32(Console.ReadLine());//data type 1
        Console.Write("\nif you want to add type here> ");
        calc = calc + Convert.ToInt32(Console.ReadLine());

        Console.Write("\nif you want to subtract type here> ");
        calc = calc - Convert.ToInt32(Console.ReadLine());

        Console.Write("\nif you want to multiply type here> ");
        calc = calc * Convert.ToInt32(Console.ReadLine());

        Console.Write("\nif you want to divide type here> ");
        calc = calc / Convert.ToInt32(Console.ReadLine());

        Console.Write("\nif you want to round a num type here> ");
        Double round = Convert.ToInt32(Console.ReadLine());
        double rounded = Math.Round(round);



        Console.WriteLine("this is the answer: " + calc);
        Console.WriteLine("your rounded num is: " + rounded);
        Console.WriteLine("\nfor debugging:\n" + calc.GetType() + "\n" + rounded.GetType);

        Console.ReadKey();
    }
}
