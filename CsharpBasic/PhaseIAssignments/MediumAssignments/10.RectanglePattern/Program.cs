using System;
namespace RectanglePattern
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the length");
            int length= int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the Width");
            int width = int.Parse(Console.ReadLine());
            for( int i=0; i<length; i++)
            {
                for( int j=0; j<width; j++)
                {
                     if(i==0 || j==0 || i==length-1 || j==width-1)
                     {
                        Console.Write($"*");
                        
                     }
                     else
                     {
                        Console.Write($" ");
                        
                     }
                }
                Console.WriteLine();
                
            }
            
            
        }
    }
}