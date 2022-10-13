using System;
namespace SubStringPrint 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the string");
            string input=Console.ReadLine();
            Console.WriteLine($"Enter the Substring Start position");
            int start=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the Substring emd Position");
            int end=int.Parse(Console.ReadLine());
            for(int output=start; output<end; output++ )
            {
                Console.Write($"{input[output]}");
                
            }
            
            
        }
    }
}