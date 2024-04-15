using System;
     
public class Program
 {
    public static void Main(string[] args)
    {
    int numberFirst, numberSecond;
 char action;
  
 Console.WriteLine("Privet! Eto prostoy kalkulyator. On ummet +, -, *, /");
  
 Console.WriteLine("Vvedite chislo A"); 
 numberFirst = Convert.ToInt32(Console.ReadLine()); 
  Console.WriteLine("nujnoe deystvie");
 action = Convert.ToChar(Console.ReadLine());
 Console.WriteLine("Chislo B");
  numberSecond = Convert.ToInt32(Console.ReadLine());
 
  
  
  switch (action)
  {
  case '*':
   Console.WriteLine(numberFirst * numberSecond);
  break;
  case '/':
   Console.WriteLine(numberFirst / numberSecond);
  break;
   case '+':
   Console.WriteLine(numberFirst + numberSecond);
  break;
  case '-':
   Console.WriteLine(numberFirst - numberSecond);
  break;
	default : 
		  Console.WriteLine("Vy vveli nekorrektnyj simvol");
		  break;
  }
 }
}
