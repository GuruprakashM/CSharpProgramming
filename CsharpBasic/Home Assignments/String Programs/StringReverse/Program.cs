using System;
namespace StringReverse 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the String");
            string input=Console.ReadLine();
            Console.WriteLine($"Reverse String");
            
            for(int start=input.Length-1; start>=0; start--)
            {
                Console.Write($"{input[start]} ");
                
            }
            
        }
    }
}

