using System;
namespace ByNumberOfArguments 
{
    class Program 
    {
        static void Display(int number)
        {
            Console.WriteLine($"{number}");
            
        }
        static void Display(int number1, int number2)
        {
            Console.WriteLine($"Number 1 :{number1} \nNumber2: {number2}");
            
        }
        public static void Main(string[] args)
        {
            Display(10);
            Display(100,20);
            
        }
    }
}