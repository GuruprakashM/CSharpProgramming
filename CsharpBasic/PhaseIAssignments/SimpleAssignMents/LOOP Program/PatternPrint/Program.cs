using System;
namespace PatternPrint 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the limit");
            int limit=int.Parse(Console.ReadLine());
            for(int output=1; output<=limit; output++)
            {
               for(int pattern=1; pattern<=output; pattern++)
               {
                Console.Write($"{output}");
                
               }
               Console.WriteLine();
               
            }
            
        }
    }
}