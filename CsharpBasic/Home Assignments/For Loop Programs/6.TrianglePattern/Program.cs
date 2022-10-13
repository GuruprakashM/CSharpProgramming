using System;
namespace TrianglePattern 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the limit");     
            int limit=int.Parse(Console.ReadLine());
            for(int i=1; i<=limit;i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write($"*");
                    
                }
                Console.WriteLine();
                
            }
        }
    }
}
