using System;
namespace FindCube 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Limit");
            int limit=Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=limit;i++)
            {
                Console.WriteLine($"Number is{i} and the cube of{i} is {Math.Pow(i,3)}");
                
            }
            
        }
    }
}