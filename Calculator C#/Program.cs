using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("wellcome to CalcCsharp\nby JonHon studios\n version 0.0.1 prototype");
        Console.WriteLine("this can currently add/subtract");
        Console.Write("\ntype your starting num here> ");
        Double calc = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nif you want to add type here> ");
        calc = calc + Convert.ToInt32(Console.ReadLine());

        Console.Write("\nif you want to subtract type here> ");
        calc = calc - Convert.ToInt32(Console.ReadLine());

        Console.Write("\nif you want to multiply type here> ");
        calc = calc * Convert.ToInt32(Console.ReadLine());

        Console.Write("\nif you want to divide type here> ");
        calc = calc / Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("this is the answer: " + calc);

        Console.ReadKey();
    }
}