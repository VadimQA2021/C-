using System;
					
public class Program
{
	public static void Main()
	{
		// Заполнить массив с клавиатуры
		
		int[] myArray;
		myArray = new int[5];
		myArray[0] = Convert.ToInt32(Console.ReadLine());
		myArray[1] = Convert.ToInt32(Console.ReadLine());
		myArray[2] = Convert.ToInt32(Console.ReadLine());
		myArray[3] = Convert.ToInt32(Console.ReadLine());
		myArray[4] = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(myArray[0]);
		Console.WriteLine(myArray[1]);
		Console.WriteLine(myArray[2]);
		Console.WriteLine(myArray[3]);
		Console.WriteLine(myArray[4]);
	}
}
