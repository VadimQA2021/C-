using System;
					
public class Program
{
	public static void Main()
	{
		//Массив. Одномирные массивы
		
		//Обозначение массива
		int[] myArray;
		
		//Выделение памяти под массив. В данном случае мы обозначили, что массив у нас будет состоять
		//из 5 элементов
		myArray = new int[5];
		
		//Присвоение значения переменной массива
		myArray[1] = 3;
		Console.WriteLine("the first value is equal to");
		Console.WriteLine(myArray[1]);
		
		//Ввод значения переменной массива через консоль
		Console.WriteLine("enter the second value");
		myArray[2]  = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(myArray[2]);
		
		//Вывод элемента массива через переменную "a"
		myArray[3] = 33;
		int a = myArray[3];
		Console.WriteLine(a);

	}
}
