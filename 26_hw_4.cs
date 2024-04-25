using System;
					
public class Program
{
	public static void Main()
	{
		// Найти сумму четных чисел в массиве
		
		int[] myArray;
		Console.WriteLine("Determine the range length");
		int lenghtRange = Convert.ToInt32(Console.ReadLine());
		
		myArray = new int[lenghtRange];
		
		
		//В этом цикле проиходит ввод данных
		for(int i = 0; i < lenghtRange; i++)
		myArray[i] = Convert.ToInt32(Console.ReadLine());
		
		int minValue = myArray[0];
			
		//В этом цикле проиходит сравнение с минимальных значением
		for(int i = 1; i < lenghtRange; i++)
		{
		if(myArray[i] < minValue)
			minValue = myArray[i];		
		}
		Console.WriteLine(minValue);
	}
}
