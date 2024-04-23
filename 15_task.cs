using System;
					
public class Program
{
	public static void Main()
	{
		//Использовать числа в диапазоне заданном пользователем. Найти сумму всех чисел, умножение и среднее арифметическое. (for)
		// numberTo не должна быть меньше numberFrom. Сделать валидацию для этого
		
		decimal sum=0, multiplication = 1, amount = 0;
		int numberTo, numberFrom;
		
		numberTo = Convert.ToInt32(Console.ReadLine());
		numberFrom = Convert.ToInt32(Console.ReadLine());
		if(numberTo <= numberFrom)
		{
		Console.WriteLine("Error");
			return;
		}
			
		for ( int i = numberFrom ; i <= numberTo; i++)
		{
			Console.WriteLine(i);
			sum = sum + i;
			multiplication = multiplication * i;
			amount++;
		}
		Console.WriteLine("Summa");
		Console.WriteLine(sum);
		
		Console.WriteLine("Srednee arifmeticheskoe");
		Console.WriteLine(sum/amount);
		
		Console.WriteLine("multiplication");
		Console.WriteLine(multiplication);

	}
}
