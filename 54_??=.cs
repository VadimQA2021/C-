using System;

public class Program
{
	static int[] GetArray()
	{
	int[] myArray = null;
	return myArray;
	}
	
    public static void Main(string[] args)
    {
       //ОПЕРАТОР ПРИСВАИВАНИЯ ОБЪЕДИНЕНИЯ СО ЗНАЧЕНИЕМ NULL
		int[] myArray = GetArray();
		myArray ??= new int[0];
		
		Console.WriteLine("количество элементов в массиве " + myArray.Length);
		
	}
}
