using System;
namespace PyramidPattern
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the limit");
            int limit=Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<limit; i++)
            {
                for(int j=1; j<=limit-i; j++)
                {
                    Console.Write(" ");
                    
                }
                for(int k=1; k<=i;k++)
                {
                    Console.Write("* ");
                    
                }
                Console.WriteLine();
                
            }
            
        }
    }
}
