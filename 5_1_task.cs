using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        var userNumber = Convert.ToInt32(Console.ReadLine());

        if (userNumber % 2 == 0)
        {
            Console.WriteLine("Even number");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Odd number");
        Console.ReadKey();
    }
}
