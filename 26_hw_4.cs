using System;
using System.Linq;
 
public class Example
{
    public static void Main()
    {	//Найти наименьшее и наибольшее число в массиве
		int[] myArray = {2, 6, 5, 5 }; 
 
        Console.WriteLine("Minimum number is " + myArray.Min());
        Console.WriteLine("Maximum number is " + myArray.Max());
    }
}
