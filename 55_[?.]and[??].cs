using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
	int[] myArray = GetArray();
	Console.WriteLine("сумма элементов массива " + (myArray?.Sum() ?? 0));
	}
	
	static int[] GetArray()
	{
	int[] myArray = null;
	return	myArray;
	}
}
