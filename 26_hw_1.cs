using System;
					
public class Program
{
	public static void Main()
	{
		// Заполнить массив с клавиатуры
		
		int[] myArray;
		myArray = new int[5];
		for(int i = 0; i < myArray.Length; i++)
		{
		Convert.ToInt32(Console.ReadLine());
		}
	}
}
