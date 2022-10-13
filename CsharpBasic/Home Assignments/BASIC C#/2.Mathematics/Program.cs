using System;
namespace Mathematics 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int firstNumber,secondNumber;
            Console.WriteLine("Enter the 2 values");
            firstNumber=int.Parse(Console.ReadLine());
            secondNumber=int.Parse(Console.ReadLine());
            Console.WriteLine("ADD:");
            Console.WriteLine(firstNumber+secondNumber);
            Console.WriteLine("SUB:");
            Console.WriteLine(firstNumber-secondNumber);
            Console.WriteLine("MUL:\n" +(firstNumber*secondNumber));
            Console.WriteLine("DIV:\n" +(firstNumber/secondNumber));
            Console.WriteLine("MUDULO:\n"+(firstNumber%secondNumber));
            
        }
    }
}