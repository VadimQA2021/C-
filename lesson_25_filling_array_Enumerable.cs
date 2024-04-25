using System;
					
public class Program
{
	public static void Main()
	{
		// создание массива и одновременное его наполнение
			int[] myArray = new int[5] {5, 4, 3, 2, 1}; 
		// с помощью метода Enumerable.Range массив из 5 значение наполнится данными, начиная с 4.
			int[] myArray = Enumerable.Range(4, 5).ToArray();
		
		// с помощью метода Enumerable.Repeat массив из 10 значение наполнится 5 по всем строкам.
			int[] myArray = Enumerable.Repeat(5, 10).ToArray();
	}
}
