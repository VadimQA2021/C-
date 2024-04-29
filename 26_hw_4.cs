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
		
		//символ
		//количество этого символа
		int quantityCharacter;
		
		//записать в массив
		
		
		
		char[] myArray;
		Console.WriteLine("Enter the quantity");
		quantityCharacter = Convert.ToInt32(Console.ReadLine());
		
		myArray = new char[quantityCharacter];
		for(int i = 0; i < quantityCharacter; i++)
		{
		myArray[i] = Convert.ToChar(Console.ReadLine());
		}
		
		for(int i = 0; i < quantityCharacter; i++)
		{
		Method(myArray[i]);
		}
		
		
		
    }
		//Функция
		static void Method(char character)
		{
		Console.WriteLine(character);
		}
}
