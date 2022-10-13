using System;
namespace StringSeparate 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the string");
            string inputString=Console.ReadLine();
            Console.WriteLine($"Entered String \n{inputString}");
            Console.WriteLine($"The Separated String");
            
            foreach (char output in inputString)
            {
                Console.Write($"{output} ");
                
            }
            
        }
    }
}
