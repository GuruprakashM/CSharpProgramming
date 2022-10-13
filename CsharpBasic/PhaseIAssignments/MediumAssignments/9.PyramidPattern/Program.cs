using System;
namespace PyramidPattern 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the limit");
            int limit=int.Parse(Console.ReadLine());
            for(int input=1; input<=limit; input++)
            {
                for(int output=1; output<=input; output++)
                if(input%2!=0)
                {
                    Console.Write($"* ");
                    
                    
                }
                Console.WriteLine(" ");
                
            }
            
        }
    }
}
