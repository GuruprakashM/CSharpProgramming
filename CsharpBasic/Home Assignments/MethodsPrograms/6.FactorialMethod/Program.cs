using System;
namespace FactorialMethod 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the limit");
            int limit=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Factorial of {limit} is {FactorialMethod(limit)}");
            
            int FactorialMethod(int limit)
            {
                     int result=1;
                     for(int start=1; start<=limit; start++)
                     {
                        result*=start;
                     }
                     return result;
                     
            }
            
        }
    }
}
