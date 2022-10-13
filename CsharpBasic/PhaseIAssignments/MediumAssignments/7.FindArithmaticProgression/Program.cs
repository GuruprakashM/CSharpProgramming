
using System;
namespace FindArithmaticProgression
{
  class Program
  {
    public static void Main(string[] args)
    {
       Console.WriteLine($"enter the Satrting limit");
       int start=int.Parse(Console.ReadLine());
      Console.WriteLine($"Enter the Ending limit");
      int endLimit=int.Parse(Console.ReadLine());
      Console.WriteLine($"Enter the difference");
      int difference=int.Parse(Console.ReadLine());
      int sum=0;
      while(start<=endLimit)
      {
              sum=+start;
              Console.WriteLine($"{start}");
              start=start+ difference;
              
      }
      Console.WriteLine($"{sum}");
      
      
    }
  }
}