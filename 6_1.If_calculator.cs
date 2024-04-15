using System;
     
public class Program
 {
    public static void Main(string[] args)
    {
    int numberFirst, numberSecond;
 	char c;
  
 	Console.WriteLine("Privet! Eto prostoy kalkulyator. On umeet +, -, *, /. Vvedite chislo A, nujnoe deystvie, Chislo B i vi poluchite rezultat.");
 numberFirst = Convert.ToInt32(Console.ReadLine()); 
 c = Convert.ToChar(Console.ReadLine());
 numberSecond = Convert.ToInt32(Console.ReadLine());
 
 if(c == '*')
 {
 Console.WriteLine(numberFirst * numberSecond);
 return;
 }
 else if(c == '/')  
 {
 Console.WriteLine(numberFirst / numberSecond);
 return;
 }
 else if(c == '-')
 {
 Console.WriteLine(numberFirst - numberSecond);
 }
 else if(c == '+')
 {
 Console.WriteLine(numberFirst + numberSecond); 
 }
		else Console.WriteLine("Error!");}
 }
