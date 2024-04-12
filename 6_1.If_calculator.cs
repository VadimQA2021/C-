using System;
     
public class Program
 {
    public static void Main(string[] args)
    {
    int a, b;
 char c;
  
 Console.WriteLine("Privet! Eto prostoy kalkulyator. On ummet +, -, *, /. Vvedite chislo A, nujnoe deystvie, Chislo B i vi poluchite rezultat.");
 a = Convert.ToInt32(Console.ReadLine()); 
 c = Convert.ToChar(Console.ReadLine());
 b = Convert.ToInt32(Console.ReadLine());
 
 if(c == '*')
 {
 Console.WriteLine(a * b);
 return;
 }
 else if(c == '/')  
 {
 Console.WriteLine(a / b);
 return;
 }
 else if(c == '-')
 {
 Console.WriteLine(a - b);
 }
 else if(c == '+')
 {
 Console.WriteLine(a + b); 
 }
 }
}
