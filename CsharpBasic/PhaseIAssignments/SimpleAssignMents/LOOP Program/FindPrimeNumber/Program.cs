using System;
namespace FindPrimeNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the number");
            int limit=int.Parse(Console.ReadLine());
     
                  int count=0;
                  for(int prime=1; prime<=limit; prime++)
                  {
                    if(limit%prime==0)
                    {
                      count++;
                    }
                 }
                 if(count==2)
                {
                    Console.WriteLine($"{limit} is Prime");
                  
                }
                else
                 {
                    Console.WriteLine($"{limit} is not prime");
                    
                  }
            
            
        }
    
    }
}