using System;

public class Program
{
	public static void Main(string[] args)
		
	{
		//Напишите программу, в которой в цикле do-while пользователь вводит по одному символу, а программа подсчитывает количество введенных символов(sum). 
		//Когда пользователь вводит точку, ввод заканчивается, и программа выводит пользователю число введенных символов (не включая финальную точку)(while();)

		char msg;
		int sum = 0;
		
	     do
		 {
		msg = Convert.ToChar(Console.ReadLine());
		sum++;
			
		 } while(msg != '.');
		sum--;
		Console.WriteLine(sum);
	}
}
