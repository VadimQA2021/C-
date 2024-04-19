using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Найдите сумму  от n+...10+9+8+...1, где число n вводится пользователем с клавиатуры.

        int n, i, sum;
        n = 1;
        sum = 0;
        i = Convert.ToInt32(Console.ReadLine());

        while (i >= n)
        { 
            sum += i;
           i--;
        }
        Console.WriteLine(sum);
    }
}

