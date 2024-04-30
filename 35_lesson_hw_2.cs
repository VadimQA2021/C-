using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
       //Написать метод для поиска индекса элементов массива (тип элементов в массиве - int).
		//Метод должен вернуть индекс первого найденного элемента(если он будет найден).
		
		//Определим размер массива
		Console.WriteLine("Enter size array: ");
		int arraySize;
		arraySize = Convert.ToInt32(Console.ReadLine());
		//Создам массив
		int[] myArray;
		myArray = new int[arraySize];
		//Наполним массив данными с помощью цикла
		Console.WriteLine("Enter the values in the array: ");
		for(int i = 0; i < arraySize; i++)
		{
		myArray[i] = Convert.ToInt32(Console.ReadLine());
		}
		//Напишу условие, которое определяет индекс элемента в массиве
		//Если элемента в массиве нет, то написать "Error! This element is not in the array"
		int numberSearch;
		Console.WriteLine("Enter a value to search for");
		numberSearch = Convert.ToInt32(Console.ReadLine());
		int index = FindIndex(myArray, numberSearch);
		if(index == -1) 
			Console.WriteLine("Nothing was found"); 
		else Console.WriteLine(index);
		
		
	}
	
		public static int FindIndex(int[] array, int numberSearch)
		{
			for(int i = 0; i < array.Count(); i++)
			{
				if (numberSearch == array[i])
					return i;
			}
			return -1;
		}
}
