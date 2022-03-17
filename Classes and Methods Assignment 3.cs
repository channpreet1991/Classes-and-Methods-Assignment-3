using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
  public class Class3{
    //takes two integers , subtracts the second value from first and displays the result
    public void method_three(int first, int second ){
      first = first - second;
      Console.WriteLine("First: " + first);
      Console.WriteLine("Second: " + second);
    }
    
    
  }
  
	public class Program
	{
		public static void Main(string[] args)
		{
		  Class3 c1 = new Class3();
		  Console.WriteLine("Calling method_third with (10, 5)");
		  c1.method_three(first:10, second:5);
			
		}
		
	}
	
}