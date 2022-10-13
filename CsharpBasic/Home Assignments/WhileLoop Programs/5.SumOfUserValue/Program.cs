using System;
namespace SumOfUserValue 
{
    class Program 
    {
        public static void Main(string[] args)
        {

            long inputs=0,split=0,sum=0;
            Console.WriteLine($"Enter the data");   
            inputs=long.Parse(Console.ReadLine());
            while(inputs!=0)
            {
                split =inputs%10;
                inputs=inputs/10;
                sum+=split;
            }
            Console.WriteLine($"{sum}");
            
            
            
        }
    }
}
