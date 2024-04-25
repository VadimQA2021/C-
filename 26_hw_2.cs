using System;
					
public class Program
{
	public static void Main()
	{
		// Вывести массив в обратном порядке
		
		int[] myArray = {2, 6, 4, 8}; 
		
		for(int i = myArray.Length-1; i >= 0; i--)
		{
		Console.WriteLine(myArray[i]);
		}
	}
}
