using System;

public class Program
{
	public static void Main(string[] args)
	{
		//Подсчитывать количество четных и нечетных чисел в диапозоне, указанном пользователем
		int count = 0;
		int sumChetnoeChislo = 0;
		int sumNeChetnoeChislo = 0;
		const string chetnoeChislo = "Chetnoe Chislo";
		const string neChetnoeChislo = "Nechetnoe Chislo";
		while (count < 10)
		{
			count++;
			Console.WriteLine(count);
			if(count % 2 == 0)
			{
			sumChetnoeChislo++;
			}
			else
			{
			sumNeChetnoeChislo++;
			}
		}
		Console.WriteLine(chetnoeChislo + sumChetnoeChislo);
		Console.WriteLine(neChetnoeChislo + sumNeChetnoeChislo);
	}
}
