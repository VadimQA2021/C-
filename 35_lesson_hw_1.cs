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
		char character;
		//количество этого символа
		int quantityCharacter;
		
		Console.WriteLine("Enter a character");
		character = Convert.ToChar((Console.ReadLine()));
		
		int[] myArray;
		Console.WriteLine("Enter the quantity");
		quantityCharacter = Convert.ToInt32(Console.ReadLine());
		
		myArray = new int[quantityCharacter];
		for(int i = 0; i < quantityCharacter; i++)
		{
		Console.Write(character);
		}
		
		
    }
}
