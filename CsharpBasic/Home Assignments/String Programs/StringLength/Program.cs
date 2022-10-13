using System;
namespace StingLength 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the string");
            string input=Console.ReadLine();
            int count=0;
            foreach(char output in input )
            {
               count++;
            }
            Console.WriteLine($"The string length is {count}");
            
            
        }
    }
}
