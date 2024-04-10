using System;
					
public class Program
	{
    public static void Main(string[] args)
    {
    int a;
	int b;
	int age;
    
	Console.WriteLine("Enter your age");
	age = Convert.ToInt32(Console.ReadLine());	
	
	if (age <= 16)
	{
	Console.WriteLine("Age is not suitable for calculation");
	return;
	}
		
    Console.WriteLine("Enter your height");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter your weight");
	b = Convert.ToInt32(Console.ReadLine());
	
		
	int normalWeight = a - 110;
		
    if (normalWeight < b )
		Console.WriteLine("fat");
	else if (normalWeight > b)
		Console.WriteLine("skinny");
	else Console.WriteLine("normal");
	}
}
