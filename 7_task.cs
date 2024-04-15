using System;
     
public class Program
 {
    public static void Main(string[] args)
    {
		//В зависимости от номера дня недели вывести его название. Названия месяцев хранить в константах
	int dayNumber;

  
 Console.WriteLine("Enter the number of the day of the week to display its name");
  
 Console.WriteLine("Enter the number"); 
 dayNumber = Convert.ToInt32(Console.ReadLine()); 
  
  switch (dayNumber)
  {
  	case 1:
   Console.WriteLine("Monday");
	break;
  
		       
  
	case 2:
   Console.WriteLine("Tuesday");
	break;
		  
	case 3:
   Console.WriteLine("Wednesday");
	break;
		  
	case 4:
   Console.WriteLine("Thursday");
	break;
		  
	case 5:
   Console.WriteLine("Friday");
	break;
		  
	case 6:
   Console.WriteLine("Saturday");
	break;
		  
	case 7:
   Console.WriteLine("Sunday");
	break;
		  
	default : 
		  Console.WriteLine("Invalid character");
		  break;
  }
 }
}
