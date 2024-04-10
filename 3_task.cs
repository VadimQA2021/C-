using System;
					
public class Program
	{
    public static void Main(string[] args)
    {
    int a;
    int b;
    
    Console.WriteLine("Enter the cost of the product");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the amount of money the buyer has $$$");
    b = Convert.ToInt32(Console.ReadLine());
    
    if (b >= a)
	{
		Console.WriteLine("Good. Buy it");
		return;
	}
        Console.WriteLine("Not enough money");
    }
}
