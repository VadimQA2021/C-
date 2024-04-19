using System;
					
public class Program
{
	public static void Main()
	{
		//Напишите программу, в которой в цикле do-while пользователь вводит по одному символу, а программа подсчитывает количество введенных символов. 
		//Когда пользователь вводит точку, ввод заканчивается, и программа выводит пользователю число введенных символов (не включая финальную точку)
		
		 char simvol;
		int summa = 0;
		
		do
		{
		simvol = Convert.ToChar(Console.ReadLine());
		summa++;	
		}while(simvol != '.');
		summa--;
		Console.WriteLine(summa);
	}
}
