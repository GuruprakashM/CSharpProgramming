using System;
namespace FindLeapYear
{
  class Program
  {
    public static void Main(string[] args)
    {
       Console.WriteLine($"enter the Satrting limit");
       int start=int.Parse(Console.ReadLine());
      Console.WriteLine($"Enter the Ending limit");
      int endLimit=int.Parse(Console.ReadLine());
      for(int input=start; input<=endLimit;input++)
      {
        if(input%4==0)
        {
            Console.WriteLine($"{input} is Leap Year");
            
        }
      }
      
       
        
    }
  }
}
