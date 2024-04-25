using System;
					
public class Program
{
	public static void Main()
	{
		// Найти сумму четных чисел в массиве
		int sum = 0;
		
		int[] myArray = {2, 6, 5, 5 }; 
		
		for(int i = myArray.Length-1; i >= 0; i--)
		{
		Console.WriteLine(myArray[i]);
			if(myArray[i] %2 == 0)
			{
			sum = sum + myArray[i];
			}
	
		}
		Console.WriteLine(sum);
	}
}
