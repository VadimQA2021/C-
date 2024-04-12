using System;
     
public class Program
 {
    public static void Main(string[] args)
    {
    int a, b;
 char c;
  
 Console.WriteLine("Privet! Eto prostoy kalkulyator. On ummet +, -, *, /");
  
 Console.WriteLine("Vvedite chislo A"); 
 a = Convert.ToInt32(Console.ReadLine()); 
  Console.WriteLine("nujnoe deystvie");
 c = Convert.ToChar(Console.ReadLine());
 Console.WriteLine("Chislo B");
  b = Convert.ToInt32(Console.ReadLine());
 
  
  
  switch (c)
  {
  case '*':
   Console.WriteLine(a * b);
  break;
  case '/':
   Console.WriteLine(a / b);
  break;
   case '+':
   Console.WriteLine(a + b);
  break;
  case '-':
   Console.WriteLine(a - b);
  break;
  }
 }
}
