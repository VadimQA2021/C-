using System;

public class Program
{
	public static void Main(string[] args)
		
	{
		//Необходимо суммировать все нечётные целые числа в диапазоне (i <= n), который введёт пользователь с клавиатуры (i).
	        int n, i, sum;
        i = 1;
        sum = 0;
		
        n = Convert.ToInt32(Console.ReadLine());

        while (i <= n)
        { 
			if(	i % 2 != 0)
			sum += i;
           i++;
        }
        Console.WriteLine(sum);
	}
}
