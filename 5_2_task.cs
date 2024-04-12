using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        var userNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(userNumber % 2 == 0 ? "Even number" : "Odd number");
        Console.ReadKey();
    }
}
