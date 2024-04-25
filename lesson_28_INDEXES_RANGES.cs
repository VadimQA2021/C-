using System;
using System.Linq;
 
public class Example
{
    public static void Main()
    {	//ИНДЕКСЫ И ДИАПАЗОНЫ В C#8
		
		int[] myArray = {1, 22, 43, 67, 98};
		
		//Вывыести последний элемент массива
		
		Console.WriteLine(myArray[^1]);
		
		//Извлечь диапозон
		
		int[] myArray2 =  myArray[2..4];
		
		//Извлечить диапозон от числа и дальше
		
		int[] myArray3 =  myArray[2..];
		
		//Извлечить диапозон до определенного числа числа
		
		int[] myArray4 =  myArray[..4];
    }
}
