using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Написать метод, который выводит на экран строку.
		//Символы, из которых состоит строка и их количество вводятся пользователем
		
		//модификаторы тип_возвращаемого_значения название_методы(параментры)
		//{
		//	тело метода
		//}

	    //Важно, чтобы тип данных совпадал. Массив я заполнял char и значит на выводе данных нужно тоже использовать char.
		
		
		
	//1. Сначала у меня будет цикл, который записывает данные в массив
		//Определяем длину массива
		Console.WriteLine("Enter the quantity");
		int quantity = Convert.ToInt32(Console.ReadLine());
		//Через кончоль вводим длину массива
		
		//Делаю массив
		char[] myArray;
		myArray = new char[quantity];
		//Заполняю массив с помощью цикла
		for(int i = 0; i < quantity; i++)
		{
		myArray[i] = Convert.ToChar(Console.ReadLine());
		}
		//3. Цикл вывода данных массива с помощью метода
		for (int i = 0; i < quantity; i++)
		{
		Method(myArray[i]);
		}
		
	//2. Метод вывода в консоль
		
	}
	static void Method(char character)
	{
		Console.WriteLine(character);

	}
		
}
