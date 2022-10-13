using System;
namespace ByType 
{
    class program
  {

    static void Display(int number)
    {
     Console.WriteLine($"The Number is :{number}");
            
    }
    static void Display(string Message)
    {
      Console.WriteLine($"The Message was :{Message}");
      
    }
    public static void Main(string[] args)
    {
         Display(100);
         Display("Hello World");
    }
  }
}
