using System;
namespace MultiplyTable 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Multiple Table YOU want");
            int table=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the Limit");
            int limit=int.Parse(Console.ReadLine());
            for(int output=1; output<=limit; output++)
            {
                Console.WriteLine($"{table} X {output} = {table*output}");
                
            }
            
            
        }
    }
}