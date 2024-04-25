using System;
					
public class Program
{
	public static void Main()
	{
		// Найти сумму четных чисел в массиве
		int sum = 0;
		
		int[] myArray;
		Console.WriteLine("Determine the range length");
		int lenghtRange = Convert.ToInt32(Console.ReadLine());
		
		myArray = new int[lenghtRange];
		
		for(int i = 0; i < lenghtRange; i++)
		{
		myArray[i] = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(myArray[i]);
			if(myArray[i] %2 == 0)
			{
			sum = sum + myArray[i];
			}
	
		}
		Console.WriteLine(sum);
	}
}
