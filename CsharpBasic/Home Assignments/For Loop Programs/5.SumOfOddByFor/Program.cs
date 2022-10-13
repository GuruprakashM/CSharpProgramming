using System;
namespace SumOdOddByFor
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int sum=0;
            Console.WriteLine($"Enter the Limit");
            int limit=Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=(2*limit); i++)   
            {
               if(i%2!=0)
               {
                Console.WriteLine($"{i}");
                sum+=i;
               }
                
            }         
            Console.WriteLine($"{sum}");
            
        }
    }
}
