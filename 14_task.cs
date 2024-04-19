public class Program
{
	public static void Main()
	{
		//Напишите программу, в которой в цикле while пользователь вводит произвольное количество чисел, а программа вычисляет их сумму. 
		//После каждого ввода спрашивайте пользователя, закончил ли он ввод чисел. Если пользователь ввел "y" или "Y", то ввод чисел завершается, 
		//после чего программа должна вывести сумму всех введенных чисел и их среднее арифметическое.
		
		int chislo, sum=0, amount = 0;
		char otvetNaVopros=' ';
		
		
		while (otvetNaVopros != 'y' || otvetNaVopros != 'Y')
		{
			chislo = Convert.ToInt32(Console.ReadLine());
			sum += chislo;
			amount++;
			Console.WriteLine("Vvod zakonchen?");
			otvetNaVopros = Convert.ToChar(Console.ReadLine());
		}
		Console.WriteLine(sum);
		Console.WriteLine(sum/amount);
	}
}
