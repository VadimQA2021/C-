using System;
					
public class Program
{
	public static void Main()
	{
		// Заполнить массив с клавиатуры
		int cycle = 0;
		
		int[] myArray;
		Console.WriteLine("Determine the range length");
		int lenghtRange = Convert.ToInt32(Console.ReadLine());
		
		myArray = new int[lenghtRange];
		for(int i = 0; i < myArray.Length; i++)
		{
		Console.WriteLine("Enter the value of the element " + cycle++);	
		myArray[i] = Convert.ToInt32(Console.ReadLine());
		}
		
	}
}
